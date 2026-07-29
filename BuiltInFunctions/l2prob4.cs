using System;
namespace BuiltInFunctions
{
	public class l2prob4
	{
		public static int[] fibGen()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			if (n <= 0) return arr;
			arr[0]= 0;
			if (n == 1) return arr;
			arr[1] = 1;
			for(int i = 2; i < n; i++)
			{
				arr[i] = arr[i - 1] + arr[i - 2];
			}
			return arr;
		}
		public static void print(int[] arr)
		{
			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}

