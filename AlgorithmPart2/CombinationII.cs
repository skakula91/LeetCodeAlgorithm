using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class CombinationII
    {
        public List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
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
                for (int i = index; i < nums.Length; i++)
                {
                    if (i == index || nums[i] != nums[i - 1])
                    {
                        arr.Add(nums[i]);
                        Helper(nums, i + 1, target - nums[i], arr);
                        arr.RemoveAt(arr.Count - 1);
                    }
                }
            }
        }
    }
}
