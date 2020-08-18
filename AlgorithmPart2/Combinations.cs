using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace AlgorithmPart2
{
    public class Combinations
    {
        public List<string> result = new List<string>();

        public List<string> GenerateCombination(string s, int val)
        {
            DFS(s.ToCharArray(), val, new List<char>(),0 );
            return result;
        }

        public void DFS(char[] s, int val, List<char> temp, int index)
        {
            if (temp.Count == val)
            {
                result.Add(new string(temp.ToArray()));
                return;
            }

            if (index == s.Length)
                return;

            temp.Add(s[index]);
            DFS(s,val,temp,index+1);
            temp.RemoveAt(temp.Count-1);
            DFS(s, val, temp, index + 1);
        }

    }
}
