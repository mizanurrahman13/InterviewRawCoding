namespace BinarySearchExample
{
    public class CeilingInASortedArray
    {
        public int CeilSearch(int[] array, int low, int high, int target)
        {
            int mid;

            if (target <= array[low])
                return low;

            if (target > array[high])
                return -1;

            mid = (low + high) / 2;

            if (array[mid] == target)
                return mid;

            else if (array[mid] < target)
            {
                if (mid + 1 <= high && target <= array[mid + 1])
                    return mid + 1;
                else
                    return CeilSearch(array, mid + 1, high, target);
            }
            else
            {
                if (mid - 1 >= low && target > array[mid - 1])
                    return mid;
                else
                    return CeilSearch(array, low, mid - 1, target);
            }
        }

        public int CeilSearchSimple(int[] array, int low, int high, int target)
        {
            if (target == 0)
                return -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (target == array[mid])
                    return mid;
                if (target < array[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return low;
        }
    }
}
