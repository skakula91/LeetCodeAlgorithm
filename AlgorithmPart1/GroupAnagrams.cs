using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> Anagram(string[] strs)
        {
            Dictionary<string, List<string>> anagram = new Dictionary<string, List<string>>();
            foreach(var str in strs)
            {
                char[] a = str.ToCharArray();
                Array.Sort(a);
                string key = new string(a);
                if(anagram.ContainsKey(key))
                {
                    anagram[key].Add(str);
                }
                else
                {
                    anagram.Add(key, new List<string> { str });
                }
            }
            List<IList<string>> strList = new List<IList<string>>();
            foreach(var data in anagram)
            {
                strList.Add(data.Value);
            }
            return strList;
        }
    }
}
