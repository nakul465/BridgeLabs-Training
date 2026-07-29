using System;
namespace BuiltInFunctions
{
	public class l2prob2
	{
		public static int maxOfThree()
		{
			int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
			return Math.Max(Math.Max(num1, num2), num3);
        }
	}
}

