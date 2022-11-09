namespace ReturnDuplicateNumnersFromArray
{
    public class DuplicateNumbersArray
    {
        public List<int> DuplicateNumber()
        {
            var array = new int[] {1,2,3,4,5,6,7,8,9,10,4,5,2,1,9};
            Array.Sort(array);
            var list = new List<int>();

            //foreach (int i in array)
            //{
            //    if (array[i] == array[i+1])
            //        list.Add(i);
            //}

            for(int i=0; i<array.Length; i++)
            {
                for(int j=i+1; j<array.Length; j++)
                {
                    if (array[i] == array[j])
                        list.Add(array[i]);
                }
                
            }

            return list;
        }
    }
}
