using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class AllPathSourcetoTarget
    {
        public List<IList<int>> Result = new List<IList<int>>();
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            int nodes = graph.Length;
            int[] visited = new int[nodes];

            DFS(0, graph, nodes - 1, visited, new List<int>(){0});
            return Result;
        }
        public void DFS(int src, int[][] graph, int dest, int[] visited, List<int> temp)
        {
            if (src == dest)
            {
                Result.Add(new List<int>(temp));
                return;
            }

            visited[src] = 1;
            foreach (var neigh in graph[src])
            {
                if (visited[neigh] == 0)
                {
                    temp.Add(neigh);
                    DFS(neigh, graph, dest, visited, temp);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
            visited[src] = 0;
        }
    }
}
