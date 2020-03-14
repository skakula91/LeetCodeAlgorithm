using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart1
{
    class IncreasingDecreasingString
    {
        public static string SortString(string s)
        {
            SortedList<char, int> sortedDict = new SortedList<char, int>();
            int i;
            for (i = 0; i < s.Length; i++)
            {
                if (sortedDict.ContainsKey(s[i]))
                {
                    sortedDict[s[i]] = sortedDict[s[i]] + 1;
                }
                else
                {
                    sortedDict.Add(s[i], 1);
                }
            }
            StringBuilder sb = new StringBuilder();
            int count = s.Length;
            i = 0;
            int j = sortedDict.Count - 1;
            while (count != 0)
            {
                for (i = 0; i <= j; i++)
                {
                    char key = sortedDict.ElementAt(i).Key;
                    if (sortedDict[key] != 0)
                    {
                        sb.Append(key);
                        sortedDict[key] = sortedDict[key] - 1;
                        count--;
                        if (count == 0)
                            break;
                    }
                }
                for (int k = j; k >= 0; k--)
                {
                    char key = sortedDict.ElementAt(k).Key;
                    if (sortedDict[key] != 0)
                    {
                        sb.Append(key);
                        sortedDict[key] = sortedDict[key] - 1;
                        count--;
                        if (count == 0)
                            break;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
