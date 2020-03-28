using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class Subsets
    {
        List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> SubsetsList(int[] nums)
        {
            Helper(nums, 0, new List<int>());
            return result;
        }
        private void Helper(int[] nums, int index, List<int> slate)
        {
            if (nums.Length == index)
            {
                result.Add(new List<int>(slate));
                return;
            }
            else
            {
                Helper(nums, index + 1, slate);
                slate.Add(nums[index]);
                Helper(nums, index + 1, slate);
                slate.RemoveAt(slate.Count - 1);
            }
        }
    }
}
