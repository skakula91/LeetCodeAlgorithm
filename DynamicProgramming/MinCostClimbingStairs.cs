using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProgramming
{
    public class MinCostClimbingStairs
    {
        public int MinCostClimbingStairsSum(int[] cost)
        {
             Array.Resize(ref cost,cost.Length+1);
            int[] memo = new int[cost.Length+1];

            // don't step on the first step yet
            memo[0] = 0;
            memo[1] = cost[0];

            for (int i =2; i <= cost.Length; i++)
            {
                memo[i] = cost[i-1] + Math.Min(memo[i - 1], memo[i - 2]);
            }

            return memo[memo.Length-1];
        }
    }
}
