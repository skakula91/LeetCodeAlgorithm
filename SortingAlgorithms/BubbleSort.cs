using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {
            bool isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted)
                    break;
            }
            return arr;
        }
    }
}
