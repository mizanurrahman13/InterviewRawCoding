namespace LinkedLists
{
    public class ReverseLinkedListRecursive
    {
        public Node head;

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

        public Node ReverseLinkedList(Node head)
        {
            if (head == null || head.Next == null)
                return head;

            // Reverse the rest list and put
            // the first element at the end
            Node rest = ReverseLinkedList(head.Next);
            head.Next.Next = head;

            // Tricky step --
            // see the diagram
            head.Next = null;

            // Fix the head pointer
            return rest;
        }

        public void PrintList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.Data} ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void Push(int data)
        {
            Node temp = new Node(data);
            temp.Next = head;
            head = temp;
        }

        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }
        }
    }
}
