using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class LargestComponenet
    {
        public int[] parent;
        public int LargestComponentSize(int[] A)
        {
            int components = 0;
            parent = new int[1000001];
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 2; j <= Math.Sqrt(A[i]); j++)
                {
                    if (A[i] % j == 0)
                    {
                        Union(j, A[i]);
                        Union(A[i], A[i] / j);
                    }
                }
            }
            Dictionary<int, int> uniquep = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                int xp = Find(A[i]);
                if (uniquep.ContainsKey(xp))
                {
                    uniquep[xp] += 1;
                    components = Math.Max(components, uniquep[xp]);
                }
                else
                {
                    uniquep.Add(xp, 1);
                    components = Math.Max(components, 1);
                }
            }
            return components;
        }

        public int Find(int n)
        {
            int curr = n;
            while (parent[curr] != 0)
            {
                curr = parent[curr];
            }
            return curr;
        }

        public void Union(int x, int y)
        {
            int xp = Find(x);
            int yp = Find(y);
            if (xp != yp)
            {
                parent[yp] = xp;
            }
        }
    }
}
