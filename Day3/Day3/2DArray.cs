using System;
namespace Day3
{
	public class _DArray
	{
		public static void ar(int row,int col)
		{
			int[,] arr = new int[row, col];
			int[] ans = new int[row * col];
			for(int i = 0; i < row; i++)
			{
				for(int j = 0; j < col; j++)
				{
					arr[i,j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			int index = 0;
			for(int i = 0; i < row; i++)
			{
				for(int j = 0; j < col; j++)
				{
					ans[index++] = arr[i, j];
				}
			}
			foreach(int i in ans)
			{
				Console.Write(i + " ");
			}
		}
	}
}

