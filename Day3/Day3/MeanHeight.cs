using System;
namespace Day3
{
	public class MeanHeight
	{
		public static double MeanH()
		{
			double[] arr = new double[11];
			double sum = 0;
			for(int i = 0; i < 11; i++)
			{
				arr[i] = Convert.ToDouble(Console.ReadLine());
				sum += arr[i];
			}
			return sum/11;
		}
	}
}

