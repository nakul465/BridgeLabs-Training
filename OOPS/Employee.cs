using System;
namespace OOPS
{
	public class Employee
	{
        public int employeeID;
        protected string department;
        private double salary;

        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Invalid salary!");
                }
            }
        }
    }
    public class Manager : Employee
    {
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary)
        {
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID : " + employeeID);
            Console.WriteLine("Department  : " + department);
            Console.WriteLine("Salary      : " + Salary);
        }
    }
}

