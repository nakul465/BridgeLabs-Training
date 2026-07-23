using System;
namespace Day2
{
	public class SumOfDigitsOfANumber
	{
		public static int SumOfDigits(int num)
		{
			int sum = 0;
			int copy = num;
			while (copy != 0)
			{
				sum += copy % 10;
				copy /= 10;
			}
			return sum;
		}
	}
}

