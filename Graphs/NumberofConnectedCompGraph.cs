using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class NumberofConnectedCompGraph
    {
        public int CountComponents(int n, int[][] edges)
        {
            var adjacencyMap = BuildGraph(n, edges);
            int[] visited = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (visited[i] == 0)
                {
                    BFS(i, adjacencyMap, visited);
                    ++count;
                }

            }
            return count;
        }

        public void BFS(int src, Dictionary<int, List<int>> adjacencyMap, int[] visited)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(src);
            while (q.Count != 0)
            {
                var temp = q.Dequeue();
                visited[temp] = 1;
                foreach (int edge in adjacencyMap[temp])
                {
                    if (visited[edge] == 0)
                    {
                        q.Enqueue(edge);
                        visited[edge] = 1;
                    }
                }
            }
        }

        public void DFS(int src, Dictionary<int, List<int>> adjacencyMap, int[] visited)
        {
            visited[src] = 1;
            foreach (int edge in adjacencyMap[src])
            {
                if (visited[edge] == 0)
                {
                    DFS(edge, adjacencyMap, visited);
                }
            }

        }

        public Dictionary<int, List<int>> BuildGraph(int n, int[][] edges)
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                dict.Add(i, new List<int>());
            }
            // Adjacency List
            foreach (var edge in edges)
            {
                dict[edge[0]].Add(edge[1]);
                dict[edge[1]].Add(edge[0]);
            }

            return dict;
        }
    }
}
