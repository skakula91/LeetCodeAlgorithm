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
            //string s = "aaaab";
            //string pattern = "aab";
            //bool isSubstring = new SubstringMatch_KMP().SubstringIndex(s, pattern);
            //Console.WriteLine(isSubstring);

            //****3. Trie ****//
            Trie trie = new Trie();
            trie.Insert("apple");
            trie.Insert("bat");
            Console.WriteLine(trie.Search("apple"));
            Console.WriteLine(trie.Search("app"));
            Console.WriteLine(trie.StartsWith("app")); // returns true
            trie.Insert("app");
            Console.WriteLine(trie.Search("app"));
            Console.ReadKey();
        }
    }
}
