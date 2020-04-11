using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class IsBipartite
    {
        public int[] visited;
        public int[] parent;
        public int[] distance;
        public bool IsBipartiteGraph(int[][] graph)
        {
            var numberOfVertices = graph.Length;
            visited = new int[numberOfVertices];
            parent = new int[numberOfVertices];
            distance = new int[numberOfVertices];
            return BFS(graph);
        }
        public bool BFS( int[][] graph)
        {
            Queue<int> q = new Queue<int>();
            for (int j = 0; j < graph.Length; j++)
            {
                q.Enqueue(j);
                if (visited[j] == 0)
                {
                    visited[j] = 1;
                    distance[j] = 1;
                }

                while (q.Count != 0)
                {
                    var node = q.Dequeue();
                    foreach (var i in graph[node])
                    {
                        if (visited[i] == 0)
                        {
                            q.Enqueue(i);
                            parent[i] = node;
                            visited[i] = 1;
                            distance[i] = distance[node]+1;
                        }
                        else
                        {
                            if (parent[node] != i && distance[i] == distance[node])
                                return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
