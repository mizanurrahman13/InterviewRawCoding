namespace BreathFirstSearch
{
    public class BreathFirstSearchDemo
    {
        private int _vertex;

        LinkedList<int>[]? _adjacency;

        public BreathFirstSearchDemo(int vertex)
        {
            _adjacency = new LinkedList<int>[vertex];
            for(int i = 0; i < _adjacency.Length; i++)
            {
                _adjacency[i] = new LinkedList<int>();
            }
            _vertex= vertex;
        }

        public void AddEdge(int v, int w)
        {
            _adjacency[v]!.AddLast(w);
        }

        public void BFS(int startEdge)
        {
            // Mark all the vertices as not
            // visited(By default set as false)
            bool[] visited = new bool[_vertex];
            for (int i = 0; i < _vertex; i++)
            {
                visited[i] = false;                
            }

            var queue = new LinkedList<int>();

            // Mark the current node as
            // visited and enqueue it
            visited[startEdge] = true;
            queue.AddLast(startEdge);

            while (queue.Any())
            {
                // Dequeue a vertex from queue
                // and print it
                startEdge = queue.First();
                Console.Write($"{startEdge} ");
                queue.RemoveFirst();

                // Get all adjacent vertices of the
                // dequeued vertex startEnde. If a adjacent
                // has not been visited, then mark it
                // visited and enqueue it
                var list = new LinkedList<int>();
                list = _adjacency[startEdge]!;

                foreach (var item in list)
                {
                    if (!visited[item])
                    {
                        visited[item] = true;
                        queue.AddLast(item);
                    }
                }
            }
        }
    }
}
