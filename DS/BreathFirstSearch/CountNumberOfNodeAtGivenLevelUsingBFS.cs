namespace BreathFirstSearch
{
    public class CountNumberOfNodeAtGivenLevelUsingBFS
    {
        private int _vertex;

        LinkedList<int>[]? _adjacent;

        public CountNumberOfNodeAtGivenLevelUsingBFS(int vertex)
        {
            _adjacent = new LinkedList<int>[vertex];

            for (int i = 0; i < _adjacent.Length; i++)
            {
                _adjacent[i] = new LinkedList<int>();
            }

            _vertex = vertex;
        }

        public void AddEdge(int v, int w)
        {
            _adjacent[v]!.AddLast(w);
        }

        public int BFS(int startNode, int l)
        {
            bool[] visited = new bool[_vertex];
            int[] level = new int[_vertex];

            for (int i = 0; i < _vertex; i++)
            {
                visited[i] = false;
                level[i] = 0;
            }

            var queue = new LinkedList<int>();

            visited[startNode] = true;
            level[startNode] = 0;
            queue.AddLast(startNode);

            while(queue.Any())
            {
                startNode = queue.First();
                queue.RemoveFirst();

                LinkedList<int>? list = _adjacent[startNode];

                foreach (var item in list)
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        level[item] = level[startNode] + 1;
                        queue.AddLast(item);
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < _vertex; i++)
            {
                if (level[i] == l)
                    count++;
            }

            return count;
        }
    }
}
