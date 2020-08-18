using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class PrintStringSinuosidal
    {
        public static void printStringSinusoidally(string s)
        {
            if (s.Length == 0)
                return;

            Dictionary<int, List<char>> dict = new Dictionary<int, List<char>>();
            for (int i = 0; i < 3; i++)
            {
                dict.Add(i, new List<char>());
            }
            bool firstrow = false;

            for (int i = 0; i < s.Length; i++)
            {
                char c = (s[i] == ' ') ? '~' : s[i];
                if (i % 2 == 0)
                {
                    if (firstrow)
                    {
                        dict[0].Add(c);
                        dict[1].Add(' ');
                        dict[2].Add(' ');
                        firstrow = false;
                    }
                    else
                    {
                        dict[0].Add(' ');
                        dict[1].Add(' ');
                        dict[2].Add(c);
                        firstrow = true;
                    }
                }
                else
                {
                    dict[0].Add(' ');
                    dict[1].Add(c);
                    dict[2].Add(' ');
                }
            }

            foreach (var kp in dict)
            {
                    Console.WriteLine(new string(kp.Value.ToArray()));
            }
            
        }
    }
}
