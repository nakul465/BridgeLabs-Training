using System;
namespace Methods
{
	public class l2prob11
	{
        public static double[] FindRoots()
        {

            double a = Convert.ToDouble(Console.ReadLine());

            double b = Convert.ToDouble(Console.ReadLine());

            double c = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0)
            {
                double[] roots = new double[2];

                roots[0] = (-b + Math.Sqrt(delta)) / (2 * a);
                roots[1] = (-b - Math.Sqrt(delta)) / (2 * a);

                return roots;
            }
            else if (delta == 0)
            {
                double[] roots = new double[1];

                roots[0] = -b / (2 * a);

                return roots;
            }

            return new double[0];
        }
    }
}

