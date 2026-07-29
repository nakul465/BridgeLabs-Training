using System;
namespace BuiltInFunctions
{
	public class l2prob6
	{
		public static void l2pob6()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"the fact of the num {n} is {fact(n)}");
		}
		public static int fact(int num)
		{
			if (num <= 1) return 1;
			return num * fact(num - 1);
		}
	}
}

