using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class HammingDistance
    {
        public int Distance(int x, int y)
        {
            int result = 0;
            while(x > 0 || y > 0)
            {
                result = result + ((x % 2) ^ (y % 2));
                x >>= 1;
                y >>= 1;
            }
            return result;
        }
    }
}
