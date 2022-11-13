using DepthFirstSearch;

#region DFSDemo
var dFSDemo = new DFSDemo(4);

dFSDemo.AddEdge(0, 1);
dFSDemo.AddEdge(0, 2);
dFSDemo.AddEdge(1, 2);
dFSDemo.AddEdge(2, 0);
dFSDemo.AddEdge(2, 3);
dFSDemo.AddEdge(3, 3);

Console.WriteLine($@"Following is Depth First Traversal "
     + "(starting from vertex 2)");

dFSDemo.DFS(2);
Console.WriteLine();

#endregion

#region DFSForDisconnectedGraph

var dFSForDisconnectedGraph = new DFSForDisconnectedGraph(4);

dFSForDisconnectedGraph.AddEdge(0, 1);
dFSForDisconnectedGraph.AddEdge(0, 2);
dFSForDisconnectedGraph.AddEdge(1, 2);
dFSForDisconnectedGraph.AddEdge(2, 0);
dFSForDisconnectedGraph.AddEdge(2, 3);
dFSForDisconnectedGraph.AddEdge(3, 3);

Console.WriteLine($"Following is Depth First Traversal");

dFSForDisconnectedGraph.DFS();
Console.WriteLine();

#endregion

#region LexicographicallySmallestDFSOfTheGraphStartingFromOne

var lexDFSOfTheGraph = new LexicographicallySmallestDFSOfTheGraphStartingFromOne();

var node = 5;
var max = 5;

List<List<int>> adjacent = new List<List<int>>();

for (int i = 0; i < node + 1; i++)
    adjacent.Add(new List<int>());

lexDFSOfTheGraph.AddEdge(1, 4);
lexDFSOfTheGraph.AddEdge(3, 4);
lexDFSOfTheGraph.AddEdge(5, 4);
lexDFSOfTheGraph.AddEdge(3, 2);
lexDFSOfTheGraph.AddEdge(1, 5);
lexDFSOfTheGraph.AddEdge(1, 2);
lexDFSOfTheGraph.AddEdge(3, 5);
lexDFSOfTheGraph.AddEdge(1, 3);

lexDFSOfTheGraph.PrintLexicographycallySmall(node);


#endregion
