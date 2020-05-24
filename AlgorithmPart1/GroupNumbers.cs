using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public static class GroupNumbers
    {
        public static int[] solve(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;

            int i = 0;
            for(int j =0; j < arr.Length; j++)
            {
                if(arr[j]%2 == 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                }
            }
            return arr;
        }
    }
}
