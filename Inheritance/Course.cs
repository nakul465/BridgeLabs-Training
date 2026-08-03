using System;
using System.Runtime.InteropServices;

namespace Inheritance
{
	public class Course
	{
		public string CourseName;
        public int Duration;
        public Course(string CourseName, int Duration)
		{
			this.CourseName = CourseName;
			this.Duration = Duration;
		}
		public virtual void DisplayDetails()
		{
			Console.WriteLine($"The duration of the course {CourseName} is {Duration}");
		}
	}
	public class OnlineCourse : Course
	{
		public string Platform;
        public bool IsRecorded;
		public OnlineCourse(string CourseName, int Duration, string Platform, bool IsRecorded) :base(CourseName, Duration)
		{
			this.Platform = Platform;
			this.IsRecorded = IsRecorded;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"The duration of the course {CourseName} is {Duration} and this is online course on platfrom {Platform}\nIs the course recorded {IsRecorded}");
        }

    }
	class PaidOnlineCourse : OnlineCourse
	{
		double Fee;
		double Discount;
		public PaidOnlineCourse(string CourseName, int Duration, string Platform, bool IsRecorded, double Fee, double Discount) :base(CourseName, Duration,Platform,IsRecorded)
		{
			this.Fee = Fee;
			this.Discount = Discount;
		}
        public override void DisplayDetails()
        {
            Console.WriteLine($"The duration of the course {CourseName} is {Duration} and this is online course on platfrom {Platform}\nIs the course recorded {IsRecorded} \nthe fee of the course is {Fee} and the dixcount is {Discount} so the final fee is {Fee-Discount}");
        }

    }

}

