namespace BinarySearchExample
{
    public class BitonicArrayDemo
    {
        public int AscendingBinarySearch(int[] array, int low, int high, int target)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == target)
                    return mid;
                if (array[mid] > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }

        public int DescendingBinarySearch(int[] array, int low, int high, int target)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == target)
                    return mid;
                if (array[mid] < target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }

        public int FindBitonicPoint(int[] array, int n, int left, int right)
        {
            int mid;
            int bitonicPoint = 0;
            mid = (right + left) / 2;
            if (array[mid] > array[mid - 1] && array[mid] > array[mid + 1])
                return mid;
            else
            {
                if (array[mid] > array[mid - 1] && array[mid] < array[mid + 1])
                    bitonicPoint = FindBitonicPoint(array, n, mid, right);
                else
                    if (array[mid] < array[mid - 1] && array[mid] > array[mid + 1])
                    bitonicPoint = FindBitonicPoint(array, n, left, mid);
            }

            return bitonicPoint;
        }

        public int SearchBitonic(int[] array, int n, int target, int index)
        {
            if (target > array[index])
                return -1;
            else if (target == array[index])
                return index;
            else
            {
                int temp = AscendingBinarySearch(array, 0, index - 1, target);
                if (temp != -1)
                    return temp;

                return DescendingBinarySearch(array, index + 1, n - 1, target);
            }
        }
    }
}
