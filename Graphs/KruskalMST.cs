using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class KruskalMST
    {
        public int[] parent;

        public int[][] MSTKruskal(int n, int[][] connections)
        {
            List<int[]> result = new List<int[]>();
            int components = n;
            parent = new int[n];
            for(int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            connections = connections.OrderBy(x => x[2]).ToArray();

            foreach(var conn in connections)
            {
                int u = conn[0];
                int v = conn[1];

                int rootu = FindParent(u);
                int rootv = FindParent(v);

                if(rootu != rootv)
                {
                    result.Add(conn);
                    parent[rootu] = rootv;
                }
            }

            return result.ToArray();
        }
        public int FindParent(int n)
        {
            int curr = n;
            while(curr != parent[curr])
            {
                curr = parent[curr];
            }
            return curr;
        }
    }
}
