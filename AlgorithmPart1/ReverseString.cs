using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class ReverseString
    {
        public static string Reverse(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
                return "";
            int i = 0;
            var charArr = s.ToCharArray();
            k--;
            while(i < k)
            {
                char temp = charArr[i];
                charArr[i] = charArr[k];
                charArr[k] = temp;
                i++; k--;
            }
            return new string(charArr);
        }
    }
}
