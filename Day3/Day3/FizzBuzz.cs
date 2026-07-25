using System;
namespace Day3
{
	public class FizzBuzz
	{
		public static void FizzBuz(int num)
		{
			if (num <= 0)
			{
				Console.WriteLine("invalid Input");
				return;
			}
			string[] arr = new string[num+1];
			arr[0] = "" + 0;
			for(int i = 1; i <= num; i++)
			{
				if (i % 3 == 0 && i % 5 == 0) arr[i] = "FizzBuzz";
				else if (i % 3 == 0) arr[i] = "Fizz";
				else if (i % 5 == 0) arr[i] = "buzz";
				else arr[i] = ""+i;
			}
			foreach(string s in arr)
			{
				Console.WriteLine(s);
			}
		}
	}
}

