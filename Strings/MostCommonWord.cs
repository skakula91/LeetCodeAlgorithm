using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    public class MostCommonWord
    {
        public string MostCommon(string paragraph, string[] banned)
        {
            HashSet<char> hs = new HashSet<char> { '!', '?', ',', ';', '.', '\'' };

            StringBuilder sb = new StringBuilder();
            foreach (var c in paragraph)
            {
                if (!hs.Contains(c))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append(' ');
                }
            }
            paragraph = sb.ToString().ToLower();
            string[] str = paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> ban = new HashSet<string>(banned.ToList());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var s in str)
            {
                if (!ban.Contains(s))
                {
                    if (!dict.ContainsKey(s))
                    {
                        dict.Add(s, 1);
                    }
                    else
                    {
                        dict[s]++;
                    }
                }
            }
            string result = string.Empty;
            int count = Int32.MinValue;
            foreach (var kp in dict)
            {
                if (kp.Value > count)
                {
                    count = kp.Value;
                    result = kp.Key;
                }
            }
            return result;
        }
    }
}
