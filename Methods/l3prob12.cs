using System;
namespace Methods
{
	public class l3prob12
	{
        static void StudentResult()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] marks = GenerateMarks(n);
            double[,] result = CalculateResult(marks, n);
            DisplayScoreCard(marks, result, n);
        }

        static int[,] GenerateMarks(int n)
        {
            Random random = new Random();
            int[,] marks = new int[n, 3];
            for (int i = 0; i < n; i++)
            {
                marks[i, 0] = random.Next(10, 100); 
                marks[i, 1] = random.Next(10, 100); 
                marks[i, 2] = random.Next(10, 100); 
            }
            return marks;
        }

        static double[,] CalculateResult(int[,] marks, int n)
        {
            double[,] result = new double[n, 3];
            for (int i = 0; i < n; i++)
            {
                int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
                double average = Math.Round(total / 3.0, 2);
                double percentage = Math.Round((total / 300.0) * 100, 2);
                result[i, 0] = total;
                result[i, 1] = average;
                result[i, 2] = percentage;
            }

            return result;
        }

        static void DisplayScoreCard(int[,] marks, double[,] result, int n)
        {
            Console.WriteLine("Stu\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}\t{marks[i, 0]}\t{marks[i, 1]}\t\t{marks[i, 2]}\t{result[i, 0]}\t{result[i, 1]}\t{result[i, 2]}%");
            }
        }
    }
}

