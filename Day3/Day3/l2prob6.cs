using System;
using System.Net.NetworkInformation;

namespace Arrays
{
	public class l2prob6
	{
		public static void l2pob6()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			double[] weight = new double[n];
            double[] height = new double[n];
            double[] bmi = new double[n];
			string[] weightStat = new string[n];
			for(int i = 0; i < n; i++)
			{
				weight[i] = Convert.ToDouble(Console.ReadLine());
                height[i] = Convert.ToDouble(Console.ReadLine());
				bmi[i] = weight[i] / (height[i] * height[i]);
                if (bmi[i] >= 40.0) weightStat[i] = "Obese";
                else if (bmi[i] >= 25) weightStat[i] = "Overweight";
                else if (bmi[i] >= 18.5) weightStat[i] = "Normal";
                else weightStat[i] = "UnderWeight";
            }
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine($"Height: {height[i]}, Weight: {weight[i]} bmi: {bmi[i]}, weight status: {weightStat[i]}");
			}
        }
	}
}

