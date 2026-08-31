using System;
using System.Reflection;

namespace ReflectionsAndAnnotations
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple =true)]
	public class BugReport : Attribute
	{
		public string discription;
		public BugReport(string discription)
		{
			this.discription = discription;
		}
	}

	public class Website
	{
		[BugReport("Critical bug : crashes")]
        [BugReport("minor bug : slow response")]
        public void Feature1()
		{
		}

		public void DisplayBugReport()
		{
			Type type = typeof(Website);
			var method = type.GetMethod("Feature1");
			var attributes = method.GetCustomAttributes<BugReport>();
			foreach(var attribute in attributes)
			{
				Console.WriteLine($"Bug Description : {attribute.discription}");
			}
		}
	}
}

