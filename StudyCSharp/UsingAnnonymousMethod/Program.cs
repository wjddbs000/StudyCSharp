using System;

namespace UsingAnnonymousMethod
{
    delegate int Compare<T>(T a, T b);

    class program
    {
        static void BubbleSort<T>(T[] DataSet, Compare<T> comparer)
        {
            for (int i = 0; i < DataSet.Length; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        T temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, delegate (int a, int b)
            {
                return a.CompareTo(b);
            });

            foreach (var item in array)
            {
                Console.WriteLine($"{item}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorting descending...");
            BubbleSort(array, delegate (int a, int b)
            {
                return a.CompareTo(b)* -1;
            });

            foreach (var item in array)
            {
                Console.WriteLine($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
