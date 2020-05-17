using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace DynamicProgramming
{
    public class Coinschange
    {
        //DP    
        public long CoinChange(int[] coins, int amount)
        {
            //1D array
            int[] memo = new int[amount+1];
            memo[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                int result = Int32.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    // amount-coins should be greater than zero
                    if (coins[j] <= i && memo[i - coins[j]] != Int32.MaxValue)
                    {
                        //i-coins[j] at every point we deal with the part of amount
                        result = Math.Min(result, 1 + memo[i - coins[j]]);
                    }
                }

                memo[i] = result;
            }

            return (memo[amount] == Int32.MaxValue) ? -1 : memo[amount];
        }

        //Recursion
        //public  long result = Int32.MaxValue;
        //public long CoinChange(int[] coins, int amount)
        //{
        //     result = Helper(coins, amount);
        //    return (result >= Int32.MaxValue) ? -1 : (int) result;
        //}

        //public long Helper(int[] coins, int amount)
        //{
        //    if (amount == 0)
        //        return 0;

        //    if(amount < 0)
        //        return Int32.MaxValue;

        //    for (int i = 0; i < coins.Length; i++)
        //    {
        //        result = Math.Min(result, 1 + Helper(coins, amount - coins[i]));
        //    }

        //    return result;
        //}
    }

}


