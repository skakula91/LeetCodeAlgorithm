using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    // Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //Example:
    // Given nums = [2, 7, 11, 15], target = 9,
    // Because nums[0] + nums[1] = 2 + 7 = 9,
    // return [0, 1].
    public static class TwoSum
    {
        public static int[] Sum(int[] nums, int target)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int index = 0;
                int complement = 0;
                complement = target - nums[i];
                if (pairs.TryGetValue(complement, out index))
                {
                    return new int[] { index, i };
                }

                if (!pairs.ContainsKey(nums[i]))
                {
                    pairs.Add(nums[i], i);
                }
            }
            return null;

        }
    }
}
