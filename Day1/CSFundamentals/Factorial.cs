using System;
namespace CSFundamentals
{
	public class Factorial
	{
		public static int Fac(int num)
		{
			if (num <= 1) return 1;
			return Fac(num - 1) * num;
		}
	}
}

