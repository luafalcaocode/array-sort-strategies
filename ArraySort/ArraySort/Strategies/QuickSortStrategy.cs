﻿using System;

namespace ArraySort.Strategies
{
    public class QuickSortStrategy : ArraySortStrategy
    {
        public override void Sort<T>(T[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static T[] Sort<T>(T[] array, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }

            return array;
        }

        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];

            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }

                if (i >= j) break;

                Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }
    }
}