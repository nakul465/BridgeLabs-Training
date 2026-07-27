using System;
namespace Methods
{
	public class l2prob1
	{
		public static void l2pob1()
		{
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }


            int[] factors = new int[count];

            int index = 0;
            int sum = 0;
            long product = 1;
            double sumOfSquares = 0;


            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factors[index++] = i;

                    sum += i;
                    product *= i;
                    sumOfSquares += Math.Pow(i, 2);
                }
            }

            Console.WriteLine("Factors are:");

            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Product = " + product);
            Console.WriteLine("Sum of Squares = " + sumOfSquares);
        }
	}
}

