using BubbleSortDemo;

var bubbleSort = new BubbleSort();
var array = new int[] { 5, 1, 4, 2, 8};
bubbleSort.Bubble(array);
bubbleSort.PrintArray(array);

array = new int[] { 64, 34, 25, 12, 22, 11, 90};

var length = array.Length;
bubbleSort.BubbleOptimized(array, length);
bubbleSort.PrintArray(array, length);