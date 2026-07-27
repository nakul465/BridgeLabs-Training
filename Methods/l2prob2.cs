using System;
namespace Methods
{
	public class l2prob2
	{
		public static void l2pob2()
		{
            int n = Convert.ToInt32(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine("Please enter a natural number.");
                return;
            }
            int recursiveSum = SumUsingRecursion(n);
            int formulaSum = SumUsingFormula(n);
            Console.WriteLine($"Sum using Recursion = {recursiveSum}");
            Console.WriteLine($"Sum using Formula = {formulaSum}");
            if (recursiveSum == formulaSum)
            {
                Console.WriteLine("Both results are correct and equal.");
            }
            else
            {
                Console.WriteLine("Results are not equal.");
            }
        }

        static int SumUsingRecursion(int n)
        {
            if (n == 1)
                return 1;

            return n + SumUsingRecursion(n - 1);
        }

        static int SumUsingFormula(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}

