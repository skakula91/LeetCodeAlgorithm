using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AlgorithmPart2
{
    public class TopKClosestpoints
    {
        public int[][] KClosest(int[][] points, int K)
        {
            SortedDictionary<int, List<int[]>> dict = new SortedDictionary<int, List<int[]>>();
            foreach (var point in points)
            {
                int result = 0;
                result = point[0] * point[0] + point[1] * point[1];
                if (!dict.ContainsKey(result))
                {
                    dict.Add(result, new List<int[]>{point});
                }
                else
                {
                    dict[result].Add(point);
                }
            }

            List<int[]> closetpoints = new List<int[]>();
            for (int i = 0; i < K; i++)
            {
                if (dict.Count > i)
                {
                    var item = dict.ElementAt(i).Value;
                    closetpoints.AddRange(item);
                }
            }
            
            return closetpoints.Take(K).ToArray();
        }
    }
}
