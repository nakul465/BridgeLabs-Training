using System;
using System.Xml.Linq;

namespace Inheritance
{
	public class Employee
	{
		public string name;
        public int id;
        public double salary;
		public Employee(string name,int id,double salary)
		{
			this.name = name;
			this.id = id;
			this.salary = salary;
		}
		public virtual void DisplayDetails()
		{
			Console.WriteLine($"\nName : {name}\nid : {id}\nsalary : {salary}");
		}
	}
	class Manager:Employee
	{
		int TeamSize;
		public Manager(string name, int id, double salary,int TeamSize) :base(name,id,salary)
		{
			this.TeamSize = TeamSize;
		}
        public override void DisplayDetails()
        {
            Console.WriteLine($"\nName : {name}\nid : {id}\nsalary : {salary}\nTeamSize:{TeamSize}");
        }
    }
	class Developer:Employee
	{
		string ProgrammingLanguage;
        public Developer(string name, int id, double salary, string ProgrammingLanguage) : base(name, id, salary)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"\nName : {name}\nid : {id}\nsalary : {salary}\nProgrammingLanguage : {ProgrammingLanguage}");
        }
    }
	class Intern:Employee
	{
		string InternshipDuration;
        public Intern(string name, int id, double salary, string InternshipDuration) : base(name, id, salary)
        {
            this.InternshipDuration = InternshipDuration;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"\nName : {name}\nid : {id}\nsalary : {salary}\nInternshipDuration : {InternshipDuration}");
        }
    }
}

