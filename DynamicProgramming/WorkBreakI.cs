using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class WorkBreakI
    {
        public bool WordBreakDP(string s, IList<string> wordDict)
        {
            var hashSet = new HashSet<string>(wordDict);
            int len = s.Length;
            bool[] f = new bool[len + 1];
            f[0] = true;
            for (int i = 0; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    if (f[j] && hashSet.Contains(s.Substring(j, i - j)))
                    {
                        f[i] = true;
                        break;
                    }
            }
            return f[len];
        }
         
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var hashSet = new HashSet<string>(wordDict);
            return Helper(s, hashSet, new int[s.Length], 0);
        }
        public bool Helper(string s, HashSet<string> hashSet, int[] memo, int startIndex)
        {
            if (startIndex == s.Length)
                return true;
            if (memo[startIndex] != 0)
                return memo[startIndex] == 1 ? true : false;

            for (int i = startIndex + 1; i <= s.Length; i++)
            {
                string substr = s.Substring(startIndex, i - startIndex);
                if (hashSet.Contains(substr) && Helper(s, hashSet, memo, i))
                {
                    memo[startIndex] = 1;
                    return true;
                }
            }
            memo[startIndex] = 2;
            return false;
        }
    }
}
