using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class MaxNumOfSubstrings
    {
        public IList<string> MaxNumOfSubstringsI(string s)
        {
            List<string> result = new List<string>();
            int[] left = new int[26];
            int[] right = new int[26];
            for (int i = 0; i < 26; i++)
            {
                left[i] = Int32.MaxValue;
            }

            for (int i = 0; i < s.Length; i++)
            {
                left[s[i] - 'a'] = Math.Min(i, left[s[i] - 'a']);
                right[s[i] - 'a'] = Math.Max(i, right[s[i] - 'a']);
            }

            int r = Int32.MaxValue;
            result.Add(" ");
            for (int i = 0; i < s.Length; i++)
            {
                if (i == left[s[i] - 'a'])
                {
                    int newright = checkIsValidString(s, i, left, right);
                    if (newright != -1)
                    {
                        if (i > r)
                        {
                            result.Add(" ");
                        }
                        r = newright;
                        result[result.Count - 1] = s.Substring(i, r - i + 1);
                    }
                }
            }
            return result;
        }

        public int checkIsValidString(string s, int i, int[] left, int[] right)
        {
            int r = right[s[i] - 'a'];

            for (int j = i; j <= r; j++)
            {
                if (left[s[j] - 'a'] < i)
                    return -1;

                r = Math.Max(r, right[s[j] - 'a']);
            }

            return r;
        }
    }
}
