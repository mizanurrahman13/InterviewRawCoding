namespace DepthFirstSearch
{
    public class DFSDemo
    {
        private int _vertex;
        private List<int>[]? _adjacent;

        public DFSDemo(int vertex)
        {
            _vertex = vertex;
            _adjacent = new List<int>[vertex];

            for (int i = 0; i < vertex; i++)
            {
                _adjacent[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            _adjacent[v]!.Add(w);
        }

        public void DFSUtility(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write($"{v} ");

            List<int> list = _adjacent[v];
            foreach (int item in list)
            {
                if (!visited[item])
                    DFSUtility(item, visited);
            }
        }

        public void DFS(int v)
        {
            bool[] visited = new bool[_vertex];

            DFSUtility(v, visited);
        }
    }
}
