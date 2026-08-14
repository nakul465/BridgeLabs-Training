using System;
namespace SortingPractice
{
	public class BubbleSort1
	{
        static void BubbleSort(int[] marks)
        {
            for (int i = 0; i < marks.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < marks.Length - 1 - i; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}

