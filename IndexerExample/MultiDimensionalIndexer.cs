namespace IndexerExample
{
    public class MultidimensionalIndexer
    {
        int[,] data = new int[5, 5];

        public int this[int index1, int index2]
        {
            get
            {
                return data[index1, index2];
            }

            set
            {
                data[index1, index2] = value;
            }
        }
    }
}
