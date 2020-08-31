using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart2
{
    public class FindRightInterval
    {
        public int[] FindRight(int[][] intervals)
        {
            Dictionary<int, int> indexdict = new Dictionary<int, int>();

            for (int i = 0; i < intervals.Length; i++)
            {
                indexdict.Add(intervals[i][0], i);
            }

            intervals = intervals.OrderBy(x => x[0]).ToArray();

            int[] result = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                int l = 0;
                int r = intervals.Length;

                while (l < r)
                {
                    var mid = l + (r - l) / 2;
                    if (intervals[mid][0] < intervals[i][1])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        r = mid;
                    }
                }

                if (l == intervals.Length)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = indexdict[intervals[i][0]];
                }
            }

            return result;
        }
    }
}
