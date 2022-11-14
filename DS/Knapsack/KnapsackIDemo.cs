namespace Knapsack
{
    public class KnapsackIDemo
    {
        public int KnapSack(Item[] items, int capacity)
        {
            int[,] matrix = new int[items.Length + 1, capacity + 1];

            for (int itemIndex = 0; itemIndex <=items.Length; itemIndex++)
            {
                var currentItem = itemIndex == 0 ? null : items[itemIndex - 1];
                for (int currentCapacity = 0; currentCapacity <= capacity; currentCapacity++)
                {
                    if (currentItem == null || currentCapacity == 0)
                    {
                        matrix[itemIndex, currentCapacity] = 0;
                    }
                    else if (currentItem.Weight <= currentCapacity)
                    {
                        var take = currentItem.Value
                                + matrix[itemIndex - 1, currentCapacity - currentItem.Weight];
                        var skip = matrix[itemIndex - 1, currentCapacity];

                        matrix[itemIndex, currentCapacity] = Math.Max(take, skip);
                    }
                    else
                    {
                        var skip = matrix[itemIndex - 1, currentCapacity];
                        matrix[itemIndex, currentCapacity] = skip;
                    }
                        
                }
            }

            return matrix[items.Length, capacity];
        }

        public int KnapSackRecursive(Item[] items, int capacity)
        {
            // if there are no item or capacity is 0 then return 0
            if (items.Length == 0 || capacity == 0)
                return 0;

            // If there is one item and it fits then return it's value
            // otherwise return 0
            if (items.Length == 1)
            {
                return items[0].Weight < capacity ? items[0].Value : 0;
            }

            // keep track of the best seen.
            int best = 0;
            for (int i = 0; i < items.Length; i++)
            {
                // this is an array of the other items.
                var otherItems = items.Take(i).Concat(items.Skip(i + 1)).ToArray();
                
                // Calculate the best value without using the current item.
                var skip = KnapSackRecursive(otherItems, capacity);
                var take = 0;

                // If the current item fits then calculate the best value for
                // a capacity less it's weight and with it removed from contention
                // and add the current items value to that.
                if (items[i].Weight <= capacity)
                {
                    take = KnapSackRecursive(otherItems, capacity - items[i].Weight)
                        + items[i].Value;
                }

                // The current best is the max of the with or without.
                int currentBest = Math.Max(skip, take);

                // determine if the current best is the overall best.
                if (currentBest > best)
                    best = currentBest;
            }

            return best;
        }
    }
}
