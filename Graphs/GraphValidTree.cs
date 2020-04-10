using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class GraphValidTree
    {
        private int[] visited;
        private int[] parent;
        public bool ValidTree(int n, int[][] edges)
        {
            var adjMap = BuildAdjacencyMap(n, edges);
             visited  = new int[n];
             parent = new int[n];
             int count = 0;
             bool hasCycle = false;
             for (int i = 0; i < n; i++)
             {
                 if (visited[i] == 0)
                 {
                     ++count;
                     if (count > 1)
                         return false;
                     hasCycle = BFS(i, adjMap);
                     if (hasCycle)
                         return false;
                 }
             }

             return true;
        }

        public bool BFS(int src, Dictionary<int, List<int>> adjMap)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(src);
            while (q.Count != 0)
            {
                var current = q.Dequeue();
                visited[current] = 1;
                foreach (var edge in adjMap[current])
                {
                    if (visited[edge] == 0)
                    {
                        q.Enqueue(edge);
                        visited[edge] = 1;
                        parent[edge] = current;
                    }
                    else
                    {
                        // Has cycle
                        if (parent[current] != edge)
                            return true;
                    }
                }
            }

            return false;
        }

        public Dictionary<int, List<int>> BuildAdjacencyMap(int n, int[][] edges)
        {
            Dictionary<int, List<int>> dict  = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                dict.Add(i, new List<int>());
            }

            //Adjacency map
            foreach (var edge in edges)
            {
                dict[edge[0]].Add(edge[1]);
                dict[edge[1]].Add(edge[0]);
            }

            return dict;
        }
    }
}
