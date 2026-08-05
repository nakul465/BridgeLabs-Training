using System;
using System.Xml.Linq;

namespace EncapsulatioAndPolymorphism
{
	public interface IDepartment
	{
		public void AssignDepartment(string department);
		public void GetDepartmentDetails();
    }
	public abstract class Employee
    {
        private int employeeId;
        private string name;
        private double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public Employee(double baseSalary, string name, int employeeId)
		{
			this.employeeId = employeeId;
			this.name = name;
			this.baseSalary = baseSalary;
		}

		public abstract void CalculateSalary();
		public void DisplayDetails()
		{
			Console.WriteLine($"the Emplyee's name with id : {employeeId} is {name} and has a base salary of {baseSalary}");
		}
    }


	public class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public double WorkHours { get; set; }
        public double HourlyRate { get; set; }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public FullTimeEmployee(double baseSalary, string name, int employeeId,double WorkHours,double HourlyRate) : base(baseSalary, name, employeeId)
		{
            this.HourlyRate = HourlyRate;
            this.WorkHours = WorkHours;

        }

        public void AssignDepartment(string department)
        {
            this.Department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine($"Department : {department}");
        }

        public override void CalculateSalary()
		{
            Console.WriteLine("Total salary :"+(BaseSalary+(WorkHours * HourlyRate)));
		}

    }


    public class PartTimeEmployee : Employee, IDepartment
    {
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public double WorkHours { get; set; }
        public double HourlyRate { get; set; }

        public PartTimeEmployee(double baseSalary, string name, int employeeId, double WorkHours, double HourlyRate) : base(baseSalary, name, employeeId)
        {
            this.HourlyRate = HourlyRate;
            this.WorkHours = WorkHours;
        }

        public void AssignDepartment(string department)
        {
            this.Department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine($"Department : {department}");
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("Total salary :" + (WorkHours*HourlyRate));
        }

    }
}

