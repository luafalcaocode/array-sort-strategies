using System;

namespace ArraySort.Strategies
{
    public class ArraySortContext
    {
        private ArraySortStrategy arraySortStrategy;

        public ArraySortContext(ArraySortStrategy strategy)
        {
            this.arraySortStrategy = strategy;
        }

        public void SetStrategy(ArraySortStrategy strategy)
        {
            this.arraySortStrategy = strategy;
        }

        public void Sort<T>(T[] array) where T : IComparable
        {
            this.arraySortStrategy.Sort(array);
        }
    }
}
