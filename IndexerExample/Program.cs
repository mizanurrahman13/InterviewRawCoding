using IndexerExample;

var indexerDemo = new IndexerDemo();

indexerDemo[0] = "Lamia";
indexerDemo[1] = "Nabila";
indexerDemo[2] = "Sadia";

Console.WriteLine("Printing values stored in objects used as array.");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Value {i}: {indexerDemo[i]}");
}

Console.WriteLine("------------------------------");

var multidimensionalIndexer = new MultidimensionalIndexer();

multidimensionalIndexer[0, 0] = 1;
multidimensionalIndexer[0, 1] = 2;
multidimensionalIndexer[0, 2] = 3;

multidimensionalIndexer[1, 0] = 4;
multidimensionalIndexer[1, 1] = 5;
multidimensionalIndexer[1, 2] = 6;

multidimensionalIndexer[2, 0] = 7;
multidimensionalIndexer[2, 1] = 8;
multidimensionalIndexer[2, 2] = 9;

Console.WriteLine($"""
                  {multidimensionalIndexer[0, 0]} {multidimensionalIndexer[0, 1]} {multidimensionalIndexer[0, 2]}
                  {multidimensionalIndexer[1, 0]} {multidimensionalIndexer[1, 1]} {multidimensionalIndexer[1, 2]}
                  {multidimensionalIndexer[2, 0]} {multidimensionalIndexer[2, 1]} {multidimensionalIndexer[2, 2]}
                  """);

Console.WriteLine("--------------------------------");

var overLoadingIndexer = new OverLoadingIndexer();

overLoadingIndexer[0] = "Hi, ";
overLoadingIndexer[1] = "Lamia";

Console.WriteLine($"{overLoadingIndexer[0]} {overLoadingIndexer[1]}");