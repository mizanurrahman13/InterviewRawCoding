namespace WindowSlidingTechnique
{
    public class WindowSlidingDemo
    {
        public int SlidingWindowNaiveApproach(int[] array, int n, int k)
        {
            var maxSum = int.MinValue;

            for (int i = 0; i < n - k + 1; i++)
            {
                var currentSum = 0;
                for (int j = 0; j < k; j++)
                {
                    currentSum = currentSum + array[i + j];
                }

                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum;
        }

        public int SlidingWindow(int[] array, int n, int k)
        {
            if (n < k)
            {
                Console.WriteLine("Invalid.");
                return -1;
            }

            var maxSum = 0;
            for (int i = 0; i < k; i++)
                maxSum += array[i];

            var windowSum = maxSum;
            for (int i = k; i < n; i++)
            {
                windowSum += array[i] - array[i - k];
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }

        public void MaximumOfAllSubarrayOfSizeK(int[] array, int n, int k)
        {
            int[] maxUpto = new int[n];

            var stack = new Stack<int>();
            stack.Push(0);

            for (int i = 1; i < n; i++)
            {
                while (stack.Count != 0 && array[stack.Peek()] < array[i])
                {
                    maxUpto[stack.Peek()] = i - 1;
                    stack.Pop();
                }
                stack.Push(i);
            }

            while (stack.Count != 0)
            {
                maxUpto[stack.Peek()] = n - 1;
                stack.Pop();
            }

            int j = 0;
            for (int i = 0; i <= n - k; i++)
            {
                while (j < i || maxUpto[j] < i + k - 1)
                    j++;
                Console.Write($"{array[j]} ");
            }
            Console.WriteLine();
        }
    }
}
