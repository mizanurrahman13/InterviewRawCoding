using HeapExample;

var minHeap = new MinHeap(11);

minHeap.Add(3);
minHeap.Add(2);
minHeap.Add(1);
minHeap.Add(15);
minHeap.Add(5);
minHeap.Add(4);
minHeap.Add(45);

//while (true)
//{
//    var element = minHeap.Peek();
//    Console.WriteLine($"{element}");
//    minHeap.Pop();
//}


Console.WriteLine($"MinHeap Elements: {minHeap.Peek()}");

minHeap.Pop();
Console.WriteLine($"MinHeap Elements: {minHeap.Peek()}");

var maxHeap = new MaxHeap(11);

maxHeap.Add(3);
maxHeap.Add(2);
maxHeap.Add(1);
maxHeap.Add(15);
maxHeap.Add(5);
maxHeap.Add(4);
maxHeap.Add(45);

//while (true)
//{
//    var element = maxHeap.Peek();
//    Console.WriteLine($"{element}");
//    maxHeap.Pop();
//}

Console.WriteLine($"MaxHeap Elements: {maxHeap.Peek()}");

maxHeap.Pop();
Console.WriteLine($"MaxHeap Elements: {maxHeap.Peek()}");