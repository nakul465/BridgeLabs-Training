using System;
namespace SearchingTechniques
{
	public class LinearSearch1
	{
		public static int FirstNegative(int[] arr)
		{
			foreach (int n in arr)
			{
				if (n < 0) return n;
			}
			return 0;
		}
	}
}

