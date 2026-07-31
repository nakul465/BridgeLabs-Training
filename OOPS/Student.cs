using System;
using OOPS;

namespace OOPS
{
	public class Student
	{
		public int rollNumber;
		protected string name;
		private double CGPA;
		public double cGPA {
			set
			{
				if (value < 0)
				{
					Console.WriteLine("Inavlid value for CGPA");
					return;
				}
				CGPA = value;
			}
			get
			{
				return CGPA;
			}
		}
		public Student(int rollNumber,string name,double CGPA)
		{
			this.rollNumber = rollNumber;
			this.name = name;
			this.CGPA = CGPA;
		}
		public Student()
		{
			this.rollNumber = 0;
			this.name = "Ram";
			this.CGPA = 10.0;
		}
	}
}
public class PostGraduateStudent : Student
{
    public PostGraduateStudent(int rollNumber, string name, double CGPA): base(rollNumber, name, CGPA)
    {
		
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Roll Number : " + rollNumber);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("CGPA        : " + cGPA);
    }
}

