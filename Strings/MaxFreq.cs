using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Strings
{
    public class MaxFreq
    {
        public int MaxFreqI(string s, int maxLetters, int minSize, int maxSize)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<char, int> freq = new Dictionary<char, int>();
            int count = 0;
            int left = 0;
            int right = 0;

            while (right < s.Length)
            {
                if (!freq.ContainsKey(s[right]))
                {
                    freq.Add(s[right], 1);
                    right++;
                    count++;
                }
                else
                {
                    freq[s[right]]++;
                    right++;
                }

                if (count > maxLetters)
                {
                    while (count <= maxLetters)
                    {
                        freq[s[left]]--;
                        left++;
                        if (freq[s[left]] == 0)
                        {
                            count--;
                        }
                    }
                }

                if (right - left >= minSize)
                {

                }

            }

            return 0;
        }
    }
}
