using System;
namespace SortingPractice
{
	public class MergeSort1
	{
        static void MergeSort(int[] prices, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            // Divide
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);

            // Merge
            Merge(prices, left, mid, right);
        }

        static void Merge(int[] prices, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;

            int[] temp = new int[right - left + 1];
            int k = 0;

            // Compare elements from both halves
            while (i <= mid && j <= right)
            {
                if (prices[i] <= prices[j])
                {
                    temp[k] = prices[i];
                    i++;
                }
                else
                {
                    temp[k] = prices[j];
                    j++;
                }

                k++;
            }

            // Copy remaining elements from left half
            while (i <= mid)
            {
                temp[k] = prices[i];
                i++;
                k++;
            }

            // Copy remaining elements from right half
            while (j <= right)
            {
                temp[k] = prices[j];
                j++;
                k++;
            }

            // Copy sorted elements back
            for (int x = 0; x < temp.Length; x++)
            {
                prices[left + x] = temp[x];
            }
        }
    }
}

