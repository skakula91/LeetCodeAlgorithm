using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    //Given a string, find the length of the longest substring without repeating characters.
    //Example 1:
    //Input: "abcabcbb"
    //Output: 3 
    //Explanation: The answer is "abc", with the length of 3. 

    //Example 2:
    //        Input: "bbbbb"
    //Output: 1
    //Explanation: The answer is "b", with the length of 1.

    //Example 3:
    //    Input: "pwwkew"
    //Output: 3
    //Explanation: The answer is "wke", with the length of 3. 
    //             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

    public static class LengthOfLongestSubstring
    {
        public static int LongestSubstring(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int start = 0;
            int longestCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    start = Math.Max(start, dict[s[i]] + 1);
                    dict[s[i]] = i;
                }
                else
                {
                    dict.Add(s[i], i);
                }
                longestCount = Math.Max(longestCount, i - start + 1);

            }
            return longestCount;
        }
    }
}
