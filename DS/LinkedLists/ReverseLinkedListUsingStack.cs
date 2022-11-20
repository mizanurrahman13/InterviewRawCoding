namespace LinkedLists
{
    public class ReverseLinkedListUsingStack
    {
        public class Node
        {
            public int Data;
            public Node Next;
        }
        public Node head = null;

        public void Reverse()
        {
            var stack = new Stack<Node>();
            Node temp = head;

            while (temp.Next != null)
            {
                stack.Push(temp);
                temp = temp.Next;
            }
            head = temp;

            while (stack.Count != 0)
            {
                temp.Next = stack.Peek();
                stack.Pop();
                temp = temp.Next;
            }
            temp.Next = null;
        }

        public void PrintList(Node temp)
        {
            while (temp != null)
            {
                Console.Write($"{temp.Data} ");
                temp = temp.Next;
            }
        }

        public void InsertBack(int value)
        {
            Node temp = new Node();
            temp.Data = value;
            temp.Next = null;

            if (head == null)
            {
                head = temp;
                return;
            }
            else
            {
                Node lastNode = head;

                while (lastNode != null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = temp;
                return;
            }
        }
    }
}
