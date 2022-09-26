namespace ArraySort.Strategies
{
    public class InsertionSortStrategy : ArraySortStrategy
    {
        public override void Sort<T>(T[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }
    }
}
