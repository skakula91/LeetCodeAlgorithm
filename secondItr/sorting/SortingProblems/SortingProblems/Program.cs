using System;

namespace SortingProblems
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = {0,1,3,2};
            //****1. Merge sort ****//
            //Time complexity : O(nlogn)
            array = SortingProblems.Mergesort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
