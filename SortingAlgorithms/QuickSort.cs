using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public static void Sort(int[] arr, int start, int end)
        {
            if (start >= end)
                return;           
            int pIndex = partition(arr, start, end);
            Sort(arr, start, pIndex-1);
            Sort(arr, pIndex + 1, end);
        }

        public static int partition(int[] arr, int start, int end)
        {
            //random pivot
            int randomPIndex = new Random().Next(start, end);
            int temp3 = arr[end];
            arr[end] = arr[randomPIndex];
            arr[randomPIndex] = temp3;

            int pivot = arr[end];
            int pIndex = start;
            for(int i = start; i < end; i++)
            {
                if(arr[i] <= pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex++;
                }
            }
            int temp1 = pivot;
            arr[end] = arr[pIndex];
            arr[pIndex] = temp1;
            return pIndex;
        }
    }
}
