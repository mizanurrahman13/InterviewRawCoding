using Knapsack;

var knapsack = new KnapsackIDemo();

var items = new[]
{
    new Item { Value = 60, Weight = 10 },
    new Item { Value = 100, Weight = 20 },
    new Item { Value = 120, Weight = 30 }
};

Console.WriteLine($"Iterative Method: {knapsack.KnapSack(items, 50)}");

Console.WriteLine($"Recursive Method: {knapsack.KnapSackRecursive(items, 50)}");

#region Memoization

var knapSackMemoization = new KnapSackMemoization();

int[] val = new int[] { 60, 100, 120 };
int[] wt = new int[] { 10, 20, 30 };

int W = 50;
int N = val.Length;

Console.WriteLine($"Memoization Result: {knapSackMemoization.KnapSack(W, wt, val, N)}");

#endregion