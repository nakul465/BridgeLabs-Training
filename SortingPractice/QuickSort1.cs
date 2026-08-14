using System;
namespace SortingPractice
{
	public class QuickSort1
	{
        static void QuickSort(int[] prices, int low, int high)
        {
            if (low < high)
            {
                // Partition the array
                int pivotIndex = Partition(prices, low, high);

                // Sort left part
                QuickSort(prices, low, pivotIndex - 1);

                // Sort right part
                QuickSort(prices, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] prices, int low, int high)
        {
            int pivot = prices[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (prices[j] < pivot)
                {
                    i++;

                    int temp = prices[i];
                    prices[i] = prices[j];
                    prices[j] = temp;
                }
            }

            // Place pivot in its correct position
            int temp2 = prices[i + 1];
            prices[i + 1] = prices[high];
            prices[high] = temp2;

            return i + 1;
        }
    }
}

