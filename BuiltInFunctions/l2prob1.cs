using System;
namespace BuiltInFunctions
{
	public class l2prob1
	{
		public static void guess()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int start = 1, end = 101;
			Random random = new Random();
			while (true)
			{
				int a = random.Next(start, end);
				if (a == n)
				{
					Console.WriteLine("Number guessed");
					break;
				}
				if (a < n)
				{
                    Console.WriteLine("actual Number is graeter than number guessed");
                    start = a + 1;
				}
				else if (a > n)
				{
                    Console.WriteLine("actual Number is smaller than number guessed");
                    end = a;
				}
			}
		}
	}
}

