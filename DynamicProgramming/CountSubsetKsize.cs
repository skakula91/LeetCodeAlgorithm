using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class CountSubsetKsize
    {
        // node = node on the row above + node on the row beside above
        //c(n,k) = c(n-1,k) + c(n-1,k-1)
        public int Count(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;

            int[,] memo = new int[n+1,k+1];
            for(int row =0; row <= n; row++)
            {
                memo[row,0] = 1;
            }
            for (int col = 0; col <= k; col++)
            {
                memo[col, col] = 1;
            }

            for(int i = 2; i <= n; i++)
            {
                // n is > k.. k greater than n doesn't make sence for nck computation
                for(int j = 1; j<= Math.Min(i,k); j++)
                {
                    memo[i, j] = memo[i - 1, j] + memo[i - 1, j - 1];
                }

            }
            return memo[n, k];
        }
    }
}
