using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class InsertionSort
    {
        public static int[] Sort(int[] arr)
        {           
            for(int i = 1; i < arr.Length; i++)
            {
               int value = arr[i];
               int hole = i;
                while (hole > 0 && arr[i -1] > value)
                {
                    arr[hole] = arr[hole - 1];
                    hole--;
                }
                arr[hole] = value;
            }
            return arr;
        }
    }
}
