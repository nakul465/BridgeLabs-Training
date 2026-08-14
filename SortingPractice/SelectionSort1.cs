using System;
namespace SortingPractice
{
	public class SelectionSort1
	{
        static void SelectionSort(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                int minIndex = i;

                // Find minimum element
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap minimum element with first unsorted element
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }
    }
}

