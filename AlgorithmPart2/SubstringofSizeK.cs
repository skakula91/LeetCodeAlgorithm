using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class SubstringofSizeK
    {
        public List<string> Solve(string s, int k)
        {
            int left = 0;
            int right = 0;
            int count = 0;
            Dictionary<char,int> dict = new Dictionary<char, int>();
            List<string> result = new List<string>();
            while (right < s.Length)
            {
                if (!dict.ContainsKey(s[right]))
                {
                    dict.Add(s[right],0);
                }

                dict[s[right]]++;
                count++;

                while (count >= k)
                {
                    if(count == k && dict.Count == k-1)
                    {
                        var temp = s.Substring(left,right-left+1);
                        result.Add(temp);
                    }

                    dict[s[left]]--;
                    if (dict[s[left]] == 0)
                    {
                        dict.Remove(s[left]);
                    }
                    count--;
                    left++;
                }

                right++;
            }

            return result;
        }
    }
}
