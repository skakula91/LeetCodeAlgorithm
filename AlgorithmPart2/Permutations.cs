using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPart2
{
    public class Permutations
    {
        public static  List<IList<int>> result = new List<IList<int>>();
        public static IList<IList<int>> Permute(int[] nums)
        {
            Helper(new List<int>(), nums.ToList());
            return result;
        }
        public static void Helper(List<int> slate, List<int> nums)
        {
            if (nums.Count == 0)
            {
                result.Add(slate);
                
            }
            else
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    List<int> temp = new List<int>(nums);
                    temp.RemoveAt(i);

                    var item = new List<int>(slate);
                    item.Add(nums[i]);               
                    Helper(item, temp);
                }
            }
        }
    }
}
