using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class CountingSubsets
    {
        public List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Helper(candidates, 0, target, new List<int>());
            return result;
        }
        private void Helper(int[] nums, int index, int target, List<int> arr)
        {
            if (target == 0)
            {
                result.Add(new List<int>(arr));
                return;
            }
            if (target < 0 || nums.Length == index)
            {
                return;
            }
            else
            {
                for (int i = index; i < nums.Length; ++i)
                {
                    arr.Add(nums[i]);
                    Helper(nums, i, target - nums[i], arr);
                    arr.RemoveAt(arr.Count - 1);
                }
            }
        }
    }
}
