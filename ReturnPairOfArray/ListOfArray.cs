namespace ReturnPairOfArray
{
    public class ListOfArray
    {
        public List<Tuple<int, int>> PairOfArray()
        {
            var list = new List<Tuple<int,int>>();
            var array = new int[11];
            array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            var target = 11;

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if ((array[i] + array[j]) == target)
                        list.Add(Tuple.Create(array[i], array[j]));
                }
            }

            return list;
        }        
    }
}
