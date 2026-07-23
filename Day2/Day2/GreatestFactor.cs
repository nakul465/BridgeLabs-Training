using System;
namespace Day2
{
	public class GreatestFactor
	{
		public static int GreatestFacto(int num)
		{
			int ans = 1;
			for(int i = num - 1; i > 1; i--)
			{
				if (num % i == 0) return i;
				
			}
			return ans;
		}
	}
}

