using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class FriendCircle
    {
        public int[] comp;
        public int FindCircleNum(int[][] M)
        {
            int components = M.Length;
            comp = new int[M.Length];
            for (int i = 0; i < M.Length; i++)
            {
                comp[i] = i;
            }

            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < M[0].Length; j++)
                {
                    if (M[i][j] == 1)
                    {
                        int rootu = FindRoot(i);
                        int rootv = FindRoot(j);

                        if (rootu != rootv)
                        {
                            comp[rootu] = comp[rootv];
                            components--;
                        }
                    }
                }
            }
            return components;
        }
        public int FindRoot(int n)
        {
            int curr = n;
            while (comp[curr] != curr)
            {
                curr = comp[curr];
            }
            return curr;
        }
    }
}
