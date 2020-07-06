using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class ConnectedComponents
    {
        public int CountComponents(int n, int[][] edges)
        {
            var adjacencyMap = BuildMap(n, edges);
            int[] visited = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (visited[i] == 0)
                {
                    ++count;
                    DFS(i, adjacencyMap, visited);
                }
            }

            return count;
        }

        public void DFS(int src, Dictionary<int, List<int>> adjacencyMap, int[] visited)
        {
            visited[src] = 1;

            foreach(var edge in adjacencyMap[src])
            {
                if(visited[edge] == 0)
                {
                    DFS(edge, adjacencyMap, visited);
                }
            }
        }


        public Dictionary<int, List<int>> BuildMap(int n, int[][] edges)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            for(int i = 0; i < n; i++)
            {
                map.Add(i, new List<int>());
            }

            foreach(var edge in edges)
            {
                map[edge[0]].Add(edge[1]);
                map[edge[1]].Add(edge[0]);
            }

            return map;
        }
    }
}
