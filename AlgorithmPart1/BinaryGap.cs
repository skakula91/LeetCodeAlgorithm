using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class BinaryGap
    {
        public static int Gap(int N)
        {
            string binary = Convert.ToString(N, 2);
            int maxGap = 0;
            int count = 0;
            bool startCount = false;
            for (int i = 0; i <= binary.Length - 1; i++)
            {
                if (binary[i] == '1')
                {
                    maxGap = Math.Max(maxGap, count);
                    count = 0;
                    startCount = true;
                }
                if (startCount)
                    count++;
            }
            return maxGap;

        }
    }
}
