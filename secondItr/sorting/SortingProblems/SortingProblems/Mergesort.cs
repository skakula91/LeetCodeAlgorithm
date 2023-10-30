using System;
using System.Collections.Generic;

namespace SortingProblems
{
    public static class SortingProblems
    {
        public static int[] Mergesort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int[] res = Merge(array, 0, array.Length - 1);
            return res;
        }


        public static int[] Merge(int[] array, int left, int right)
        {
            List<int> res = new List<int>();

            if(left >= right)
            {
                res.Add(array[left]);
                return res.ToArray();
            }

            int mid = (left + right) / 2;

            int[] leftarray = Merge(array, left, mid);
            int[] rightarray = Merge(array, mid + 1, right);

            int i = 0;
            int j = 0;

            while(i < leftarray.Length && j < rightarray.Length)
            {
                if(leftarray[i] < rightarray[j])
                {
                    res.Add(leftarray[i]);
                    i++;
                }
                else
                {
                    res.Add(rightarray[j]);
                    j++;
                }

            }

            while (i < leftarray.Length)
            {
                res.Add(leftarray[i]);
                i++;
            }
            while (j < rightarray.Length)
            {
                res.Add(rightarray[j]);
                j++;
            }
            return res.ToArray();
        }
    }
}


// 3 2 1 0
// 3 2    1 0
//3  2   1   0