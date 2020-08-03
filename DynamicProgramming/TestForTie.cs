using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class TestForTie
    {
        //Dynamic programming
        public bool IsPossibleDp(int[] weights)
        {
            var totalWeight = 0;
            foreach (var weight in weights)
            {
                totalWeight = totalWeight + weight;
            }

            if (totalWeight % 2 != 0)
                return false;

            bool[,] dp = new bool[weights.Length+1, totalWeight/2 +1];

            for (int i = 0; i < weights.Length + 1; i++)
            {
                dp[i, 0] = true;
            }

            for (int j = 1; j < totalWeight / 2 +1; j++)
            {
                dp[weights.Length, j] = false;
            }

            for (int i = weights.Length - 1; i >= 0; i--)
            {
                bool result = false;;
                for (int j = 1; j < totalWeight / 2 + 1; j++)
                {
                    if (j - weights[i] >= 0)
                    {
                        result = dp[i + 1, j - weights[i]] ;
                    }

                    dp[i, j] = result || dp[i + 1, j];
                }
            }

            return dp[0, totalWeight / 2];
        }



        //Recursion
        public bool IsPossible(int[] weights)
        {
            var totalWeight = 0;
            foreach (var weight in weights)
            {
                totalWeight = totalWeight + weight;
            }

            if (totalWeight % 2 != 0)
                return false;
            bool result = Helper(weights, 0, totalWeight / 2);
            return result;
        }

        public bool Helper(int[] weights, int index, int target)
        {
            if (target == 0)
            {
                return true;
            }
            if (index == weights.Length)
            {
                return false;
            }

            bool result = false;
            if (target >= weights[index])
            {
                result = Helper(weights, index + 1, target - weights[index]);
            }
            return result || Helper(weights, index + 1, target);
        }
    }
}
