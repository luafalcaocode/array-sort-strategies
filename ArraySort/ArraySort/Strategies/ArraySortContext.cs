using System;

namespace ArraySort.Strategies
{
    public class ArraySortContext
    {
        private ISortStrategy arraySortStrategy;

        public ArraySortContext(ISortStrategy strategy)
        {
            this.arraySortStrategy = strategy;
        }

        public void SetStrategy(ISortStrategy strategy)
        {
            this.arraySortStrategy = strategy;
        }

        public void Sort<T>(T[] array) where T : IComparable
        {
            this.arraySortStrategy.Sort(array);
        }
    }
}
