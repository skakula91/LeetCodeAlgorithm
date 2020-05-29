using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class PalindromePartitioning
    {
        List<IList<string>> Result = new List<IList<string>> ();
        public List<IList<string>> Partition(string s)
        {
            Helper(0, s, new List<string>());
            return Result;
        }

        public void Helper(int i, string s, List<String> slate)
        {
            if(i == s.Length)
            {
                Result.Add(new List<string>(slate));
                return;
            }

            for(int j = i; j < s.Length; j++)
            {
                string currString = s.Substring(i, j - i + 1);
                if (isPalindrome(currString))
                {
                    slate.Add(currString);
                    Helper(j + 1, s, slate);
                    slate.RemoveAt(slate.Count-1);
                }
            }
        }

        private static bool isPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
    }
}
