namespace TwoPointer
{
    /// <summary>
    /// applying two pointer array must be sorted
    /// </summary>
    public class TwoPointerDemo
    {
        public List<Tuple<int, int>> IsPairNaive(int[] array, int n, int x)
        {
            var list = new List<Tuple<int, int>>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (i == j)
                        continue;

                    if (array[i] + array[j] == x)
                        list.Add(Tuple.Create(array[i], array[j]));

                    if (array[i] + array[j] > x)
                        break;
                }
            }

            return list;
        }

        public List<Tuple<int, int>> IsPairOfTwoPointer(int[] array, int n, int x)
        {
            var list = new List<Tuple<int, int>>();

            var left = 0;
            var right = n - 1;

            while (left < right)
            {
                if (array[left] + array[right] == x)
                {
                    list.Add(Tuple.Create(array[left], array[right]));
                    left++;
                    right--;
                }
                else if (array[left] + array[right] < x)
                    left++;
                else
                    right--;
            }

            return list;
        }

        public void PrintClosestPairFromTwoSortedArray(int[] array1, int[] array2, int m, int n, int x)
        {
            var difference = int.MaxValue;

            var resultLeft = 0;
            var resultRight = 0;

            var left = 0;
            var right = n - 1;

            while (left < m && right >= 0)
            {
                if (Math.Abs(array1[left] + array2[right] - x) < difference) {
                    resultLeft = left;
                    resultRight = right;
                    difference = Math.Abs(array1[left] + array2[right] - x);
                }
                if (array1[left] + array2[right] > x)
                    right--;
                else
                    left++;
            }

            Console.Write($"The closest pair is [{array1[resultLeft]}, {array2[resultRight]}]");
        }

        public void FindTriplets(int[] array, int n)
        {
            var found = false;

            Array.Sort(array);

            for (int i = 0; i < n - 1; i++)
            {
                var left = i + 1;
                var right = n - 1;
                var x = array[i];

                while (left < right)
                {
                    if (x + array[left] + array[right] == 0)
                    {
                        Console.Write($"{x} ");
                        Console.Write($"{array[left]} ");
                        Console.WriteLine($"{array[right]} ");

                        left++;
                        right--;
                        found = true;
                    }
                    else if (x + array[left] + array[right] < 0)
                        left++;
                    else
                        right--;
                }

                if (found == false)
                    Console.WriteLine("No Triplet Found.");
            }
        }
    }
}
