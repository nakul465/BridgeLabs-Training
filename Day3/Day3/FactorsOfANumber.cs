using System;
namespace Day3
{
	public class FactorsOfANumber
	{
		public static void FactorsOfANum(int num)
		{
			int maxFactor = 10;
			int[] arr = new int[maxFactor];
			int index = 0;
			for(int i = 1; i <= num; i++)
			{
				if (index == maxFactor)
				{
					maxFactor *= 2;
					Array.Resize(ref arr, maxFactor);
				}
				if (num % i == 0) arr[index++] = i;
			}
			foreach(int i in arr)
			{
				if (i == 0) break;
				Console.Write(i + " ");
			}
		}
	}
}

