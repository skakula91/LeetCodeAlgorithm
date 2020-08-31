using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class StreamChecker
    {
        private TrieStruct root;
        private List<char> characters = new List<char>();
        public StreamChecker(string[] words)
        {
            root = new TrieStruct();
            foreach(var word in words)
            {
                var currNode = root;
                for (int i = word.Length-1; i >= 0; i--)
                {         
                    var index = word[i] - 'a';
                    if(currNode.Node[index] == null)
                    {
                        currNode.Node[index] = new TrieStruct();
                    }
                    currNode = currNode.Node[index];
                
                }
                currNode.isEndWord = true;
            }
        }
        public bool search(List<char> s)
        {
            var curNode = root;
            for (int i = s.Count-1; i >= 0 ; i--)
            {
                var index = s[i] - 'a';
                if (curNode.Node[index] == null ) return false;

                curNode = curNode.Node[index];
                if (curNode.isEndWord)
                    return true;
            }

            return false;
        }

        public bool query(char letter)
        {
            characters.Add(letter);
            return search(characters);
        }
    }

    public class TrieStruct
    {
        public TrieStruct[] Node;
        public bool isEndWord;

        public TrieStruct()
        {
            Node = new TrieStruct[26];
            isEndWord = false;
        }
    }
}
