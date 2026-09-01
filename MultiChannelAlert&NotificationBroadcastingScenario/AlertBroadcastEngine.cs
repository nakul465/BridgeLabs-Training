using System;
using System.Diagnostics;
using System.Reflection;

namespace MultiChannelAlert_NotificationBroadcastingScenario
{

    public enum AlertSeverity
    {
        Info = 1,
        Warning = 2,
        Critical = 3
    }

    public class AlertEvent
    {
        public string AlertId { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public AlertSeverity Severity { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public AlertEvent(string alertId,string source,string category,AlertSeverity severity,string message,DateTime timestamp)
        {
            AlertId = alertId;
            Source = source;
            Category = category;
            Severity = severity;
            Message = message;
            Timestamp = timestamp;
        }
    }

    public class AlertCategorySpec
    {
        public string Category { get; set; }
        public AlertSeverity DefaultSeverity { get; set; }

        public AlertCategorySpec(string category,AlertSeverity defaultSeverity)
        {
            Category = category;
            DefaultSeverity = defaultSeverity;
        }
    }


    [AttributeUsage(AttributeTargets.Method)]
    class DefaultSeverityAttribute : Attribute
    {
        public string Severity { get; set; }

        public DefaultSeverityAttribute(string severity)
        {
            Severity = severity;
        }
    }


    [AttributeUsage(AttributeTargets.Method)]
    class EscalationPolicyAttribute : Attribute
    {
        public string Policy { get; set; }
        public EscalationPolicyAttribute(string policy)
        {
            Policy = policy;
        }
    }


    public class AlertDispatchFailedException : Exception
	{
		public string AlertID { get; set; }
		public string ChannelName { get; set; }
		
        public AlertDispatchFailedException(string alertID, string channelName):base($"Alert Dispatch failed AlertId : {alertID} channelName : {channelName}")
        {
            AlertID = alertID;
            ChannelName = channelName;
		}
    }


    class InvalidAlertSeverityException : Exception
    {
        public int InvalidSeverity{get;set;}
		public InvalidAlertSeverityException(int severity):base($"Invalid Alert Severity {severity}")
		{
            InvalidSeverity = severity;
		}
    }


    public class RateLimitTracker : IDisposable
    {
        private List<DateTime> dispatchTimes = new List<DateTime>();
        public bool IsDisposed { get; set; }

        public void Add(DateTime timestamp)
        {
            if (IsDisposed)
            {
                throw new Exception("RateLimitTracker : already disposed");
            }
            dispatchTimes.Add(timestamp);
        }

        public int CountRecent(DateTime now,TimeSpan window)
        {
            if (IsDisposed)
            {
                throw new Exception("RateLimitTracker : already disposed");
            }
            return dispatchTimes.Count(time => now - time <= window);
        }

        public void Clear()
        {
            dispatchTimes.Clear();
        }

        public void Dispose()
        {
            if (IsDisposed)return;
            dispatchTimes.Clear();
            IsDisposed = true;
            AlertDispatchSession.TrackerDisposedCount++;
        }
    }


    public class AlertDispatchSession:IDisposable
    {
        private readonly List<string> dispatchLog = new List<string>();
        private RateLimitTracker? tracker;
        private bool disposed;
        public static int ActiveSessions { get; set; }
        public static int TrackerDisposedCount { get; set; }

        public RateLimitTracker Tracker
        {
            get
            {
                if (disposed)
                {
                    throw new Exception("AlertDispatchSession : Already disposed");
                }
                return tracker!;
            }
        }

        public AlertDispatchSession()
        {
            tracker = new RateLimitTracker();
            ActiveSessions++;
        }

        public void Log(string message)
        {
            if (disposed)
            {
                throw new Exception("AlertDispatchSession : Already Disposed");
            }
            dispatchLog.Add($"{DateTime.Now} - {message}");
        }

        public void DisplayLog()
        {
            foreach (string log in dispatchLog)
            {
                Console.WriteLine(log);
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposed)return;

            if (disposing)
            {
                dispatchLog.Clear();
                tracker?.Dispose();
                tracker = null;
                ActiveSessions--;
            }
            disposed = true;
        }
    }

    public class AlertBroadcastEngine
	{
        public event Action<AlertEvent> OnCallEscalationTriggered;
        public event Action<AlertEvent> DashboardAlertPublished;

        private Action<AlertEvent, string> dispatchLogger;
        private Dictionary<string, AlertCategorySpec> categorySpecs = new Dictionary<string, AlertCategorySpec>();

        public static Predicate<AlertEvent> CreateSeverityEscalationRule(int criticalThreshold)
        {
            return alert =>(int)alert.Severity >=criticalThreshold;
        }

        public AlertBroadcastEngine(Action<AlertEvent, string> dispatchLogger)
        {
            this.dispatchLogger = dispatchLogger;
        }

        public void AddCategory(AlertCategorySpec spec)
        {
            categorySpecs[spec.Category] = spec;
        }

        public static Func<AlertEvent, bool>CreateRateLimitRule(int maxPerMinute)
        {
            List<DateTime> recentDispatches = new List<DateTime>();
            return alert =>
            {
                DateTime currentTime =alert.Timestamp;
                recentDispatches.RemoveAll(time =>currentTime - time >TimeSpan.FromMinutes(1));
                if (recentDispatches.Count >=maxPerMinute)
                {
                    return false;
                }
                recentDispatches.Add(currentTime);
                return true;
            };
        }

        public static Func<IEnumerable<AlertEvent>,AlertEvent,TimeSpan?> CreateTimeSinceLastAlertCalculator()
        {
            return (alerts, currentAlert) =>
            {
                DateTime? previousAlert = alerts.Where(alert => alert.Source == currentAlert.Source &&alert.Timestamp <currentAlert.Timestamp).Select(alert =>(DateTime?)alert.Timestamp).OrderByDescending(time => time).FirstOrDefault();
                if (previousAlert == null)
                {
                    return null;
                }
                return currentAlert.Timestamp - previousAlert.Value;
            };
        }

        [DefaultSeverity("Critical")]
        [EscalationPolicy("PageImmediately")]
        private void ProcessCriticalCategory(AlertEvent alert)
        {
        }


        [DefaultSeverity("Warning")]
        [EscalationPolicy("Dashboard")]
        private void ProcessNormalCategory(AlertEvent alert)
        {
        }

        private (AlertSeverity defaultSeverity,string policy) GetAttributeMetadata(AlertEvent alert)
        {
            MethodInfo? method;
            if (alert.Severity ==AlertSeverity.Critical)
            {
                method =typeof(AlertBroadcastEngine).GetMethod(nameof(ProcessCriticalCategory),BindingFlags.NonPublic |BindingFlags.Instance);
            }
            else
            {
                method =typeof(AlertBroadcastEngine).GetMethod(nameof(ProcessNormalCategory),BindingFlags.NonPublic |BindingFlags.Instance);
            }


            DefaultSeverityAttribute?severityAttribute =method?.GetCustomAttribute<DefaultSeverityAttribute>();
            EscalationPolicyAttribute?policyAttribute = method?.GetCustomAttribute<EscalationPolicyAttribute>();
            AlertSeverity severity =AlertSeverity.Warning;


            if (severityAttribute != null)
            {
                Enum.TryParse(severityAttribute.Severity,true,out severity);
            }

            return (severity,policyAttribute?.Policy ??"None");
        }

        public bool ShouldEscalate(AlertEvent alert,Predicate<AlertEvent>escalationRule)
        {
            var metadata = GetAttributeMetadata(alert);
            bool attributeBaseline =metadata.defaultSeverity ==AlertSeverity.Critical;
            bool liveEscalation =escalationRule(alert);
            return attributeBaseline || liveEscalation;
        }

        public void ProcessBatch(IEnumerable<AlertEvent> alerts, AlertDispatchSession session, Predicate<AlertEvent> escalationRule, Func<AlertEvent, bool> rateLimitRule, Predicate<AlertEvent> deduplicationRule, Func<string, bool>? failingChannel = null)
        {
            HashSet<string> alertIds = new();
            foreach (AlertEvent alert in alerts)
            {
                ValidateAlert(alert);
                if (!alertIds.Add(alert.AlertId))
                    throw new ArgumentException($"Duplicate AlertId: {alert.AlertId}");
            }
            foreach (AlertEvent alert in alerts)
            {
                bool rateAllowed = rateLimitRule(alert);
                bool notDuplicate = deduplicationRule(alert);
                if (!rateAllowed)
                {
                    session.Log($"{alert.AlertId} - SUPPRESSED - Rate Limited");
                    continue;
                }

                if (!notDuplicate)
                {
                    session.Log($"{alert.AlertId} - SUPPRESSED - Duplicate");
                    continue;
                }

                try
                {
                    Dispatch(alert, "Dashboard", failingChannel);
                    DashboardAlertPublished?.Invoke(alert);
                    session.Log($"{alert.AlertId} - Dashboard dispatched");
                    if (ShouldEscalate(alert, escalationRule))
                    {
                        Dispatch(alert, "OnCall", failingChannel);
                        OnCallEscalationTriggered?.Invoke(alert);
                        session.Log($"{alert.AlertId} - OnCall dispatched");
                    }
                }
                catch (AlertDispatchFailedException ex)
                {
                    session.Log($"{alert.AlertId} - FAILED - {ex.ChannelName}");
                }
                finally
                {
                    session.Tracker.Add(alert.Timestamp);
                }
            }
        }

        private void Dispatch(AlertEvent alert, string channel, Func<string, bool>? failingChannel)
        {
            if (failingChannel != null && failingChannel(channel))
                throw new AlertDispatchFailedException(alert.AlertId, channel);

            dispatchLogger(alert, channel);
        }

        private void ValidateAlert(AlertEvent alert)
        {
            if (string.IsNullOrWhiteSpace(alert.Message))
                throw new ArgumentException("Alert message cannot be null or empty.");

            if (!Enum.IsDefined(typeof(AlertSeverity), alert.Severity))
                throw new InvalidAlertSeverityException((int)alert.Severity);
        }

        public string GetNoisiestSource(IEnumerable<AlertEvent> alerts)
        {
            return alerts.GroupBy(alert => alert.Source).OrderByDescending(group => group.Count()).Select(group => group.Key).First();
        }
    }
}

