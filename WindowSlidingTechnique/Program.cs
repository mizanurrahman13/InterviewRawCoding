using WindowSlidingTechnique;

var windowSlidingDemo = new WindowSlidingDemo();

int[] array = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
int k = 4;
int length = array.Length;

Console.WriteLine($"Naive Approach Result: {windowSlidingDemo.SlidingWindowNaiveApproach(array, length, k)}");

array = new int[] { 5, 2, -1, 0, 3 };
length= array.Length;
k = 3;

Console.WriteLine($"Sliding Window Technique Result: {windowSlidingDemo.SlidingWindow(array, length, k)}");

array = new int[] { 9, 7, 2, 4, 6, 8, 2, 1, 5 };
length = array.Length;
k = 3;

windowSlidingDemo.MaximumOfAllSubarrayOfSizeK(array, length, k);