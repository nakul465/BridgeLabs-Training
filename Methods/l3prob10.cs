using System;
namespace Methods
{
	public class l3prob10
	{
        static void CheckCollinearPoints()
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            bool slopeResult = CheckUsingSlope(x1, y1, x2, y2, x3, y3);
            bool areaResult = CheckUsingArea(x1, y1, x2, y2, x3, y3);
            Console.WriteLine("\nUsing Slope Method:");
            if (slopeResult)
                Console.WriteLine("The three points are collinear.");
            else
                Console.WriteLine("The three points are NOT collinear.");

            Console.WriteLine("\nUsing Area Method:");
            if (areaResult)
                Console.WriteLine("The three points are collinear.");
            else
                Console.WriteLine("The three points are NOT collinear.");
        }

        static bool CheckUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            if ((x2 - x1) == 0 && (x3 - x2) == 0)
                return true;

            if ((x2 - x1) == 0 || (x3 - x2) == 0)
                return false;

            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);

            return (slopeAB == slopeBC) && (slopeBC == slopeAC);
        }

        static bool CheckUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) +
                                 x2 * (y3 - y1) +
                                 x3 * (y1 - y2));
            return area == 0;
        }
    }
}

