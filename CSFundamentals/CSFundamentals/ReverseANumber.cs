using System;
namespace CSFundamentals
{
	public class ReverseANumber
	{
		public static int revANum(int num)
		{
			int reversedNum = 0;
			int copy = num;
			while (copy != 0)
			{
				int lastDigit = copy % 10;
				reversedNum = reversedNum * 10 + lastDigit;
				copy = copy / 10;
			}
			return reversedNum;
		}
	}
}

