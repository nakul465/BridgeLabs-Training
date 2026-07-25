using System;
using System.Runtime.Intrinsics.X86;

namespace Arrays
{
	public class l2prob8
	{
		public static void l2pob8()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] phy = new int[n];
			int[] chem = new int[n];
			int[] maths = new int[n];
			double[] per = new double[n];
			char[] grade = new char[n];
			for(int i = 0; i < n; i++)
			{
				phy[i]= Convert.ToInt32(Console.ReadLine());
                chem[i] = Convert.ToInt32(Console.ReadLine());
                maths[i] = Convert.ToInt32(Console.ReadLine());
				per[i] = (phy[i] + maths[i] + chem[i])/ 3.0;
                if (per[i] >= 80) grade[i] = 'A';
                else if (per[i] >= 70) grade[i] = 'B';
                else if (per[i] >= 60) grade[i] = 'C';
                else if (per[i] >= 50) grade[i] = 'D';
                else if (per[i] >= 40) grade[i] = 'E';
                else grade[i] = 'R';
            }
			for(int i = 0; i < n; i++)
			{
				Console.WriteLine($"physics: {phy[i]} Maths: {maths[i]} Chem: {chem[i]} per: {per[i]} grade: {grade[i]}");
			}
		}
	}
}

