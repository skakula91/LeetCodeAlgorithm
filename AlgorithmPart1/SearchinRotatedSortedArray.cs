using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class SearchinRotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {

            int start = 0;
            int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (target == nums[mid])
                    return mid;
                else if (nums[start] <= nums[mid])
                {
                    if (target >= nums[start] && target < nums[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }

            }
            return -1;
        }
    }
}
