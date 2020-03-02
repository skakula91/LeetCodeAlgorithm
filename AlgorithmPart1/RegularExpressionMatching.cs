using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    // Given an input string (s) and a pattern(p), implement regular expression matching with 
    //support for '.' and '*'.
    //'.' Matches any single character.
    //'*' Matches zero or more of the preceding element.

    //    The matching should cover the entire input string (not partial).

    //Note:

    //s could be empty and contains only lowercase letters a-z.
    //p could be empty and contains only lowercase letters a-z, and characters like.or*.

    //Example 1:
    // Input:
    //s = "aa"
    //p = "a"
    //Output: false
    //Explanation: "a" does not match the entire string "aa".

    //Example 3:
    //  Input:
    //s = "ab"
    //p = ".*"
    //Output: true
    //Explanation: ".*" means "zero or more (*) of any character (.)".
    public static class RegularExpressionMatching
    {
        public static bool IsMatch(string s, string p)
        {
            if (string.IsNullOrWhiteSpace(p)) return string.IsNullOrWhiteSpace(s);
            bool first_match = (!string.IsNullOrWhiteSpace(s) && ((s[0] == p[0]) || p[0] == '.'));  

            if(p.Length >= 2  && p[1] == '*')
            {
                return (IsMatch(s, p.Substring(2)) ||
                    (first_match && IsMatch(s.Substring(1), p)));
            }
            else
            {
                return first_match && IsMatch(s.Substring(1), p.Substring(1));
            }    
        }
    }
}
