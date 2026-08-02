using System;
namespace ObjectModelling
{
    class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
    }
    class Department
    {
        public string Name { get; set; }

        private List<Employee> employees;

        public Department(string name)
        {
            Name = name;
            employees = new List<Employee>();
        }

        public void AddEmployee(string employeeName)
        {
            Employee employee = new Employee(employeeName);
            employees.Add(employee);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine($"Department: {Name}");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"  Employee: {employee.Name}");
            }
        }
    }
    public class Company
	{
        private List<Department> departments;

        public string Name { get; set; }

        public Company(string name)
        {
            Name = name;
            departments = new List<Department>();
        }

        public void AddDepartment(string departmentName)
        {
            Department department = new Department(departmentName);
            departments.Add(department);
        }

        public void AddEmployee(string departmentName, string employeeName)
        {
            foreach (Department department in departments)
            {
                if (department.Name == departmentName)
                {
                    department.AddEmployee(employeeName);
                    return;
                }
            }
        }

        public void DisplayCompany()
        {
            Console.WriteLine($"Company: {Name}");

            foreach (Department department in departments)
            {
                department.DisplayEmployees();
            }
        }
    }
}

