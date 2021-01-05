using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class NumberofIslandsII
    {
        public int[] parent;
        public IList<int> NumIslands2(int m, int n, int[][] positions)
        {
            parent = new int[m * n];
            int[,] islands = new int[m, n];
            int[][] directions = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            for (int i = 0; i < parent.Length; i++)
            {
                parent[i] = -1;
            }
            List<int> result = new List<int>();
            int count = 0;
            foreach (var p in positions)
            {
                islands[p[0], p[1]] = 1;
                int index = n * p[0] + p[1];
                if (parent[index] != -1)
                {
                    result.Add(count);
                    continue;
                }
                else
                {
                    parent[index] = index;
                    count++;
                    foreach (var dir in directions)
                    {
                        int tempx = dir[0] + p[0];
                        int tempy = dir[1] + p[1];
                        int idx = n * tempx + tempy;
                        if (tempx >= 0 && tempx < m && tempy >= 0 && tempy < n && islands[tempx, tempy] == 1)
                        {
                            int parNeigh = FindParent(idx);
                            int parIndex = FindParent(index);

                            if (parNeigh != parIndex)
                            {
                                parent[parNeigh] = parent[parIndex];
                                count--;
                            }
                        }
                    }
                }
                result.Add(count);
            }
            return result;
        }



        public int FindParent(int num)
        {
            int curr = num;

            while (curr != parent[curr])
            {
                curr = parent[curr];
            }
            return curr;
        }
    }
}
