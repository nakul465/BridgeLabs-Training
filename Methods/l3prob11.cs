using System;
namespace Methods
{
	public class l3prob11
	{
        static void EmployeeBonusDetails()
        {
            int[,] employeeData = GenerateEmployeeData();
            double[,] bonusData = CalculateBonus(employeeData);
            DisplayData(employeeData, bonusData);
        }

        static int[,] GenerateEmployeeData()
        {
            Random random = new Random();
            int[,] data = new int[10, 2];
            for (int i = 0; i < 10; i++)
            {
                data[i, 0] = random.Next(10000, 100000); 
                data[i, 1] = random.Next(1, 11);         
            }
            return data;
        }

        static double[,] CalculateBonus(int[,] data)
        {
            double[,] result = new double[10, 2];

            for (int i = 0; i < 10; i++)
            {
                double salary = data[i, 0];
                int years = data[i, 1];
                double bonus;
                if (years > 5)
                    bonus = salary * 0.05;
                else
                    bonus = salary * 0.02;
                double newSalary = salary + bonus;
                result[i, 0] = bonus;
                result[i, 1] = newSalary;
            }
            return result;
        }

        static void DisplayData(int[,] data, double[,] result)
        {
            double totalOldSalary = 0;
            double totalBonus = 0;
            double totalNewSalary = 0;
            Console.WriteLine("Emp\tOld Salary\tYears\tBonus\t\tNew Salary");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}\t{data[i, 0]}\t\t{data[i, 1]}\t{result[i, 0]:F2}\t\t{result[i, 1]:F2}");

                totalOldSalary += data[i, 0];
                totalBonus += result[i, 0];
                totalNewSalary += result[i, 1];
            }
            Console.WriteLine($"Total Old Salary : {totalOldSalary:F2}");
            Console.WriteLine($"Total Bonus      : {totalBonus:F2}");
            Console.WriteLine($"Total New Salary : {totalNewSalary:F2}");
        }
    }
}

