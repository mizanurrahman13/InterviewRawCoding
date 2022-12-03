/***
 * Best Case Scenario time complexity is N(logN)
 * Worst Case Scenario time complexity is O(N^2)
 * Therefor to avoid worst case scenario mark pivot to mid element or random element.
 ***/

namespace QuickSortDemo
{
    public class QuickSort
    {
        public int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);

            return i + 1;
        }

        public void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                Sort(array, low, partitionIndex - 1);
                Sort(array, partitionIndex + 1, high);
            }
        }

        public void SortOptimized(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                if (partitionIndex - low < high - partitionIndex)
                {
                    Sort(array, low, partitionIndex - 1);
                    low = partitionIndex + 1;
                }
                else
                {
                    Sort(array, partitionIndex + 1, high);
                    high = partitionIndex - 1;
                }
                
            }
        }

        public void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public void PrintArray(int[] array, int length)
        {
            int i;
            for (i = 0; i < length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }        

        public int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var left = leftIndex;
            int right = rightIndex;
            var pivot = array[leftIndex];

            while (left <= right)
            {
                while (array[left] < pivot)
                    left++;
                while (array[right] > pivot)
                    right--;

                if (left <= right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }

            if (leftIndex < right)
                SortArray(array, leftIndex, right);

            if (rightIndex > left)
                SortArray(array, left, rightIndex);

            return array;
        }
    }
}
