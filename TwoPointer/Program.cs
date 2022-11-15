using TwoPointer;

var twoPointerDemo = new TwoPointerDemo();

int[] array = { 2, 3, 5, 7, 8, 9, 10, 11,  };
var length = array.Length;
var target = 17;

var list = twoPointerDemo.IsPairNaive(array, length, target);

Console.WriteLine("Naive approach.");
foreach (var item in list)
    Console.WriteLine(item);

var listOfTwoPointer = twoPointerDemo.IsPairOfTwoPointer(array, length, target);

Console.WriteLine("Two pointer approach.");
foreach (var item in listOfTwoPointer)
    Console.WriteLine(item);

int[] array1 = { 1, 4, 5, 7 };
int[] array2 = { 10, 20, 30, 40 };
var m = array1.Length;
var n = array2.Length;
target = 38;
twoPointerDemo.PrintClosestPairFromTwoSortedArray(
    array1, array2, m, n, target );
Console.WriteLine();

array = new[] { 0, -1, 2, -3, 1 };
length= array.Length;
Console.WriteLine("Triples =>");
twoPointerDemo.FindTriplets(array, length);
