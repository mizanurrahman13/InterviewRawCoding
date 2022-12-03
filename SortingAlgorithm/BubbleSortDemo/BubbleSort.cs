namespace BubbleSortDemo
{
    public class BubbleSort
    {
        public void Bubble(int[] array)
        {
            var length = array.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void BubbleOptimized(int[] array, int length)
        {
            int i, j, temp;
            bool swapped;

            for (i = 0; i < length - 1; i++)
            {
                swapped= false;
                for (j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }

        public void PrintArray(int[] array, int length)
        {
            int i;
            for (i = 0; i < length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }

        public void PrintArray(int[] array)
        {
            var length = array.Length;
            for (int i = 0; i < length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }
    }
}
