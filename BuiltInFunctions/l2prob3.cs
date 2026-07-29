using System;
namespace BuiltInFunctions
{
	public class l2prob3
	{
		public static bool isPrim(int num)
		{
			if (num <= 3) return true;
			for(int i = 2; i < Math.Sqrt(num); i++)
			{
				if (num % i == 0) return false;
			}
			return true;
		}
	}
}

