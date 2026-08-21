using System;
namespace AlgorithmComplexity
{
	public class SearchATargetInDataSet
	{
		
        static int[] arr = Enumerable.Range(1, 1_000_000).ToArray();
		static int n = 999998;
        public static int LinearSearch()
		{
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == n) return i;
			}
			return 0;
		}

		public static int BinarySearch()
		{
			int start = 0, end = arr.Length - 1;
			while (start <= end)
			{
				int mid = start + (end - start) / 2;
				if (arr[mid] == n)
				{
					return mid;
				}
				else if (arr[mid]>n)
				{
					end = mid - 1;
				}
				else
				{
					start = mid + 1;
				}
			}
			return -1;
		}
	}
}

