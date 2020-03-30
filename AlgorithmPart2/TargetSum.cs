using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class TargetSum
    {
        public static bool isMatch = false;
        public static bool check_if_sum_possible(long[] arr, long k)
        {
            return Helper(arr, k, 0, false);
        }
        private static bool Helper(long[] arr, long sum, int index, bool validSubset)
        {
            if (sum == 0 && validSubset)
            {
                return true;
            }
            if (arr.Length == index)
            {
                return false;
            }
            return Helper(arr, sum - arr[index], index + 1, true) || Helper(arr, sum, index + 1, false);
        }
    }
}
