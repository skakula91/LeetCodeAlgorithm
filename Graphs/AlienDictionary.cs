using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class AlienDictionary
    {
        public StringBuilder sb;
        public HashSet<char> visited = new HashSet<char>();
        public string AlienOrder(string[] words)
        {
            sb = new StringBuilder();
            var adjacency = BuildMap(words);
            foreach (var kp in adjacency)
            {
                if (!visited.Contains(kp.Key))
                {
                    DFS(kp.Key, adjacency);
                }
            }
            return sb.ToString();
        }

        public void DFS(char src, Dictionary<char, List<char>> adjmap)
        {
            visited.Add(src);

            foreach (var ch in adjmap[src])
            {
                if (!visited.Contains(ch))
                {
                    DFS(ch, adjmap);
                }
            }

            sb.Append(src);


        }

        public Dictionary<char, List<char>> BuildMap(string[] words)
        {
            Dictionary<char, List<char>> dict = new Dictionary<char, List<char>>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!dict.ContainsKey(words[i][j]))
                    {
                        dict.Add(words[i][j], new List<char>());
                    }
                }
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = 0; j < Math.Min(words[i].Length, words[i + 1].Length); j++)
                {
                    if (words[i][j] == words[i + 1][j])
                    {
                        continue;
                    }

                    if (dict.ContainsKey(words[i][j]))
                    {
                        dict[words[i][j]].Add(words[i + 1][j]);
                    }
                    else
                    {
                        dict.Add(words[i][j], new List<char> { words[i + 1][j] });
                    }

                    break;

                }
            }

            return dict;
        }

    }

}
