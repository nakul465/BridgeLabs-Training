using System;
namespace OOPS2
{
	public class Employee
	{
		public static string companyName = "EasyRewardz";
		public static int totalEmployees = 0;
		string name;
		readonly int id;
		string designation;
		public Employee()
		{
			this.name = "Ram";
			this.id= 0;
			this.designation = "Intern";
			totalEmployees++;
		}
        public Employee(string name,string designation,int id)
        {
            this.name = name;
            this.id = id;
            this.designation = designation;
            totalEmployees++;
        }
		public void diplayDetails(Employee e1)
		{
            if (e1 is Employee)
            {
                Console.WriteLine("Name         : " + name);
                Console.WriteLine("ID           : " + id);
                Console.WriteLine("Designation  : " + designation);
            }
            else
            {
                Console.WriteLine("the object provided is not a Employee");
            }
        }
    }
}

