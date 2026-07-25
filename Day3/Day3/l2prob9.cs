using System;
namespace Arrays
{
	public class l2prob9
	{
		public static void l2pob9()
		{
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] marks = new int[n, 3];
            double[] per = new double[n];
            char[] grade = new char[n];
            for (int i = 0; i < n; i++)
            {
                marks[i,0] = Convert.ToInt32(Console.ReadLine());
                marks[i, 1] = Convert.ToInt32(Console.ReadLine());
                marks[i, 2] = Convert.ToInt32(Console.ReadLine());
                per[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;
                if (per[i] >= 80) grade[i] = 'A';
                else if (per[i] >= 70) grade[i] = 'B';
                else if (per[i] >= 60) grade[i] = 'C';
                else if (per[i] >= 50) grade[i] = 'D';
                else if (per[i] >= 40) grade[i] = 'E';
                else grade[i] = 'R';
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"physics: {marks[i, 0]} Maths: {marks[i, 1]} Chem: {marks[i, 2]} per: {per[i]} grade: {grade[i]}");
            }
        }
	}
}

