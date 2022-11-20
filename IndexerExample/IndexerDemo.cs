namespace IndexerExample
{
    public class IndexerDemo
    {
        private string[] values = new string[3];

        public string this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }
    }
}
