using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class PartitionLabels
    {
        public IList<int> PartitionLabelsI(string S)
        {
            int[] temp = new int[26];
            HashSet<char> hs = new HashSet<char>();
            int count = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                int index = S[i] - 'a';
                if (temp[index] > 0)
                {
                    hs.Remove(S[i]);
                    if (hs.Count == 0)
                    {
                        result.Add(count);
                        count = 0;
                    }
                }
                else
                {
                    temp[index]++;
                    if (!hs.Contains(S[i]))
                        hs.Add(S[i]);
                }
            }

            return result;
        }
    }
}
