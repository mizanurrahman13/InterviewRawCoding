using System.Collections;

namespace MergeOverlappingInterval
{
    public class MergeOverlappingIntervals
    {
        public class SortHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Interval first = (Interval)a;
                Interval second = (Interval)b;

                if (first.start == second.start)
                    return first.end - second.end;

                return first.start - second.start;
            }
        }

        public void MergeIntervals(Interval[] array)
        {
            if (array.Length <= 0)
                return;

            Array.Sort(array, new SortHelper());

            var stack = new Stack();
            stack.Push(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                Interval top = (Interval)stack.Peek();

                if (top.end < array[i].start)
                    stack.Push(array[i]);
                else if (top.end < array[i].end)
                {
                    top.end = array[i].end;
                    stack.Pop();
                    stack.Push(top);
                }
            }

            Console.Write("The Merged Intervals are: ");
            while (stack.Count != 0)
            {
                Interval t = (Interval)stack.Pop();
                Console.Write($"[ {t.start}, {t.end} ]");
            }
        }
    }

    public class Interval
    {
        public int start, end;
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
