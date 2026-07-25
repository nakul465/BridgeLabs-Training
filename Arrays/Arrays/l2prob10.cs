using System;
namespace Arrays
{
	public class l2prob10
	{
		public static void l2pob10()
		{
			int num = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[10];
			while (num > 0)
			{
				int n = num % 10;
				arr[n]++;
				num = num / 10;
			}
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine($"{i}:{arr[i]}");
			}
		}
	}
}

