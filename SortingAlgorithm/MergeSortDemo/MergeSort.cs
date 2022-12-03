namespace MergeSortDemo
{
    public class MergeSort
    {
        public void Merge(int[] array, int left, int middle, int right)
        {
            var lengthOfLeftSubArray = middle - left + 1;
            var lengthOfRightSubArray = right - middle;

            int[] leftArray = new int[lengthOfLeftSubArray];
            int[] rightArray = new int[lengthOfRightSubArray];

            int leftIndex, rightIndex;

            for (leftIndex = 0; leftIndex < lengthOfLeftSubArray; leftIndex++)
                leftArray[leftIndex] = array[left + leftIndex];

            for (rightIndex = 0; rightIndex < lengthOfRightSubArray; rightIndex++)
                rightArray[rightIndex] = array[middle + 1 + rightIndex];

            leftIndex = 0;
            rightIndex = 0;

            int k = left;
            while(leftIndex < lengthOfLeftSubArray && rightIndex < lengthOfRightSubArray)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[k] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[k] = rightArray[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < lengthOfLeftSubArray)
            {
                array[k] = leftArray[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < lengthOfRightSubArray)
            {
                array[k] = rightArray[rightIndex];
                rightIndex++;
                k++;
            }
        }

        public void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                Sort(array, left, mid);
                Sort(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        public void PrintArray(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }
    }
}
