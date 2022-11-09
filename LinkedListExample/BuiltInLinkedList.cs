namespace LinkedListExample
{
    public class BuiltInLinkedList
    {
        public void DefaultLinkedList()
        {
            var linkedList = new LinkedList<string>();

            for (int i = 0; i < 10; i++)
            {
                linkedList.AddLast($"{ i+1 } -> Lamia.");
            }
            
            foreach (var linked in linkedList)
            {
                Console.WriteLine(linked);
            }

            var length = linkedList.Count;

            Console.WriteLine("-----------------");
            Console.WriteLine(length);
        }
        
    }
}
