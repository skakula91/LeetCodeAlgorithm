using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class SubstringMatching
    {
        public static List<string> Substring()
        {
            var arr = new string[] { "cats", "cars", "airplane", "apple" };
            Trie t = new Trie();
            foreach (string word in arr)
            {
                t.Insert(word);
            }

            var result = t.GetElements("ca");
            return result;
        }
    }

    public class Trie
    {
        public TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                var index = word[i] - 'a';
                if (curr.Node[index] == null)
                {
                    curr.Node[index] = new TrieNode();
                }
                curr = curr.Node[index];
                if (i == word.Length - 1)
                    curr.IsEndofWord = true;
            }
        }

        public List<string> GetElements(string str)
        {
            TrieNode curr = root;
            List<string> result = new List<string>();
            List<char> slate = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                var index = str[i] - 'a';
                if (curr.Node[index] == null)
                {
                    return result;
                }
                curr = curr.Node[index];
                slate.Add(str[i]);
            }
            Search(curr, result, slate);
            return result;
        }

        public void Search(TrieNode root, List<string> result, List<char> slate)
        {
            if (root == null)
                return;
            if (root.IsEndofWord)
            {
                result.Add(new string(slate.ToArray()));
            }
            for (char i = 'a'; i < 'z'; i++)
            {
                int index = i - 'a';
                 slate.Add(i);
                 Search(root.Node[index], result, slate);
                 slate.RemoveAt(slate.Count - 1);
            }
        }


        public class TrieNode
        {
            public TrieNode[] Node;
            public bool IsEndofWord;

            public TrieNode()
            {
                Node = new TrieNode[26];
                IsEndofWord = false;
            }
        }
    }
}



