using System;
namespace Arrays
{
	public class l2prob3
	{
		public static void l2pob3()
		{
			int num = Convert.ToInt32(Console.ReadLine());
			int maxDigit = 10;
			int[] arr = new int[maxDigit];
			int copy = num;
			int i = 0;
			int max = 0;
			while (copy > 0)
			{
				if (i == arr.Length)
				{
					maxDigit *= 2;
                    Array.Resize(ref arr,maxDigit);
                } 
				arr[i] = copy % 10;
				copy /= 10;
				if (arr[i] > max) max = arr[i];
			}
			Console.WriteLine($"The max digit in the number {num} is {max}");
		}
	}
}

