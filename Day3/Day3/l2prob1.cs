using System;
namespace Arrays
{
	public class l2prob1
	{
		public static void l2pob1()
		{
			double[] oldSalary = new double[10];
            int[] yearsOfSer = new int[10];
            double[] bonus = new double[10];
            double[] newSalary = new double[10];
			double totalBonus = 0;
			double totalOldSalary = 0;
			double totalNewSalary = 0;
            for (int i = 0; i < 10; i++)
			{
				oldSalary[i] = Convert.ToDouble(Console.ReadLine());
                yearsOfSer[i] = Convert.ToInt32(Console.ReadLine());
				if (yearsOfSer[i] < 0)
				{
					Console.WriteLine("Inavlid input for years of service please enter again");
                    yearsOfSer[i] = Convert.ToInt32(Console.ReadLine());
                }
				if (yearsOfSer[i] >= 5)
				{
					bonus[i] = oldSalary[i] * 0.05;
					newSalary[i] = oldSalary[i] + bonus[i];
				}
				else
				{
                    bonus[i] = oldSalary[i] * 0.02;
                    newSalary[i] = oldSalary[i] + bonus[i];
                }
                totalBonus += bonus[i];
                totalOldSalary += oldSalary[i];
				totalNewSalary += newSalary[i];
            }
			Console.WriteLine($"the total old salary was {totalOldSalary} and the total bonus is {totalBonus} and the new total salary is {totalNewSalary}");
        }
	}
}

