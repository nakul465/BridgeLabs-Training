using System;
using System.Diagnostics;

namespace Inheritance
{
	public class Person
	{
        public string Name;
        public int Age;

        public Person(string Name, int Age)
		{
            this.Name = Name;
            this.Age = Age;
		}

        public virtual void DisplayRole()
        {
            Console.WriteLine($"{Name} is of age {Age}");
        }

    }

    public class Teacher: Person
    {
        string Subject;

        public Teacher(string Name, int Age,string Subject) :base(Name,Age)
        {
            this.Subject = Subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"{Name} of age {Age} is a Teacher of subject {Subject}");
        }
    }
    public class Student : Person
    {
        string Grade;

        public Student(string Name, int Age, string Grade) : base(Name, Age)
        {
            this.Grade = Grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"{Name} of age {Age} is a Student and Obtained grade : {Grade}");
        }
    }
    public class Staff : Person
    {
        string duty;

        public Staff(string Name, int Age, string duty) : base(Name, Age)
        {
            this.duty = duty;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"{Name} of age {Age} is a member of staff with duty {duty}");
        }
    }
}

