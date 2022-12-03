using BinarySearchExample;

var ceilingInASortedArray = new CeilingInASortedArray();

int[] array = { 1, 2, 8, 10, 10, 12, 19 };
int length = array.Length;
int target = 8;
int index = ceilingInASortedArray.CeilSearch(array, 0, length - 1, target);

if (index == -1)
    Console.Write("Ceiling of " + target
                          + " doesn't exist in array");
else
    Console.Write("ceiling of " + target + " is "
                  + array[index]);
Console.WriteLine();

index = ceilingInASortedArray.CeilSearchSimple(array, 0, length - 1, target);

if (index == -1)
    Console.Write("Ceiling of " + target
                          + " doesn't exist in array");
else
    Console.Write("ceiling of " + target + " is "
                  + array[index]);

Console.WriteLine("\nBitonic Part----------------");
var bitonicArrayDemo = new BitonicArrayDemo();
array = new[] { -8, 1, 2, 3, 4, 5, -2, -3 };
target = -2;
int n, left, right;
n = array.Length;
left = 0;
right = n - 1;
index = bitonicArrayDemo.FindBitonicPoint(array, n, left, right);

int x = bitonicArrayDemo.SearchBitonic(array, n, target, index);

if (x == -1)
    Console.WriteLine("Element Not Found.");
else
    Console.WriteLine($"Element Found at Index[{x}].");