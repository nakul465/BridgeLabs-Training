using System;
namespace Methods
{
	public class l3prob9
	{
        static void CalculateDistanceAndLine()
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = FindDistance(x1, y1, x2, y2);
            Console.WriteLine($"\nEuclidean Distance = {distance:F2}");

            FindLineEquation(x1, y1, x2, y2);
        }

        static double FindDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(
                Math.Pow(x2 - x1, 2) +
                Math.Pow(y2 - y1, 2)
            );
        }

        static void FindLineEquation(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                Console.WriteLine("The line is vertical (x = constant). Slope is undefined.");
                return;
            }

            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - (m * x1);

            Console.WriteLine($"Slope (m) = {m:F2}");
            Console.WriteLine($"Y-Intercept (b) = {b:F2}");
            Console.WriteLine($"Equation of Line: y = {m:F2}x + {b:F2}");
        }
    }
}

