namespace MultiChannelAlertTestProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using MultiChannelAlert_NotificationBroadcastingScenario;

[TestFixture]
public class AlertBroadcastEngineTests
{
    private AlertBroadcastEngine CreateEngine()
    {
        Action<AlertEvent, string> logger = (alert, channel) => { };
        return new AlertBroadcastEngine(logger);
    }

    private AlertEvent CreateAlert(string id = "A1", string source = "Server-1", string category = "CPU", AlertSeverity severity = AlertSeverity.Warning, string message = "CPU high", DateTime? timestamp = null)
    {
        return new AlertEvent(id, source, category, severity, message, timestamp ?? DateTime.Now);
    }

    [Test]
    public void CreateSeverityEscalationRule_CriticalAlert_ReturnsTrue()
    {
        Predicate<AlertEvent> rule = AlertBroadcastEngine.CreateSeverityEscalationRule(3);
        AlertEvent alert = CreateAlert(severity: AlertSeverity.Critical);
        Assert.That(rule(alert), Is.True);
    }

    [Test]
    public void CreateSeverityEscalationRule_WarningAlert_ReturnsFalse()
    {
        Predicate<AlertEvent> rule = AlertBroadcastEngine.CreateSeverityEscalationRule(3);
        AlertEvent alert = CreateAlert(severity: AlertSeverity.Warning);
        Assert.That(rule(alert), Is.False);
    }

    [Test]
    public void CreateRateLimitRule_AllowsAlertsWithinLimit()
    {
        Func<AlertEvent, bool> rule = AlertBroadcastEngine.CreateRateLimitRule(2);
        DateTime now = DateTime.Now;
        Assert.That(rule(CreateAlert("A1", timestamp: now)), Is.True);
        Assert.That(rule(CreateAlert("A2", timestamp: now.AddSeconds(10))), Is.True);
    }

    [Test]
    public void CreateRateLimitRule_SuppressesAlertWhenLimitReached()
    {
        Func<AlertEvent, bool> rule = AlertBroadcastEngine.CreateRateLimitRule(2);
        DateTime now = DateTime.Now;
        rule(CreateAlert("A1", timestamp: now));
        rule(CreateAlert("A2", timestamp: now.AddSeconds(10)));
        bool result = rule(CreateAlert("A3", timestamp: now.AddSeconds(20)));
        Assert.That(result, Is.False);
    }

    [Test]
    public void CreateRateLimitRule_AllowsAlertAfterOneMinute()
    {
        Func<AlertEvent, bool> rule = AlertBroadcastEngine.CreateRateLimitRule(1);
        DateTime now = DateTime.Now;
        Assert.That(rule(CreateAlert("A1", timestamp: now)), Is.True);
        bool result = rule(CreateAlert("A2", timestamp: now.AddMinutes(1).AddSeconds(1)));
        Assert.That(result, Is.True);
    }

    [Test]
    public void CreateDeduplicationRule_SameAlertWithinWindow_ReturnsFalse()
    {
        Predicate<AlertEvent> rule = AlertBroadcastEngine.CreateDeduplicationRule(TimeSpan.FromSeconds(60));
        DateTime now = DateTime.Now;
        AlertEvent first = CreateAlert("A1", timestamp: now);
        AlertEvent duplicate = CreateAlert("A2", timestamp: now.AddSeconds(30));
        Assert.That(rule(first), Is.True);
        Assert.That(rule(duplicate), Is.False);
    }

    [Test]
    public void CreateDeduplicationRule_SameMessageAfterWindow_ReturnsTrue()
    {
        Predicate<AlertEvent> rule = AlertBroadcastEngine.CreateDeduplicationRule(TimeSpan.FromSeconds(60));
        DateTime now = DateTime.Now;
        AlertEvent first = CreateAlert("A1", timestamp: now);
        AlertEvent later = CreateAlert("A2", timestamp: now.AddSeconds(61));
        Assert.That(rule(first), Is.True);
        Assert.That(rule(later), Is.True);
    }

    [Test]
    public void ValidateAlert_EmptyMessage_ThrowsArgumentException()
    {
        AlertBroadcastEngine engine = CreateEngine();
        AlertEvent alert = CreateAlert(message: "");
        AlertDispatchSession session = new AlertDispatchSession();
        Predicate<AlertEvent> escalationRule = AlertBroadcastEngine.CreateSeverityEscalationRule(3);
        Func<AlertEvent, bool> rateLimitRule = AlertBroadcastEngine.CreateRateLimitRule(5);
        Predicate<AlertEvent> deduplicationRule = AlertBroadcastEngine.CreateDeduplicationRule(TimeSpan.FromSeconds(60));
        Assert.Throws<ArgumentException>(() =>engine.ProcessBatch(new[] { alert },session,escalationRule,rateLimitRule,deduplicationRule));
        session.Dispose();
    }

    [Test]
    public void ProcessBatch_DuplicateAlertId_ThrowsArgumentException()
    {
        AlertBroadcastEngine engine = CreateEngine();
        DateTime now = DateTime.Now;
        AlertEvent alert1 = CreateAlert("A1", timestamp: now);
        AlertEvent alert2 = CreateAlert("A1", timestamp: now.AddSeconds(5));
        AlertDispatchSession session = new AlertDispatchSession();
        Predicate<AlertEvent> escalationRule = AlertBroadcastEngine.CreateSeverityEscalationRule(3);
        Func<AlertEvent, bool> rateLimitRule = AlertBroadcastEngine.CreateRateLimitRule(5);
        Predicate<AlertEvent> deduplicationRule = AlertBroadcastEngine.CreateDeduplicationRule(TimeSpan.FromSeconds(60));
        Assert.Throws<ArgumentException>(() =>engine.ProcessBatch(new[] { alert1, alert2 },session,escalationRule,rateLimitRule,deduplicationRule));
        session.Dispose();
    }

    [Test]
    public void ProcessBatch_CriticalAlert_TriggersOnCallEvent()
    {
        List<string> events = new();
        AlertBroadcastEngine engine = new AlertBroadcastEngine((alert, channel) => { });
        engine.OnCallEscalationTriggered += alert =>events.Add(alert.AlertId);
        AlertEvent alert = CreateAlert(id: "A1",severity: AlertSeverity.Critical);
        AlertDispatchSession session = new AlertDispatchSession();
        engine.ProcessBatch(new[] { alert },session,AlertBroadcastEngine.CreateSeverityEscalationRule(3),AlertBroadcastEngine.CreateRateLimitRule(5),AlertBroadcastEngine.CreateDeduplicationRule(TimeSpan.FromSeconds(60)));
        Assert.That(events, Does.Contain("A1"));
        session.Dispose();
    }

    [Test]
    public void ProcessBatch_NormalAlert_TriggersDashboardEvent()
    {
        List<string> events = new();
        AlertBroadcastEngine engine = new AlertBroadcastEngine((alert, channel) => { });
        engine.DashboardAlertPublished += alert =>events.Add(alert.AlertId);
        AlertEvent alert = CreateAlert(id: "A1",severity: AlertSeverity.Warning);
        AlertDispatchSession session = new AlertDispatchSession();
        engine.ProcessBatch(new[] { alert },session,AlertBroadcastEngine.CreateSeverityEscalationRule(3),AlertBroadcastEngine.CreateRateLimitRule(5),AlertBroadcastEngine.CreateDeduplicationRule(TimeSpan.FromSeconds(60)));
        Assert.That(events, Does.Contain("A1"));
        session.Dispose();
    }

    [Test]
    public void GetNoisiestSource_ReturnsSourceWithMostAlerts()
    {
        AlertBroadcastEngine engine = CreateEngine();
        DateTime now = DateTime.Now;
        List<AlertEvent> alerts = new(){CreateAlert("A1", "Server-1", timestamp: now),CreateAlert("A2", "Server-1", timestamp: now.AddMinutes(1)),CreateAlert("A3", "Server-1", timestamp: now.AddMinutes(2)),CreateAlert("A4", "Server-2", timestamp: now.AddMinutes(3))};
        string result = engine.GetNoisiestSource(alerts);
        Assert.That(result, Is.EqualTo("Server-1"));
    }

    [Test]
    public void GetAlertFrequencyPerHour_CalculatesFrequency()
    {
        AlertBroadcastEngine engine = CreateEngine();
        DateTime now = DateTime.Now;
        List<AlertEvent> alerts = new() { CreateAlert("A1", "Server-1", timestamp: now),CreateAlert("A2", "Server-1", timestamp: now.AddHours(1)),CreateAlert("A3", "Server-1", timestamp: now.AddHours(2))};
        Dictionary<string, double> result =engine.GetAlertFrequencyPerHour(alerts);
        Assert.That(result["Server-1"], Is.EqualTo(1.5));
    }

    [Test]
    public void GetMeanTimeBetweenAlerts_CalculatesAverageTime()
    {
        AlertBroadcastEngine engine = CreateEngine();
        DateTime now = DateTime.Now;
        List<AlertEvent> alerts = new(){CreateAlert("A1", category: "CPU", timestamp: now),CreateAlert("A2", category: "CPU", timestamp: now.AddMinutes(10)),CreateAlert("A3", category: "CPU", timestamp: now.AddMinutes(30))};
        Dictionary<string, double> result =engine.GetMeanTimeBetweenAlerts(alerts);
        Assert.That(result["CPU"], Is.EqualTo(15));
    }

    [Test]
    public void RateLimitTracker_AddAndCountRecent_WorksCorrectly()
    {
        RateLimitTracker tracker = new();
        DateTime now = DateTime.Now;
        tracker.Add(now);
        tracker.Add(now.AddSeconds(10));
        tracker.Add(now.AddSeconds(20));
        int result = tracker.CountRecent(now.AddSeconds(30),TimeSpan.FromMinutes(1));
        Assert.That(result, Is.EqualTo(3));
        tracker.Dispose();
    }

    [Test]
    public void RateLimitTracker_AfterDispose_ThrowsObjectDisposedException()
    {
        RateLimitTracker tracker = new();
        tracker.Dispose();
        Assert.Throws<Exception>(() =>tracker.Add(DateTime.Now));
    }

    [Test]
    public void AlertDispatchSession_Dispose_DecreasesActiveSessions()
    {
        int before = AlertDispatchSession.ActiveSessions;
        AlertDispatchSession session = new AlertDispatchSession();
        Assert.That(AlertDispatchSession.ActiveSessions, Is.EqualTo(before + 1));
        session.Dispose();
        Assert.That(AlertDispatchSession.ActiveSessions, Is.EqualTo(before));
    }

    [Test]
    public void AlertDispatchFailedException_ContainsAlertIdAndChannel()
    {
        AlertDispatchFailedException exception =new AlertDispatchFailedException("A1", "Dashboard");
        Assert.That(exception.AlertID, Is.EqualTo("A1"));
        Assert.That(exception.ChannelName, Is.EqualTo("Dashboard"));
    }

    [Test]
    public void InvalidAlertSeverityException_ContainsInvalidSeverity()
    {
        InvalidAlertSeverityException exception =new InvalidAlertSeverityException(99);
        Assert.That(exception.InvalidSeverity, Is.EqualTo(99));
    }
}

