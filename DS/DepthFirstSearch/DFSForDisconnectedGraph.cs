namespace DepthFirstSearch
{
    public class DFSForDisconnectedGraph
    {
        private int _vertex;
        private List<int>[]? _adjacent;

        public DFSForDisconnectedGraph(int vertex)
        {
            _vertex= vertex;
            _adjacent= new List<int>[vertex];

            for (int i = 0; i < vertex; i++)
                _adjacent[i]= new List<int>();
        }

        public void AddEdge(int v, int w)
        {
            _adjacent[v]!.Add(w);
        }

        public void DFSUtility(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write($"{v} ");

            foreach (var item in _adjacent[v])
            {
                int node = item;

                if (!visited[node])
                    DFSUtility(node, visited);
            }
        }

        public void DFS()
        {
            bool[] visited = new bool[_vertex];

            for (int i = 0; i < _vertex; i++)
            {
                if (visited[i] == false)
                    DFSUtility(i, visited);
            }
        }
    }
}
