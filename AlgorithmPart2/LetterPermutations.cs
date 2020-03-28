using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart2
{
    public class LetterPermutations
    {
        public List<string> result = new List<String>();
        public IList<string> LetterCasePermutation(string S)
        {
            Helper(S, 0, new List<char>());
            return result;
        }
        private void Helper(string s, int i, List<char> slate)
        {
            if(s.Length == i)
            {
                result.Add(new string(slate.ToArray()));
                return;
            }
            else
            {               
                if(char.IsDigit(s[i]))
                {
                    slate.Add(s[i]);
                    Helper(s,i+1, slate);
                    slate.RemoveAt(slate.Count - 1);
                }
                else
                {
                        slate.Add(char.ToUpper(s[i]));
                        Helper(s, i + 1, slate);
                        slate.RemoveAt(slate.Count - 1);
                        slate.Add(char.ToLower(s[i]));
                        Helper(s, i + 1, slate);
                        slate.RemoveAt(slate.Count - 1);
                }
            }
        }
    }
}
