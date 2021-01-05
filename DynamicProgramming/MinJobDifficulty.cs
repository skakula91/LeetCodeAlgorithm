using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class MinJobDifficulty
    {
        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            int index = jobDifficulty.Length;
            if (index < d)
            {
                return -1;
            }

            int[,] dp = new int[index + 1, d + 1];

            for (int i = 0; i <= index; i++)
            {
                dp[i, 0] = Int32.MaxValue;
            }

            for (int j = 0; j <= d; j++)
            {
                dp[index, j] = Int32.MaxValue;
            }

            for (int i = 0; i < index; i++)
            {
                int max = Int32.MinValue;
                for (int j = i; j < index; j++)
                {
                    max = Math.Max(jobDifficulty[i], max);
                }
                dp[i, 1] = max;
                max = Int32.MinValue;
            }

            for (int j = 2; j <= d; j++)
            {
                int maxonIthday = Int32.MinValue;
                for (int i = index - 1; i >= 0; i--)
                {
                    int result = Int32.MaxValue;
                    maxonIthday = Math.Max(maxonIthday, jobDifficulty[i]);

                    if (dp[i + 1, j - 1] != Int32.MaxValue)
                    {
                        result = Math.Min(result, dp[i + 1, j - 1] + maxonIthday);
                    }
                    dp[i, j] = result;
                }
            }
            return dp[0, d];
            //return DFS(jobDifficulty, d,0);
        }

        public int DFS(int[] diff, int days, int index)
        {
            if (days == 1)
            {
                var temp = diff[index];
                for (int i = index + 1; i < diff.Length; i++)
                {
                    temp = Math.Max(temp, diff[i]);
                }
                return temp;
            }

            if (index >= diff.Length)
                return -1;

            int result = Int32.MaxValue;
            int maxOnIthDay = Int32.MinValue;
            for (int i = index; i < diff.Length - 1; i++)
            {
                maxOnIthDay = Math.Max(maxOnIthDay, diff[i]);
                int temp = DFS(diff, days - 1, i + 1);
                if (temp != -1)
                {
                    result = Math.Min(result, maxOnIthDay + temp);
                }
            }
            return result == Int32.MaxValue ? -1 : result;
        }
    }
}
