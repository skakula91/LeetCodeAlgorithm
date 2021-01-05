using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class Solution
    {
        public int solutionI(string[] T, string[] R)
        {
            if (T.Length == 0 || R.Length == 0)
                return 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < T.Length; i++)
            {
                int len = T[i].Length;
                string lastCh = T[i].Substring(len - 1, 1);
                string curr;
                if (!char.IsDigit(char.Parse(lastCh)))
                {
                    curr = T[i].Substring(0, len - 1);
                }
                else
                {
                    curr = T[i];
                }

                if (dict.ContainsKey(curr))
                {
                    if (R[i] == "Wrong answer" || R[i] == "Runtime error" || R[i] == "Time limit exceeded")
                    {
                        dict[curr] = 0;
                    }
                    else if (R[i] == "OK")
                    {
                        if (dict[curr] == 0)
                        {
                            dict[curr] = 0;
                        }
                        else
                        {
                            dict[curr] = 1;
                        }
                    }
                }
                else
                {
                    if (R[i] == "Wrong answer" || R[i] == "Runtime error" || R[i] == "Time limit exceeded")
                    {
                        dict.Add(curr, 0);
                    }
                    else
                    {
                        dict.Add(curr, 1);
                    }
                }
            }

            int pass = 0;
            foreach (var kvp in dict)
            {
                if (kvp.Value == 1)
                {
                    pass++;
                }
            }

            int result = pass*100 / dict.Count;
            return result;
        }
    }
}
