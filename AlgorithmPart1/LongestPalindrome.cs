using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public static class LongestPalindrome
    {
        //Given a string s, find the longest palindromic substring in s.You may assume that the maximum length of s is 1000.
        //Example 1:
        //Input: "babad"
        //Output: "bab"
        //Note: "aba" is also a valid answer.

        //Example 2:
        //        Input: "cbbd"
        //Output: "bb"
        public static string Palindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length <= 1) return s;
            int longestSubstr = 0;

            int start = 0;
            int end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = 0;
                int len2 = 0;

                len1 = PalindromeLength(s, i, i + 1);
                len2 = PalindromeLength(s, i, i);

                int len = Math.Max(len1, len2);
                if (len > end - start && len > longestSubstr)
                {
                    longestSubstr = len;
                    start = i - (len - 1) / 2;
                    end = len;
                }
            }

            return s.Substring(start, end);

        }
        public static int PalindromeLength(string s, int left, int right)
        {
            if (s == null || left > right) return 0;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }
    }
}
