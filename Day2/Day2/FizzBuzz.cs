using System;
namespace Day2
{
	public class FizzBuzz
	{
		public static void FizzBuz(int num)
		{
			if (num < 0) Console.WriteLine("invlaid input");
			for(int i = 0; i <= num; i++)
			{
				if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
				else if (i % 3 == 0) Console.WriteLine("Fizz");
				else if (i % 5 == 0) Console.WriteLine("Buzz");
				else Console.WriteLine(i);
            }
			

        }
	}
}

