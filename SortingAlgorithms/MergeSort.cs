using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
           int middle = (left + right) / 2;
           Sort(arr, left, middle);
           Sort(arr, middle + 1, right);
           Merge(arr, left, right);

        }

        public static void Merge(int[] arr,int left, int right)
        {
            int leftStart = left;
            int mid = (right + left) / 2;
            int rightStart = mid +1;
            int k = leftStart;
            int[] temp = new int[arr.Length];
           
            while (leftStart <= mid  && rightStart <= right)
            {
                if(arr[leftStart] < arr[rightStart])
                {
                    temp[k] = arr[leftStart];
                    leftStart++;
                    k++;
                }
                else
                {
                    temp[k] = arr[rightStart];
                    rightStart++;
                    k++;
                }
            }

            while(leftStart <= mid)
            {
                temp[k] = arr[leftStart];
                leftStart++;
                k++;
            }
            while (rightStart <= right)
            {
                temp[k] = arr[rightStart];
                rightStart++;
                k++;
            }

            for(int x = left; x <= right; x++)
            {
                arr[x] = temp[x];
            }
        }
    }
}
