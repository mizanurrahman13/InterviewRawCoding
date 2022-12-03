using MergeSortDemo;

var mergeSort = new MergeSort();

var array = new int[]{ 12, 11, 13, 5, 6, 7 };
mergeSort.Sort(array, 0, array.Length - 1);
mergeSort.PrintArray(array);