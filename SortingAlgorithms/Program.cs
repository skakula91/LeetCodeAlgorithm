﻿using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {        
            int[] array = { -1, 0, 1, 2, -1, -4 };
            //****1. Bubble Sort ****//
            // Time complexity : O(n^2)
            // var sortedArray = BubbleSort.Sort(array);

            //****2. Insertion sort ****//
            // Time complexity : O(n^2)
            //var sortedArray = InsertionSort.Sort(array);

            //****3. Merge sort ****//
            // Time complexity : O(nlogn)
            MergeSort.Sort(array, 0, array.Length -1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }
    }
}