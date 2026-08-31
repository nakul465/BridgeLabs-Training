using System;
using System.Reflection;

namespace ReflectionsAndAnnotations
{
	public class TaskInfo : Attribute
	{
		public int priority;
        public string assignedPerson;
		public TaskInfo(int priority,string assignedPerson)
		{
			this.priority = priority;
			this.assignedPerson = assignedPerson;
		}
	}

	public class TaskManager
	{
		[TaskInfo(1,"nakul")]
		public void SampleMethod()
		{
		}

		public void DisplayTaskInfo()
		{
			Type type = typeof(TaskManager);
			var method = type.GetMethod("SampleMethod");
			var attribute=method.GetCustomAttribute<TaskInfo>();
			Console.WriteLine($"Priority : {attribute.priority}\nAssigned Person : {attribute.assignedPerson}");
		}
	}
}

