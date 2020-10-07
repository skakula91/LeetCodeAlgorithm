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
            //Trie trie = new Trie();
            //trie.Insert("apple");
            //trie.Insert("bat");
            //Console.WriteLine(trie.Search("apple"));
            //Console.WriteLine(trie.Search("app"));
            //Console.WriteLine(trie.StartsWith("app")); // returns true
            //trie.Insert("app");
            //Console.WriteLine(trie.Search("app"));

            //****4. printStringSinusoidally ****//
            //PrintStringSinuosidal.printStringSinusoidally("Google Worked");
            //Console.ReadKey();


            //****4. stream checker ****//
            //StreamChecker streamChecker = new StreamChecker(new string[] { "cd", "f", "kl" }); // init the dictionary.
            //Console.WriteLine(streamChecker.query('a'));          // return false
            //Console.WriteLine(streamChecker.query('b'));          // return false
            //Console.WriteLine(streamChecker.query('c'));          // return false
            //Console.WriteLine(streamChecker.query('d'));          // return true, because 'cd' is in the wordlist
            //Console.WriteLine(streamChecker.query('e'));          // return false
            //Console.WriteLine(streamChecker.query('f'));          // return true, because 'f' is in the wordlist
            //Console.WriteLine(streamChecker.query('g'));          // return false
            //Console.WriteLine(streamChecker.query('h'));          // return false
            //Console.WriteLine(streamChecker.query('i'));          // return false
            //Console.WriteLine(streamChecker.query('j'));          // return false
            //Console.WriteLine(streamChecker.query('k'));          // return false
            //Console.WriteLine(streamChecker.query('l'));          // return true, because 'kl' is in the wordlist

            //****5. Most Common Word ****//
            //var result = new MostCommonWord().MostCommon("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
            //Console.WriteLine(result);

            //****6. Substring Match ****//
            //var result = SubstringMatching.Substring();
            //foreach (var s in result)
            //{
            //    Console.WriteLine(s);
            //}

            //****7. Partition Labels ****//
            //var result = new PartitionLabels().PartitionLabelsI("ababcbacadefegdehijhklij");

            //****8. Maximum Number of Non-Overlapping Substrings ****//
            var result = new MaxNumOfSubstrings().MaxNumOfSubstringsI("abbaccd");
            Console.ReadKey();
        }
    }
}
