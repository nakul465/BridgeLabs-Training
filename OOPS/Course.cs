using System;
namespace OOPS
{
	public class Course
	{
		string courseName;
		int fee;
		int duration;
		static string instituteName = "Chitkara";
		public Course()
		{
			this.courseName = "MERN";
			this.duration = 30;
			this.fee = 500;
		}
        public Course(string courseName,int duration,int fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
		public void displayDetails()
		{
			Console.WriteLine("Course Name      : " + this.courseName);
            Console.WriteLine("Course Duration  : " + this.duration);
            Console.WriteLine("Course Fee       : " + this.fee);
            Console.WriteLine("Course Institute : " + instituteName);
        }
		public void updateIntititueName(string institute)
		{
			instituteName = institute;
		}

    }
}

