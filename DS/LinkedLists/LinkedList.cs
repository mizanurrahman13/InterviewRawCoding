namespace LinkedLists
{
    public class LinkedList
    {
        Node Head;

        public class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
            
        public void AddNode(Node node)
        {
            if (Head == null)
                Head = node;
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
        }

        public void ReverseList()
        {
            Node previous = null, current = Head, Next = null;

            while (current != null)
            {
                Next = current.Next;
                current.Next = previous;
                previous = current;
                current = Next;
            }

            Head = previous;
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write($"{current.Data} ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
