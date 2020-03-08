using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart1
{
    class ThreeSum
    {
        public static IList<IList<int>> ThreeSums(int[] nums)
        {

            IList<IList<int>> threeSum = new List<IList<int>>();
            if (nums.Length == 0)
                return null;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = dict[nums[i]] + 1;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    int num = (nums[i] + nums[j]) * -1;
                    int index = 0;
                    dict.TryGetValue(num, out index);
                    List<int> ls = new List<int>();
                    if (index > 1 && i != j)
                    {
                        //if()
                        dict[nums[i]] = dict[nums[i]] - 1;
                        dict[nums[j]] = dict[nums[j]] - 1;
                        ls.Add(nums[i]);
                        ls.Add(nums[j]);
                        ls.Add(num);
                    }
                    if (ls.Count > 0)
                        threeSum.Add(ls);

                }
            }

            return threeSum;
        }
    }
}
