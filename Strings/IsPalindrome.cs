using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    public class IsPalindrome
    {
        public bool IsPalindromeStr(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                if(!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if(!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else
                {
                    if(char.ToLower(s[left]) != char.ToLower(s[right]))
                    {
                        return false;
                    }
                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}
