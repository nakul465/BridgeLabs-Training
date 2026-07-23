using System;
namespace Day2
{
	public class power
	{
		public static int pow(int num,int power)
		{
			int ans = 1;
			for(int i = 0; i <power; i++)
			{
				ans = ans * num;
			}
			return ans;
		}
	}
}

