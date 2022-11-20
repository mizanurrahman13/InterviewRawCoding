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