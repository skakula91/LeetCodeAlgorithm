using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class MinimumDiffcultyofJobSchedule
    {
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            if (jobDifficulty.Length < d)
            {
                return -1;
            }

            int n = jobDifficulty.Length;
            if (jobDifficulty.Length < d)
                return -1;

            int[,] dp = new int[d + 1, n + 1];


            for (int i = 0; i <= d; i++)
            {
                dp[i, n] = -1;
            }

            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = -1;
            }

            // if day == 1
            for (int j = 0; j < n; j++)
            {
                int temp = Int32.MinValue;
                for (int k = j; k < jobDifficulty.Length; k++)
                {
                    temp = Math.Max(temp, jobDifficulty[j]);
                }
                dp[1, j] = temp;
            }

            // dp[i] =  Math.Min(result, dp[d-1, j+1]+maxDiffcultonIthDay);  

            // day index
            for (int i = 1; i <= d; i++)
            {
                int result = Int32.MaxValue;
                int maxDiffcultonIthDay = Int32.MinValue;
                // jd index
                for (int j = n - 1; j >= 0; j--)
                {
                    maxDiffcultonIthDay = Math.Max(maxDiffcultonIthDay, jobDifficulty[j]);
                    for (int k = j; k <= n - 1; k++)
                    {
                        int temp = dp[i - 1, k + 1];
                        if (temp != -1)
                        {
                            result = Math.Min(result, temp + maxDiffcultonIthDay);
                        }
                    }
                    dp[i, j] = result == Int32.MaxValue ? -1 : result;
                }
            }



            return dp[d, 0];

            // return DFS(jobDifficulty, d, 0);
        }

        public int DFS(int[] diffculty, int d, int index)
        {
            int result = Int32.MaxValue;
            if (index == diffculty.Length - 1)
            {
                if (d == 1)
                {
                    return diffculty[index];
                }

                return -1;
            }

            if (d > diffculty.Length - index)
            {
                return -1;
            }
            if (d == 1)
            {
                int max = Int32.MinValue;
                for (int i = index; i < diffculty.Length; i++)
                {
                    max = Math.Max(max, diffculty[i]);
                }
                return max;
            }
           
            int MaxdiffOnIthDay = 0;
            for (int i = index; i < diffculty.Length-1; i++)
            {
                MaxdiffOnIthDay = Math.Max(MaxdiffOnIthDay, diffculty[i]);
                int temp = DFS(diffculty, d - 1, i + 1);
                if (temp != -1)
                {
                    result = Math.Min(result, MaxdiffOnIthDay+temp);
                }

            }

            return result;
        }
    }
}
