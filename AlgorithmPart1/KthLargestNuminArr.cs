using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class KthLargestNuminArr
    {
        public int FindKthLargest(int[] nums, int k)
        {
            if (nums.Length == 0)
                return 0;
            return QuickSort(nums, 0, nums.Length-1, k);
        }

        // This is Quickselect Algorithm
        public int QuickSort(int[] arr, int start, int end, int index)
        {
            if (start == end)
                return arr[start];

            int pindex = FindPartitionIndex(arr, start, end);
            if (arr.Length - pindex == index)
                return arr[pindex];
            else if (arr.Length - pindex < index)
                return QuickSort(arr, start, pindex - 1, index);
            else 
                return QuickSort(arr, pindex +1, end, index);

        }

        public int FindPartitionIndex(int[] arr, int start, int end)
        {
            int RandomPivot = new Random().Next(start, end);

            int temp3 = arr[RandomPivot];
            arr[RandomPivot] = arr[end];
            arr[end] = temp3;

            int pivot = arr[end];
            int pindex = start;
            for (int i = start; i < end; i++)
            {
                if (arr[i] < pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[pindex];
                    arr[pindex] = temp;
                    pindex++;
                }
            }

            int temp1 = arr[pindex];
            arr[pindex] = arr[end];
            arr[end] = temp1;
            return pindex;
        }
    }
}
