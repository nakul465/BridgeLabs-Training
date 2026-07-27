using System;
namespace Methods
{
	public class l2prob8
	{
		public static void l2pob8()
		{
            int age1 = Convert.ToInt32(Console.ReadLine());
            int age2 = Convert.ToInt32(Console.ReadLine());
            int age3 = Convert.ToInt32(Console.ReadLine());
            double height1 = Convert.ToDouble(Console.ReadLine());
            double height2 = Convert.ToDouble(Console.ReadLine());
            double height3 = Convert.ToDouble(Console.ReadLine());
            if (age1 <= age2 && age1 <= age3)
            {
                Console.WriteLine("Amar is youngest");
            }
            else if (age2 <= age1 && age2 <= age3)
            {
                Console.WriteLine("Akbar is youngest");
            }
            else
            {
                Console.WriteLine("Anthony is youngest");
            }
            if (height1 >= height2 && height1 >= height3)
            {
                Console.WriteLine("Amar is tallest");
            }
            else if (height2 >= height1 && height2 >= height3)
            {
                Console.WriteLine("Akbar is tallest");
            }
            else
            {
                Console.WriteLine("Anthony is tallest");
            }
        }
	}
}

