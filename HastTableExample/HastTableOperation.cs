using System.Collections;

namespace HastTableExample
{
    public class HastTableOperation
    {
        public void Operations()
        {
            var hashTable = new Hashtable();

            var nameList = new List<string>() 
                { "Lamia", "Nabila", "Tithi", "Rifat", "Piyal", "Azim", "Zabed", "Tofazzal", "Sadia", "Jannat" };

            var i = 1;
            foreach(var name in nameList)
            {
                hashTable.Add($"A{i++}", name);
            }

            foreach(var item in hashTable)
            {
                Console.WriteLine($"{item}{hashTable[item]}");
            }

            hashTable.Remove("A10");

            Console.WriteLine("After romove operation.");
            foreach (var item in hashTable)
            {
                Console.WriteLine($"{item}{hashTable[item]}");
            }

            if (hashTable.ContainsKey("A1") == true)
                Console.WriteLine($"{hashTable.ContainsKey("A1")} -> Item found.");
            else
                Console.WriteLine("Item not found.");

            if (hashTable.ContainsValue("Rifat") == true)
                Console.WriteLine($"{hashTable.ContainsValue("Rifat")} -> Item found.");
            else
                Console.WriteLine("Item not found.");

            Console.WriteLine($"{hashTable.Count} is the length of hashtable.");
        }
    }
}
