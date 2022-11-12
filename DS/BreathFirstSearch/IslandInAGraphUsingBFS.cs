namespace BreathFirstSearch
{
    public class IslandInAGraphUsingBFS
    {
        static readonly int R = 5;
        static readonly int C = 5;

        internal class Pair
        {
            public int first, second;
            public Pair(int first, int second)
            {
                this.first = first;
                this.second = second;
            }
        }

        static bool isSafe(int[,] mat, int i, int j, bool[,] vis)
        {
            return (i >= 0) && (i < R) && (j >= 0) && (j < C) && (mat[i, j] == 1 && !vis[i, j]);
        }

        static void BFS(int [,] mat, bool [,] vis, int si, int sj)
        {
            // These arrays are used to get row and
            // column numbers of 8 neighbours of
            // a given cell
            int[] row = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] col = { -1, 0, 1, -1, 1, -1, 0, 1 };

            // Simple BFS first step, we enqueue
            // source and mark it as visited
            var queue = new List<Pair>();
            queue.Add(new Pair(si, sj));
            vis[si, sj] = true;

            // Next step of BFS. We take out
            // items one by one from queue and
            // enqueue their univisited adjacent
            while (queue.Count != 0)
            {
                int i = queue[0].first;
                int j = queue[0].second;
                queue.RemoveAt(0);

                // Go through all 8 adjacent
                for (int k = 0; k < 8; k++)
                {
                    if (isSafe(mat, i + row[k], j + col[k], vis))
                    {
                        vis[i + row[k], j + col[k]] = true;
                        queue.Add(new Pair(i + row[k], j + col[k]));
                    }
                }
            }
        }

        // This function returns number islands (connected
        // components) in a graph. It simply works as
        // BFS for disconnected graph and returns count
        // of BFS calls.
        public int CountIslands(int[,] mat)
        {
            // Mark all cells as not visited
            bool[,] vis = new bool[R, C];

            // Call BFS for every unvisited vertex
            // Whenever we see an univisted vertex,
            // we increment res (number of islands)
            // also.
            int result = 0;
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (mat[i, j] == 1 && !vis[i, j])
                    {
                        BFS(mat, vis, i, j);
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
