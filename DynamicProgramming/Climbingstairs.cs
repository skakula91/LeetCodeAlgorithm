using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class Climbingstairs
    {
        public int ClimbStairs(int n)
        {
            if (n == 1 || n == 2)
                return n;
            int[] uniqueWays = new int[n];
            uniqueWays[0] = 1;
            uniqueWays[1] = 2;
           
            for(int i = 2; i < n; i++)
            {
                uniqueWays[i] = uniqueWays[i - 1] + uniqueWays[i - 2];
            }
            return uniqueWays[n-1];
        }
    }
}
