using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart1
{
    public class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> result = new List<int[]>();
            intervals = intervals.OrderBy(x => x[0]).ToArray();

            int[] curr = intervals[0];
            result.Add(curr);
            foreach (var interval in intervals)
            {
                if (curr[1] >= interval[0])
                {
                    curr[1] = Math.Max(curr[1], interval[1]);
                }
                else
                {
                    curr = interval;
                    result.Add(curr);
                }
            }

            return result.ToArray();
        }
    }
}
