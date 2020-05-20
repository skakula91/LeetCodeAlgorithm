using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //****1. Is string a palindrome ****//
            //string s = "A man, a plan, a canal: Panama";
            //bool isPalindrome = new IsPalindrome().IsPalindromeStr(s);
            //Console.WriteLine(isPalindrome);

            //****2. Substring KMP ****//
            string s = "kdsgwadsgt";
            string pattern = "dsgwadsgt";
            bool isSubstring = new SubstringMatch_KMP().SubstringIndex(s, pattern);
            Console.WriteLine(isSubstring);
            Console.ReadKey();
        }
    }
}
