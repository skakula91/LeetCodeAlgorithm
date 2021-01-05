using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AlgorithmPart2
{
    public class TransactionLogs
    {
        public List<string> Solve(string[] transactions, int k)
        {
            Dictionary<string,int> dict = new Dictionary<string, int>();
            SortedSet<string>  set = new SortedSet<string>(Comparer<string>.Create((x, y) => int.Parse(y).CompareTo(int.Parse(x))));

            foreach (var tran in transactions)
            {
                var str = tran.Split(" ");
                if (!dict.ContainsKey(str[0]))
                {
                    dict.Add(str[0],0);
                }

                dict[str[0]]++;
                if (dict[str[0]] == k)
                {
                    set.Add(str[0]);
                }
                if (!dict.ContainsKey(str[1]))
                {
                    dict.Add(str[1], 0);
                }

                dict[str[1]]++;
                if (dict[str[1]] == k)
                {
                    set.Add(str[1]);
                }
            }

            return set.ToList();
        }
    }
}
