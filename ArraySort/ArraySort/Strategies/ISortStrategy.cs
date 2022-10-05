using System;

namespace ArraySort.Strategies
{
    public interface ISortStrategy
    {
        void Sort<T>(T[] array) where T : IComparable;
    }
}
