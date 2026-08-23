using System;
namespace AlgorithmComplexity
{
	public class Sorting
	{
        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

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

		public static void SelectionSort(int[] arr)
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

		public static void InsertionSort(int[] arr)
		{
			int n = arr.Length;
			for(int i = 1; i < n ; i++)
			{
				int index = i;
				while (index > 0 && arr[index] < arr[index-1])
				{
					swap(arr, index, index - 1);
					index--;
				}
			}
		}

		public static int Partition(int[] arr,int left,int right)
		{
			int pivot = arr[right];
			int i = left - 1;
			for(int j = left; j < right; j++)
			{
				if (arr[j] < pivot)
				{
					i++;
					swap(arr, i, j);
				}
			}
			swap(arr, i + 1, right);
			return i + 1;
		}
		public static void QuickSort(int[] arr,int left,int right)
		{
			if (left > right) return;
			int pivotIndex = Partition(arr, left, right);
			QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);

        }

		public static void Merge(int[] arr,int left,int mid,int right)
		{
			int[] temp = new int[right - left + 1];

			int i = left;
			int j = mid + 1;
			int k = 0;

			while(i<=mid && j <= right)
			{
				if (arr[i] > arr[j])
				{
					temp[k] = arr[j];
					j++;
				}
				else
				{
					temp[k] = arr[i];
					i++;
				}
				k++;
			}

			while (i <= mid)
			{
				temp[k++] = arr[i++];
			}

			while (j <= right)
			{
				temp[k++] = arr[j++];
			}

			for(int x = 0; x < temp.Length; x++)
			{
				arr[left + x] = temp[x];
			}
		}

		public static void MergeSort(int[] arr,int left,int right)
		{
			if (left >= right) return;
			int mid = left + (right - left) / 2;
			MergeSort(arr,left,mid);
			MergeSort(arr, mid + 1, right);
			Merge(arr, left, mid, right);
		}
	}
}

