namespace Knapsack
{
    public class KnapSackMemoization
    {
        public int MaxReault(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public int KnapSackRecursion(int W, int[] wt, int[] val, int n, int[, ] dp)
        {
            if (n == 0 || W == 0)
                return 0;
            if (dp[n, W] != -1)
                return dp[n, W];
            if (wt[n - 1] > W)
                // Store the value of function call
                // stack in table before return
                return dp[n, W] =
                    KnapSackRecursion(W, wt, val, n - 1, dp);
            else
                // Return value of table after storing
                return dp[n, W] =
                    MaxReault((val[n - 1]
                    + KnapSackRecursion(W - wt[n - 1], wt, val, n - 1, dp)),
                    KnapSackRecursion(W, wt, val, n - 1, dp));
        }

        public int KnapSack(int W, int[] wt, int[] val, int N)
        {
            int[,] dp = new int[N + 1, W + 1];

            for (int i = 0; i < N+1; i++)
                for (int j = 0; j < W+1; j++)
                    dp[i, j] = -1;

            return KnapSackRecursion(W, wt, val, N, dp);
        }
    }
}
