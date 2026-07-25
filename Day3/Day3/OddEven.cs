using System;
namespace Day3
{
	public class OddEven
	{
		public static void OddEve(int num)
		{
			if (num <= 0)
			{
                Console.WriteLine("invalid input");
				return;
            }
			int[] odd = new int[num / 2 + 1];
            int[] even = new int[num / 2 + 1];
			for(int i = 1,j=1,k=1 ; k <= num;k++)
			{
				if (k % 2 == 0) even[i++] = k;
				else odd[j++] = k;
			}
			foreach(int i in odd)
			{
				if (i == 0) continue;
				Console.Write(i + " ");
			}
			Console.WriteLine();
            foreach (int i in even)
            {
                if (i == 0) continue;
                Console.Write(i + " ");
            }
        }
	}
}

