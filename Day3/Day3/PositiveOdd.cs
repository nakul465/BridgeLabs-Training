using System;
namespace Day3
{
	public class PositiveOdd
	{
		public static void PositiveOd(int num)
		{
			int[] arr = new int[num];
			for(int i = 0; i < num; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			foreach(int i in arr)
			{
				if (i > 0)
				{
					if (i % 2 == 0) Console.WriteLine(i + " is Positive Even");
					else Console.WriteLine(i + " is Positive Odd");
				}
				else if (i < 0) Console.WriteLine(i + " is Negative");
				else Console.WriteLine(i + " is 0");
			}
		}
	}
}

