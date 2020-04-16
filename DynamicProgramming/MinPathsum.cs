using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class MinPathsum
    {
        public int Pathsum(int[][] grid)
        {
            int n = grid.Length; // row
            int m = grid[0].Length; //col

            var memo = new int[n, m];

            memo[0,0] = grid[0][0];
            for (int i = 1; i < m; i++)
            {
                memo[0, i] = memo[0, i - 1] + grid[0][i];
            }

            for (int j = 1; j < n; j++)
            {
                memo[j, 0] = memo[j - 1, 0] + grid[j][0];
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    memo[i, j] = grid[i][j] + Math.Min(memo[i - 1, j], memo[i, j - 1]);
                }
            }

            return memo[n-1, m-1];
        }
    }
}
