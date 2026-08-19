using System;
namespace SearchingTechniques
{
	public class RotationPoint
	{
		public static int FindRotationPointInRotatedSortedArray(int[] arr1)
		{
			int[] arr = {1, 2, 3, 4 };
			int start = 0,end=arr.Length-1;
			while (start < end)
			{
				int mid = start + (end - start) / 2;
				if (mid > 0)
				{
					if (arr[mid] < arr[mid-1] && arr[mid] < arr[mid + 1])
					{
						return arr[mid-1];
					}
					else if (arr[mid] > arr[mid - 1] && arr[mid] < arr[mid + 1])
					{
						end = mid - 1;
					}
					else
					{
						start = mid + 1;
					}
				}
				else if(mid==0 && mid<arr.Length-1)
				{
					if (arr[mid] > arr[mid + 1]) return arr[mid];
				}
		}
			return arr[arr.Length - 1];
		}
	}
}

