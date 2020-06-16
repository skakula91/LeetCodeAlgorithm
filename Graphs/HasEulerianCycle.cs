using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class HasEulerianCycle
    {
        public bool Components(int n, int[][] edges)
        {
            var adjacencyMap = BuildAdjMap(n, edges);
            int oddVertex = 0;

            foreach(var map in adjacencyMap)
            {
                if (map.Value.Count % 2 == 1)
                    oddVertex++;
            }
            return oddVertex == 0 ? true : false;
        }

        public Dictionary<int, List<int>> BuildAdjMap(int n, int[][] edges)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                dict.Add(i, new List<int>());
            }
            foreach(var edge in edges)
            {
                dict[edge[0]].Add(edge[1]);
                dict[edge[1]].Add(edge[0]);
            }
            return dict;
        }
    }
}
