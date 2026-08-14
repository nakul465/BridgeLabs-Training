using System;
namespace SortingPractice
{
	public class CountingSort1
	{
        static void CountingSort(int[] ages)
        {
            int min = 10;
            int max = 18;

            int range = max - min + 1;
            int[] count = new int[range];
            foreach (int age in ages)
            {
                count[age - min]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            int[] output = new int[ages.Length];
            for (int i = ages.Length - 1; i >= 0; i--)
            {
                int age = ages[i];

                int position = count[age - min] - 1;

                output[position] = age;

                count[age - min]--;
            }
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = output[i];
            }
        }

    }
}

