using System;
namespace Methods
{
	public class l2prob10
	{
		public static void l2pob10()
		{
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] hwb = new double[n, 3];
            string[] weightStat = new string[n];
            for (int i = 0; i < n; i++)
            {
                hwb[i, 0] = Convert.ToDouble(Console.ReadLine());
                hwb[i, 1] = Convert.ToDouble(Console.ReadLine());
                hwb[i, 2] = hwb[i, 0] / (hwb[i, 1] * hwb[i, 1]);
                if (hwb[i, 2] >= 40.0) weightStat[i] = "Obese";
                else if (hwb[i, 2] >= 25) weightStat[i] = "Overweight";
                else if (hwb[i, 2] >= 18.5) weightStat[i] = "Normal";
                else weightStat[i] = "UnderWeight";
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Height: {hwb[i, 0]}, Weight: {hwb[i, 1]} bmi: {hwb[i, 2]}, weight status: {weightStat[i]}");
            }
        }
	}
}

