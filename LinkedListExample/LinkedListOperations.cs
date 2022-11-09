namespace LinkedListExample
{
    public class LinkedListOperations
    {
        public void ClearOperation()
        {
            var list = new LinkedList<string>();
            var nameList = new List<string>() { "Lamia", "Nabila", "Tithi", "Rifat", "Piyal", "Azim", "Zabed", "Tofazzal", "Sadia", "Jannat" };
            var i = 1;
            foreach (var name in nameList)
            {
                list.AddLast($"{i++} -> "+name);
            }

            Console.WriteLine("Before Clear Operation");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            //list.Remove(list.First);
            list.RemoveFirst();
            Console.WriteLine("after removing first element Operation");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            //list.Remove(list.Last);
            list.RemoveLast();
            Console.WriteLine("after removing last element Operation");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            if (list.Contains("4 -> Rifat") == true)
                Console.WriteLine($"Name is found.");
            else
                Console.WriteLine($"Name is not found.");

            list.Clear();

            Console.WriteLine("After Clear Operation");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
