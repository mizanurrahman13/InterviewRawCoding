using QuickSortDemo;
using System.Diagnostics;

var quickSort = new QuickSort();
var array = new[] { 52, 96, 67, 71, 42, 38, 39, 40, 14 };
var length = array.Length;

//var stopwatch = new Stopwatch();

//stopwatch.Start();

//quickSort.Sort(array, 0, length - 1);
//quickSort.PrintArray(array, length);

//stopwatch.Stop();

//Console.WriteLine($"Time Elapsed in MS: {stopwatch.ElapsedMilliseconds}");

var stopwatch2 = new Stopwatch();

//array = new int[] { 14, 38, 39, 40, 42, 52, 67, 71, 96 };

stopwatch2.Start();

quickSort.SortOptimized(array, 0, length - 1);
quickSort.PrintArray(array, length);

stopwatch2.Stop();

Console.WriteLine($"Time Elapsed in MS: {stopwatch2.ElapsedMilliseconds}");