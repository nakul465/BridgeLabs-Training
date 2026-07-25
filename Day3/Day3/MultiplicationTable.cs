using System;
namespace Day3
{
	public class MultiplicationTable
	{
		public static void MultiplicationTabl(int num)
		{
			String[] arr = new String[10];
			for(int i = 1; i <= 10; i++)
			{
				arr[i-1] = num+" X "+i+" = "+(num*i);
			}
			foreach(String i in arr)
			{
				Console.WriteLine(i);
			}
		}
	}
}

