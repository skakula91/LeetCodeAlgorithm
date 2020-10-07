//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Strings
//{
//    public class Trie
//    {
//        public TrieNode root;
//        /** Initialize your data structure here. */
//        public Trie()
//        {
//            root = new TrieNode();
//        }

//        /** Inserts a word into the trie. */
//        public void Insert(string word)
//        {
//            int wordlen = word.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < wordlen; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.Node[index] == null)
//                {
//                    curNode.Node[index] = new TrieNode();
//                }

//                curNode = curNode.Node[index];
//                if (i == wordlen - 1)
//                    curNode.IsEndWord = true;
//            }
//        }

//        /** Returns if the word is in the trie. */
//        public bool Search(string word)
//        {
//            int wordlen = word.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < wordlen; i++)
//            {
//                var index = word[i] - 'a';
//                if (curNode.Node[index] == null)
//                {
//                    return false;
//                }
//                curNode = curNode.Node[index];
//            }

//            return curNode.IsEndWord;
//        }

//        /** Returns if there is any word in the trie that starts with the given prefix. */
//        public bool StartsWith(string prefix)
//        {
//            int prefixlen = prefix.Length;
//            TrieNode curNode = root;
//            for (int i = 0; i < prefixlen; i++)
//            {
//                var index = prefix[i] - 'a';
//                if (curNode.Node[index] == null)
//                {
//                    return false;
//                }
//                curNode = curNode.Node[index];
//            }

//            return true;
//        }
//    }

//    public class TrieNode
//    {
//        public TrieNode[] Node;
//        public bool IsEndWord;

//        public TrieNode()
//        {
//            Node = new TrieNode[26];
//            IsEndWord = false;
//        }
//    }
//}
