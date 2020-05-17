using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DynamicProgramming
{
    public class RodPrice
    {
        public long MaxPrice(int[] prices, int rodLength)
        {
            if (rodLength == 0)
                return 0;

            int[] dp = new int[rodLength+1];
            dp[0] = 0;

            for (int i = 1; i <= rodLength; i++)
            {
                int result = -1;
                for (int cuts = 0; cuts <= i; cuts++)
                {
                    if (i - cuts >= 0)
                    {
                        result = Math.Max(result, dp[i - cuts] + prices[cuts]);
                    }
                }

                dp[i] = result;
            }
            GreedyDFS(dp,dp[rodLength],new List<int>(),prices, rodLength);
            return dp[rodLength];
        }

        //Greedy DFS to calculate path
        public  List<int> result = new List<int>();
        public void GreedyDFS(int[] dp, int target, List<int> path, int[] prices, int rodLength)
        {
            if (target == 0)
            {
                result = new List<int>(path);
                return;
            }

            if (target < 0)
            {
                return;
            }

            for (int i = 1; i <= rodLength; i++)
            {
                if (dp[rodLength - i] == target - prices[i])
                {
                    path.Add(i);
                    GreedyDFS(dp, target - prices[i], path, prices,rodLength-i);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}
