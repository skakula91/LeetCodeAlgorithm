using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class NumberOfPairs
    {
        public int NumSub(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            long count = 0;
            long numberCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    count++;
                    count = count + numberCount;
                    numberCount++;
                }
                else
                {
                    numberCount = 0;
                }
            }
            return Convert.ToInt32(count % 1000000007);
        }
    }

}
