using System;
namespace CSFundamentals
{
	public class Palindrome
	{
		public static bool Plm(int num)
		{
			int reversedNum = 0;
			int c = num;
			while (c != 0)
			{
				int lastDigit = c % 10;
				reversedNum = reversedNum*10 + lastDigit;
				c = c / 10;
			}
			return num == reversedNum ? true : false;
		}
	}
}

