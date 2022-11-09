namespace DictionaryExample
{
    public class DictionaryOperation
    {
        public void Print()
        {
            var dictionary = new Dictionary<int, string>();
            var nameList = new List<string>() 
                { "Lamia", "Nabila", "Tithi", "Rifat", "Piyal", "Azim", "Zabed", "Tofazzal", "Sadia", "Jannat" };

            var i = 1;
            foreach(var name in nameList)
            {
                dictionary.Add(i++, $" -> {name}");
            }

            Console.WriteLine(dictionary.Count);
            Console.WriteLine("Befor remove operation");
            foreach(KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}{pair.Value}");
            }

            dictionary.Remove(1);
            Console.WriteLine("After remove operation");
            foreach(KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}{pair.Value}");
            }

            if (dictionary.ContainsKey(2) == true)
                Console.WriteLine($"Key is found.");
            else
                Console.WriteLine($"Key is not found.");

            if (dictionary.ContainsValue(" -> Nabila") == true)
                Console.WriteLine($"Value is found.");
            else
                Console.WriteLine($"Value is not found.");

            dictionary.Clear();
            Console.WriteLine("After clear operation");
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}{pair.Value}");
            }
        }
    }
}
