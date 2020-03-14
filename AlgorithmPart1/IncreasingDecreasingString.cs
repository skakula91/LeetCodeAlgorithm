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
            SortedDictionary<char, int> sortedDict = new SortedDictionary<char, int>();
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
            int count = 0;
            i = 0;
            int j = sortedDict.Count - 1;
            while (count <= sortedDict.Count - 1)
            {

                for (i = 0; i <= j; i++)
                {
                    char key = sortedDict.ElementAt(i).Key;
                    if (sortedDict[key] != -1)
                    {
                        if (sortedDict[key] == 0)
                        {
                            sortedDict[key] = -1;
                            count++;
                        }
                        else
                        {
                            sortedDict[key] = sortedDict[key] - 1;
                            sb.Append(key);
                        }
                    }
                }
                for (int k = j; k >= 0; k--)
                {
                    char key = sortedDict.ElementAt(k).Key;
                    if (sortedDict[key] != -1)
                    {
                        if (sortedDict[key] == 0)
                        {
                            sortedDict[key] = -1;
                            count++;
                        }
                        else
                        {
                            sortedDict[key] = sortedDict[key] - 1;
                            sb.Append(key);
                        }
                    }
                }
            }

            return sb.ToString();
        }
    }
}
