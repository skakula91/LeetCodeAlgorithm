using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class CoinChange2
    {
        public int Change(int amount, int[] coins)
        {
            return DFS(amount, coins, 0);
        }

        public int DFS(int amount, int[] coins, int index)
        {
            if (amount == 0)
            {
                return 1;
            }
            if (amount < 0 || index >= coins.Length)
            {
                return 0;
            }

            int result = DFS(amount, coins, index + 1);
            if (amount >= coins[index])
            {
                result += DFS(amount - coins[index], coins, index);
            }
            return result;
        }
    }
}
