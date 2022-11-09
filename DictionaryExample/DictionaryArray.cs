namespace DictionaryExample
{
    public class DictionaryArray
    {
        public IDictionary<int, int> PairOfArray()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var target = 11;
            var dictionary = new Dictionary<int, int>();

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                        dictionary.Add(array[i], array[j]);
                }
            }

            return dictionary;
        }
    }
}
