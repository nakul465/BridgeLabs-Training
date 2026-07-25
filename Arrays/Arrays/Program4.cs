using System;
namespace Day3
{
	public class Program4
	{
		public static void Progra4()
		{
			int[] arr = new int[10];
			for(int i = 0; i < 10; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
				if (arr[i] <= 0) break;
			}
			int sum = 0;
			foreach(int i in arr)
			{
				if (i <= 0) break;
				Console.WriteLine(i);
				sum += i;
			}
			Console.WriteLine(sum);
		}
	}
}

