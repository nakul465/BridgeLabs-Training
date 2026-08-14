using System;
namespace SortingPractice
{
	public class InsertionSort1
	{
        static void InsertionSort(int[] employeeIds)
        {
            for (int i = 1; i < employeeIds.Length; i++)
            {
                int key = employeeIds[i];
                int j = i - 1;

                // Move elements greater than key one position ahead
                while (j >= 0 && employeeIds[j] > key)
                {
                    employeeIds[j + 1] = employeeIds[j];
                    j--;
                }

                // Insert key at its correct position
                employeeIds[j + 1] = key;
            }
        }
    }
}

