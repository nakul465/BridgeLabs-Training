using System;
namespace Arrays
{
	public class l2prob5
	{
		public static void l2pob5()
		{
            int num = Convert.ToInt32(Console.ReadLine());
            int maxDigit = 10;
            int[] arr = new int[maxDigit];
            int copy = num;
            int i = -1;
            while (copy > 0)
            {
                i++;
                if (i == arr.Length)
                {
                    maxDigit *= 2;
                    Array.Resize(ref arr, maxDigit);
                }
                arr[i] = copy % 10;
                copy /= 10;
            }
            for(int j = 0; j <= i; j++)
            {
                Console.Write(arr[j] + " ");
            }

        }
	}
}

