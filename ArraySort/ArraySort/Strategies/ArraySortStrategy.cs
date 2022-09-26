using System;

namespace ArraySort.Strategies
{
    public abstract class ArraySortStrategy
    {
        public abstract void Sort<T>(T[] array) where T : IComparable;

        public static void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
