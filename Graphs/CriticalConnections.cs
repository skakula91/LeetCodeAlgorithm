using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class CriticalConnections
    {
        public int[] reachable;
        public int[] arrival;
        public int[] visited;
        public int[] parent;
        public int Time = 0;
        public int HeightReach = 0;
        public List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> CriticalConnectionsNetwork(int n, int[][] connections)
        {
            reachable = new int[n];
            arrival = new int[n];
            visited = new int[n];
            parent = new int[n];
            var adjMap = BuildAdjacencyMap(n, connections);

            for (int i = 0; i < n; i++)
            {
                parent[i] = -1;
                arrival[i] = -1;
            }
            for (int i = 0; i < n; i++)
            {
                if (visited[i] == 0)
                {
                    DFS(i, adjMap);
                }
            }

            return result;
        }

        public void DFS(int src, Dictionary<int, List<int>> adjMap)
        {       
            arrival[src] = reachable[src] = ++Time;
            visited[src] = 1;
            foreach (var course in adjMap[src])
            {
                if (visited[course] == 0)
                {
                    parent[course] = src;
                    DFS(course, adjMap);
                    reachable[src] = Math.Min(reachable[course], reachable[src]);
                }
                else
                {
                    //Back edge
                    if (parent[src] != course)
                    {
                        if (arrival[course] < arrival[src])
                        {
                            reachable[src] = Math.Min(reachable[src], arrival[course]);
                        }
                    }
                }
            }
            if (reachable[src] >= arrival[src] && parent[src] != -1)
            {
                result.Add(new List<int> { parent[src], src });
            }
        }

        public Dictionary<int, List<int>> BuildAdjacencyMap(int n, int[][] connections)
        {
            var map = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; ++i)
            {
                map.Add(i, new List<int>());
            }

            foreach (var course in connections)
            {
                map[course[0]].Add(course[1]);
                map[course[1]].Add(course[0]);
            }

            return map;
        }
    }
}
