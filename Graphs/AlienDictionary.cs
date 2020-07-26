using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class AlienDictionary
    {
        public string AlienOrder(string[] words)
        {
            Dictionary<char, int> indegree = new Dictionary<char, int>();
            Dictionary<char, List<char>> adjMap = new Dictionary<char, List<char>>();
            List<char> result = new List<char>();
            Queue<char> q = new Queue<char>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!adjMap.ContainsKey(words[i][j]))
                    {
                        adjMap.Add(words[i][j], new List<char>());
                    }

                    if (!indegree.ContainsKey(words[i][j]))
                    {
                        indegree.Add(words[i][j], 0);
                    }
                }
            }

            //Build Map
            for (int i = 0; i < words.Length - 1; i++)
            {
                bool found = false;
                for (int j = 0; j < Math.Min(words[i].Length, words[i + 1].Length); j++)
                {
                    if (words[i][j] != words[i + 1][j])
                    {
                        adjMap[words[i][j]].Add(words[i + 1][j]);
                        indegree[words[i+1][j]]++;
                        found = true;
                        break;
                    }
                }

                if (!found && words[i].Length > words[i + 1].Length)
                    return "";
            }

            foreach (var kp in indegree)
            {
                if (kp.Value == 0)
                {
                    q.Enqueue(kp.Key);
                }
            }

            if (q.Count == 0)
                return "";

            while (q.Count != 0)
            {
                var node = q.Dequeue();
                foreach (var neigh in adjMap[node])
                {
                    indegree[neigh]--;
                    if (indegree[neigh] == 0)
                    {
                        q.Enqueue(neigh);
                    }
                }

                result.Add(node);
            }

            foreach (var kp in indegree)
            {
                if (indegree[kp.Key] > 0)
                {
                    return "";
                }
            }

            return new string(result.ToArray());
        }

    }
}
