namespace IndexerExample
{
    public class OverLoadingIndexer
    {
        private string[] word = new string[2];

        public string this[int flag]
        {
            get
            {
                string temp = word[flag];
                return temp;
            }
            set
            {
                word[flag] = value;
            }
        }

        public string this[float flag]
        {
            get
            {
                string temp = word[1];
                return temp;
            }
            set
            {
                word[1] = value;
            }
        }
    }
}
