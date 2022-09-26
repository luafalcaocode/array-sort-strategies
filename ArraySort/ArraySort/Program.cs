using ArraySort.Strategies;
using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 0, 100, -3453, 542, 421, -2, -6, 1 };
            string[] names = { "João", "Maria", "Zelda", "Link", "Arthas", "Jaina" };
            char[] letters = { 'Z', 'Y', 'B', 'D', 'K', 'A', 'E', 'J', 'N', 'O', 'C', 'F', 'H', 'I', 'G', 'U', 'V', 'Q', 'S', 'R', 'X', 'L', 'M', 'P', 'W', 'T' };
            double[] temperatures = {19.9 , -25.4, 35.2, 10.8, -15.23 };

            var context = new ArraySortContext(new QuickSortStrategy());

            Console.WriteLine("Ordenação usando Quick Sort:");
            context.Sort(numbers);
            Print(numbers);
            Console.WriteLine();

            Console.WriteLine("Ordenação usando Insertion Sort:");
            context.SetStrategy(new InsertionSortStrategy());
            context.Sort(names);
            Print(names);
            Console.WriteLine();

            Console.WriteLine("Ordenação usando Selection Sort:");
            context.SetStrategy(new SelectionSortStrategy());
            context.Sort(letters);
            Print(letters);
            Console.WriteLine();

            Console.WriteLine("Ordenação usando Bubble Sort:");
            context.SetStrategy(new BubbleSortStrategy());
            context.Sort(temperatures);
            Print(temperatures);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void Print<T>(T[] array) where T : IComparable
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
