using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class GenerateParanthesis
    {
        public List<string> result = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            Helper(n, 0, 0, new List<char>());
            return result;
        }
        private void Helper(int n, int oBrac, int clBrac, List<char> sb)
        {

            if (oBrac > n)
            {
                return;
            }
            if (oBrac < clBrac)
            {
                return;
            }
            if (sb.Count == 2 * n)
            {
                result.Add(new string(sb.ToArray()));
            }

            sb.Add('(');
            Helper(n, oBrac + 1, clBrac, sb);
            sb.RemoveAt(sb.Count - 1);
            sb.Add(')');
            Helper(n, oBrac, clBrac + 1, sb);
            sb.RemoveAt(sb.Count - 1);
        }
    }

}
