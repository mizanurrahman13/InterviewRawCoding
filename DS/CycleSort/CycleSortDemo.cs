namespace CycleSort
{
    public class CycleSortDemo
    {
        public void CycleSortOOfnSquare(int[] array, int n)
        {
            // count number of memory writes
            int writes = 0;

            // traverse array elements and
            // put it to on the right place
            for (int cycleStart = 0; cycleStart < n - 2; cycleStart++)
            {
                // initialize item as starting point
                int item = array[cycleStart];

                // Find position where we put the item.
                // We basically count all smaller elements
                // on right side of item.
                int position = cycleStart;

                for (int i = cycleStart + 1; i < n; i++)
                    if (array[i] < item)
                        position++;

                // If item is already in correct position
                if (position == cycleStart)
                    continue;

                // ignore all duplicate elements
                while (item == array[position])
                    position += 1;

                // put the item to it's right position
                if (position != cycleStart)
                {
                    int tmp = item;
                    item = array[position];
                    array[position] = tmp;
                    writes++;
                }

                // Rotate rest of the cycle
                while (position != cycleStart)
                {
                    position = cycleStart;

                    // Find position where we put the element
                    for (int i = cycleStart + 1; i < n; i++)
                        if (array[i] < item)
                            position += 1;

                    // ignore all duplicate elements
                    while (item == array[position])
                        position += 1;

                    // put the item to it's right position
                    if (item != array[position])
                    {
                        int tmp = item;
                        item = array[position];
                        array[position] = tmp;
                        writes++;
                    }
                }
            }
        }

        public void CycleSortOOfn(int[] array, int n)
        {
            int i = 0;
            while (i < n)
            {
                int correctPosition = array[i] - 1;
                if (array[i] < n && array[i] != array[correctPosition])
                    Swap(array, i, correctPosition);
                else
                    i++;
            }
            Console.Write("\nAfter Sort : ");
            for (int index = 0; index < n; index++)
                Console.Write($"{array[index]} ");
        }

        public void Swap(int[] array, int i, int correctPosition)
        {
            int tmp = array[i];
            array[i] = array[correctPosition];
            array[correctPosition] = tmp;
        }
    }
}
