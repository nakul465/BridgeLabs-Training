using System;
using System.Diagnostics;

namespace OOPS2
{
	public class Student
	{
        public static string UniversityName = "Chitkara University";
        private static int totalStudents = 0;
        public readonly int RollNumber;
        public string Name;
        public char Grade;

        public Student(int RollNumber, string Name, char Grade)
        {
            this.RollNumber = RollNumber;
            this.Name = Name;
            this.Grade = Grade;

            totalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students: " + totalStudents);
        }

        public void UpdateGrade(char Grade)
        {
            this.Grade = Grade;
        }

        public void diplayDetails(Student s1)
        {
            if (s1 is Student)
            {
                Console.WriteLine("University : " + UniversityName);
                Console.WriteLine("Roll Number: " + RollNumber);
                Console.WriteLine("Name       : " + Name);
                Console.WriteLine("Grade      : " + Grade);
            }
            else
            {
                Console.WriteLine("the object provided is not a Student");
            }
        }
    }
}

