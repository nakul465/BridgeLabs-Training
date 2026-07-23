using System;
namespace Day2
{
	public class FactorsOfNum
	{
		public static void Factors(int num)
		{
			for(int i = 2; i < num; i++)
			{
				if (num % i == 0) Console.WriteLine(i);
			}
		}
	}
}

