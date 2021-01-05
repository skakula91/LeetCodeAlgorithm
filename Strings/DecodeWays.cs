using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class DecodeWays
    {
        public int NumDecodings(string s)
        {
            return DFS(s, 0);
        }

        public int DFS(string s, int index)
        {
            if (s.Length == index)
            {
                return 1;
            }

            //if (memo.ContainsKey(index))
            //    return memo[index];

            if (s[index] == '0')
                return 0;

            int way1 = DFS(s, index + 1);

            int way2 = 0;
            if (index + 2 <= s.Length && Int32.Parse(s.Substring(index, 2)) <= 26)
            {
                way2 = DFS(s, index + 2);
            }
            // memo[index] = way1 + way2;
            return way1 + way2;
        }
    }
}
