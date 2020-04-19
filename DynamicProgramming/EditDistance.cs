using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DynamicProgramming
{
    public class EditDistance
    {
        public int Distance(string s1, string s2)
        {
            int[,] dp = new int[s1.Length+1, s2.Length+1];

            for (int i = 0; i <= s1.Length; i++)
            {
                dp[i, s2.Length] = s1.Length - i;
            }
            for (int j = 0; j <= s2.Length; j++)
            {
                dp[s1.Length, j] = s2.Length - j;
            }

            for (int i = s1.Length-1; i >= 0; i--)
            {
                for (int j = s2.Length - 1; j >= 0; j--)
                {
                    if (s1[i] != s2[j])
                    {
                        dp[i, j] = 1+ Min3(dp[i + 1, j], dp[i, j + 1], dp[i + 1, j + 1]);
                    }

                    if (s1[i] == s2[j])
                    {
                        dp[i, j] = dp[i + 1, j + 1];
                    }
                }
            }

            return dp[0,0];
        }

        private int Min3(int val1, int val2, int val3)
        {
            var temp = Math.Min(val1, val2);
            return Math.Min(temp, val3);
        }
    }
}
