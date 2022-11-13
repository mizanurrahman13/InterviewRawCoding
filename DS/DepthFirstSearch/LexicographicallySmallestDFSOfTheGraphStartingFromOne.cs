namespace DepthFirstSearch
{
    public class LexicographicallySmallestDFSOfTheGraphStartingFromOne
    {
        public bool[] visited;
        public List<List<int>> adjacent = new List<List<int>>();

        public void AddEdge(int u, int v)
        {
            adjacent[u].Add(v);
            adjacent[v].Add(u);
        }

        public void DFS(int source, int node)
        {
            Console.Write($"{source} ");

            visited[source] = true;

            for (int i = 0; i < adjacent[source].Count; i++)
            {
                if (!visited[adjacent[source][i]])
                    DFS(adjacent[source][i], node);
            }
        }

        public void PrintLexicographycallySmall(int node)
        {
            visited = new bool[node + 1];

            for (int i = 0; i < node; i++)
                adjacent[i].Sort();

            for (int i = 1; i < node; i++)
            {
                if (!visited[i])
                    DFS(i, node);
            }
        }
    }
}
