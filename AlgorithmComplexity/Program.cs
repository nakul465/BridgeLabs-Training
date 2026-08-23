// See https://aka.ms/new-console-template for more information
using AlgorithmComplexity;
//Console.WriteLine(SearchATargetInDataSet.LinearSearch());
//Console.WriteLine(SearchATargetInDataSet.BinarySearch());
//Console.WriteLine("Hello, World!");
int[] arr = { 1, 33, 55, 633, 4, 5, 5, 6,-10,-11 };
Sorting.QuickSort(arr,0,arr.Length-1);
Console.WriteLine(string.Join(',', arr));
