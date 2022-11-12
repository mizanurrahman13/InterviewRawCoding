using BreathFirstSearch;

#region BFS
var breathFirstSearchDemo = new BreathFirstSearchDemo(4);

/**
 * 0 -------------> 1
 * ^ |            /
 * | |        /
 * | |      /
 * | |   /        
 * |\//            
 * 2 -------------> 3
 *----            -----  
 *START           LOOP
 **/

breathFirstSearchDemo.AddEdge(0, 1);
breathFirstSearchDemo.AddEdge(0, 2);
breathFirstSearchDemo.AddEdge(1, 2);
breathFirstSearchDemo.AddEdge(2, 0);
breathFirstSearchDemo.AddEdge(2, 3);
breathFirstSearchDemo.AddEdge(3, 3);

var stringLiteral = """
                    "Following is Breadth First " +
                    "Traversal(starting from " +
                    "vertex 2)")
                    """;
Console.WriteLine($"{stringLiteral} Looking awesome.");

Console.WriteLine(@$"Following is Breadth First " +
                  "Traversal(starting from " +
                  "vertex 2)");

breathFirstSearchDemo.BFS(2);
Console.WriteLine();
#endregion

#region

var islandInAGraphUsingBFS = new IslandInAGraphUsingBFS();

int[,] mat = {  { 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 1 },
                { 1, 0, 0, 1, 1 },
                { 0, 0, 0, 0, 0 },
                { 1, 0, 1, 0, 1 } };

Console.WriteLine($"There is {islandInAGraphUsingBFS.CountIslands(mat)} Island.");

#endregion
