using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //****1. Bubble Sort ****//
            // Time complexity : O(n^2)
            int[] array = { -1, 0, 1, 2, -1, -4 };
            var sortedArray = BubbleSort.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
            Console.Read();
        }
    }
}
