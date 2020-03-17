using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class ReorganizeString
    {
        public static string Reorganize(string S)
        {
            int arrLen = S.Length;
            var charArr = S.ToCharArray();
            int[] frequency = new int[26];
            char[] output = new char[arrLen];
            foreach (char c in charArr)
            {
                frequency[c - 'a'] = frequency[c - 'a'] + 100;
            }
            for (int i = 0; i < 26; i++)
            {
                frequency[i] = frequency[i] + i;
            }

            Array.Sort(frequency);
            int distance = 1;
            for (int i = 0; i < 26; i++)
            {
                if (frequency[i] < 100)
                    continue;
                else
                {
                    int count = frequency[i] / 100;
                    if (count > (arrLen + 1) / 2)
                        return "";
                    char chr = (char)(frequency[i] % 100 + 'a');
                    for (int j = 0; j < count; j++)
                    {
                        if (distance >= arrLen)
                            distance = 0;
                        output[distance] = chr;
                        distance = distance + 2;
                    }
                }
            }

            return new string(output);

        }
    }
}
