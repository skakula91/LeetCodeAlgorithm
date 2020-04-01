using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class ValidParanthesis
    {
        public int LongestValidParentheses(string s)
        {
            int count = 0;
            int MaxCount = 0;
            int ob = 0;
            int cb = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (cb > ob)
                {
                    MaxCount = Math.Max(MaxCount, count - 1);
                    count = 0;
                    ob = 0;
                    cb = 0;
                }
                if (ob > s.Length / 2 )
                {
                    MaxCount = Math.Max(MaxCount, count);
                    count = 0;
                    ob = 0;
                    cb = 0;
                }
                if (s[i] == '(')
                {
                    ob = ob + 1;
                    count = count + 1;
                }
                if (s[i] == ')')
                {
                    cb = cb + 1;
                    count = count + 1;
                }
                if(i == s.Length - 1)
                {
                    MaxCount = Math.Max(MaxCount, count);
                }
            }
            return MaxCount;
        }
    }
}
