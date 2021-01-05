using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart2
{
    public class MostVisitedPatternUser
    {
        public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
        {
            List<string> result = new List<string>();

            VisitLog[] log = new VisitLog[username.Length];

            // number of websites user visited
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < username.Length; i++)
            {
                log[i] = new VisitLog(username[i], timestamp[i], website[i]);

                if (!dict.ContainsKey(username[i]))
                {
                    dict.Add(username[i], 0);
                }
                dict[username[i]]++;
            }

            Array.Sort(log, (a, b) => a.UserName == b.UserName ? a.TimeStamp.CompareTo(b.TimeStamp) : a.UserName.CompareTo(b.UserName));

            Dictionary<(string, string, string), int> dictCountPattern = new Dictionary<(string, string, string), int>();
            int j = 0;
            while (j < log.Length)
            {
                string userName = log[j].UserName;
                int noOfWebsites = dict[userName];
                //all combinations
                for (int x = j; x < j + noOfWebsites - 2; x++)
                {
                    for (int y = x + 1; y < j + noOfWebsites - 1; y++)
                    {
                        for (int z = y + 1; z < j + noOfWebsites; z++)
                        {
                            if (!dictCountPattern.ContainsKey((log[x].Website, log[y].Website, log[z].Website)))
                            {
                                dictCountPattern.Add((log[x].Website, log[y].Website, log[z].Website), 0);
                            }
                            dictCountPattern[(log[x].Website, log[y].Website, log[z].Website)]++;
                        }
                    }
                }
                j += noOfWebsites;
            }
            var resultDict = dictCountPattern.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Item1).ThenBy(x => x.Key.Item2).ThenBy(x => x.Key.Item3);

            var kvp = resultDict.First();
            result.Add(kvp.Key.Item1);
            result.Add(kvp.Key.Item2);
            result.Add(kvp.Key.Item3);
            return result;
        }


        public class VisitLog
        {
            public string UserName;
            public int TimeStamp;
            public string Website;

            public VisitLog(string username, int timestamp, string website)
            {
                UserName = username;
                TimeStamp = timestamp;
                Website = website;
            }
        }
    }
}
