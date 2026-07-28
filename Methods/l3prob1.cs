using System;
namespace Methods
{
	public class l3prob1
	{
		public static void l3pob1()
		{
			int[] heights = new int[11];
			Random random = new Random();
			int shortest = 350;
			int tallest = -1;
			int sum = 0;
			for(int i = 0; i < 11; i++)
			{
				heights[i] =random.Next(150,251);
				if (heights[i] > tallest) tallest = heights[i];
				if (heights[i] < shortest) shortest = heights[i];
				sum += heights[i];
			}
			double meanHeight = sum / 11.0;
			Console.WriteLine($"The mean Height of the Team is {meanHeight}, the tallest player is {tallest},the shortest player is {shortest} and the sum of all the heights is {sum}");
		}
	}
}

