using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class BitWiseComplement
    {
        public int BitwiseComplement(int N)
        {
            int temp = 1;
            while (N > temp)
            {
                temp = temp << 1 | 1;
            }
            return N ^ temp;
        }
    }
}
