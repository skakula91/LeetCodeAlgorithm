using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class WordLadderII
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            // First let find what is shortest distance - BFS
            List<IList<string>> result = new List<IList<string>>();
            Dictionary<string, List<string>> adjMap = new Dictionary<string, List<string>>();
            HashSet<string> hs = new HashSet<string>();
            Dictionary<string, int> visited = new Dictionary<string, int>();
            foreach (var word in wordList)
            {
                hs.Add(word);
                visited.Add(word, 0);
                adjMap.Add(word, new List<string>());
            }
            // dont forget to add soure word
            visited.Add(beginWord, 0);
            adjMap.Add(beginWord, new List<string>());

            if (!hs.Contains(endWord))
                return result;

            int lenshortestPath = BFS(beginWord, endWord ,adjMap, hs,visited);
            // Now DFS to determine path

            if (lenshortestPath == -1)
                return result;

            DFS(beginWord, endWord, lenshortestPath, adjMap, result, new List<string> { beginWord }, new HashSet<string>());
            return result;

        }

        public void DFS(string start, string end, int pathlen, Dictionary<string, List<string>> adjMap, List<IList<string>> result, List<string> slate, HashSet<string> visited)
        {
            if (start == end)
            {
                if (pathlen == 1)
                {
                    result.Add(new List<string>(slate));
                    return;
                }
            }
            if (pathlen < 0)
                return;

            if (!adjMap.ContainsKey(start))
                return;
            visited.Add(start);
            foreach (var neigh in adjMap[start])
            {
                if (visited.Contains(neigh))
                    continue;

                slate.Add(neigh);
                DFS(neigh, end, pathlen - 1, adjMap, result, slate, visited);
                slate.RemoveAt(slate.Count - 1);
            }
            visited.Remove(start);
        }




        public int BFS(string start, string end, Dictionary<string, List<string>> adjMap, HashSet<string> hs, Dictionary<string, int> visitedDistance)
        {
            int result = Int32.MaxValue;
            int count = 1;
            Queue<string> q = new Queue<string>();
            q.Enqueue(start);
            visitedDistance[start] = 1;
            while (q.Count != 0)
            {
                int qlen = q.Count;
                for (int i = 0; i < qlen; i++)
                {
                    var str = q.Dequeue();
                    if (str == end)
                    {
                        result = Math.Min(count, result);
                    }
                    char[] ch = str.ToArray();
                    for (int j = 0; j < str.Length; j++)
                    {
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            char temp = ch[j];

                            if (ch[j] == c)
                                continue;

                            ch[j] = c;

                            string tempstr = new string(ch);

                            if (hs.Contains(tempstr))
                            {
                                if (visitedDistance[tempstr] == 0)
                                {
                                    visitedDistance[tempstr] = visitedDistance[str] + 1;
                                    q.Enqueue(tempstr);
                                    adjMap[str].Add(tempstr);
                                }
                                else if (visitedDistance[tempstr] == visitedDistance[str] + 1)
                                {
                                    adjMap[str].Add(tempstr);
                                }

                            }

                            ch[j] = temp;
                        }
                    }
                }
                count++;
            }
            return result == Int32.MaxValue ? -1 : result;
        }
    }
}
