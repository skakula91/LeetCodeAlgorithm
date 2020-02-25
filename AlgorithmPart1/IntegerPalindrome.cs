using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public static class IntegerPalindrome
    {
        // Determine whether an integer is a palindrome.An integer is a palindrome when it reads the 
        // same backward as forward.
        //Example 1:
        // Input: 121
        //Output: true

        //Example 2:
        // Input: -121
        //Output: false
        //Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
        public static bool IsPalindrome(int x)
        {
            string s = x.ToString();
            int strLength = s.Length;
            bool isPalindrome = false;
            for (int i = 0; i <= strLength / 2; i++)
            {
                if (!(s[i] == s[strLength - i - 1]))
                {
                    isPalindrome = false;
                    break;
                }
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
