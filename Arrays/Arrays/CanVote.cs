using System;
namespace Day3
{
	public class CanVote
	{
		public static void CanVot(int size)
		{
			int[] arr = new int[size];
			for(int i = 0; i < size; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			foreach(int i in arr)
			{
				if (i >= 18)
				{
					Console.WriteLine("can vote");
				}
				else
				{
                    Console.WriteLine("can't vote");
                }
			}
		}
	}
}

