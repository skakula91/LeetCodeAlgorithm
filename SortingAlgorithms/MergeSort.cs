using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static int[] Sort(int[] arr)
        {
            if (arr.Length <=1)
            {
                return arr;
            }
         
           int[] res = Merge(arr, 0, arr.Length -1);
           return res;
        }

        public static int[] Merge(int[] arr, int left, int right)
        {
            List<int> res = new List<int>();
            if (left >= right)
            {
                res.Add(arr[left]);
                return res.ToArray();
            }
            int mid = (left + right) / 2;

            int[] leftArray = Merge(arr, left, mid);
            int[] rightArray = Merge(arr, mid + 1, right);
            int i = 0;
            int j = 0;
           
            while (i < leftArray.Length  && j < rightArray.Length)
            {
                if(leftArray[i] < rightArray[j])
                {
                    res.Add(leftArray[i]);
                    i++;
                }
                else
                {
                    res.Add(rightArray[j]);
                    j++;
                }
            }

            while(i < leftArray.Length)
            {
                res.Add(leftArray[i]);
                i++;
            }
            while (j < rightArray.Length)
            {
                res.Add(rightArray[j]);
                j++;
            }
            return res.ToArray();
        }
    }
}
