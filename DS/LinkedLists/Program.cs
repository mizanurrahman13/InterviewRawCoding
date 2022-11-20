using LinkedLists;
using static LinkedLists.ReverseLinkedListRecursive;

var list = new LinkedList();

list.AddNode(new LinkedList.Node(85));
list.AddNode(new LinkedList.Node(15));
list.AddNode(new LinkedList.Node(4));
list.AddNode(new LinkedList.Node(20));

Console.WriteLine("Given linked list ");
list.PrintList();

// Reverse the list
list.ReverseList();

// List after reversal
Console.WriteLine("Reversed linked list ");
list.PrintList();
Console.WriteLine("-------------------------------");

var reverseLinkedListRecursive = new ReverseLinkedListRecursive();


reverseLinkedListRecursive.Push(20);
reverseLinkedListRecursive.Push(4);
reverseLinkedListRecursive.Push(15);
reverseLinkedListRecursive.Push(85);

Console.WriteLine("Given linked list");
reverseLinkedListRecursive.PrintList();

reverseLinkedListRecursive.head = reverseLinkedListRecursive.ReverseLinkedList(reverseLinkedListRecursive.head);
Console.WriteLine("Reversed linked list");
reverseLinkedListRecursive.PrintList();

Console.WriteLine("-------------------------------");

var reverseLinkedListUsingStack = new ReverseLinkedListUsingStack();

reverseLinkedListUsingStack.InsertBack(1);
reverseLinkedListUsingStack.InsertBack(2);
reverseLinkedListUsingStack.InsertBack(3);
reverseLinkedListUsingStack.InsertBack(4);

Console.WriteLine("Given linked list");
reverseLinkedListUsingStack.PrintList(reverseLinkedListUsingStack.head);

reverseLinkedListUsingStack.Reverse();

Console.WriteLine("Reversed linked list");
reverseLinkedListUsingStack.PrintList(reverseLinkedListUsingStack.head);