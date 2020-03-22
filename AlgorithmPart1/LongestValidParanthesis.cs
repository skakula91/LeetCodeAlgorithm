using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class LongestValidParanthesis
    {
        public static int LongestValidParentheses(string s)
        {
            Stack<char> stak = new Stack<char>();
            var charArr = s.ToCharArray();
            int longestCount = 0;
            int count = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '(')
                {
                    stak.Push(charArr[i]);
                    count = count + 1;
                }
                else if (stak.Count > 1 && stak.Peek() == ')')
                {
                    stak.Pop();
                    count = count + 1;
                }
                else
                {
                    count = 0;
                }
                longestCount = Math.Max(longestCount, count);

            }

            return longestCount;
        }
    }
}
