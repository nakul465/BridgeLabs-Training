using System;
namespace AlgorithmComplexity
{
	public class Sorting
	{
		public static void BubbleSort(int[] arr)
		{
			for(int i = 0; i < arr.Length; i++)
			{
				for(int j = 0; j < arr.Length - 1 - i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}

		public static void InsertionSort(int[] arr)
		{
			int index = arr.Length - 1;
			for(int i = 0; i < arr.Length; i++)
			{
				int maxIndex = 0;
				for(int j = 0; j < arr.Length - i; j++)
				{
					if (arr[j] > arr[maxIndex])
					{
						maxIndex = j;
					}
				}
				swap(arr, index, maxIndex);
				index--;
			}
		}
		public static void swap(int[] arr,int i,int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}
	}
}

