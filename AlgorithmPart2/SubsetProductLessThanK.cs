using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart2
{
    public class SubsetProductLessThanK
    {
        public int result = 0;
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            DFS(nums.ToList(), k, 1,0);
            return result;
        }
        public void DFS(List<int> nums, int k, int slate, int index)
        {
            if (slate < k)
            {
                result++;
            }
            for (int i = index; i < nums.Count; i++)
            {
                DFS(nums, k, slate * nums[i],i+1);
            }
        }
    }
}
