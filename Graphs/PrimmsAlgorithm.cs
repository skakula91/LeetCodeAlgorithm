using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphs
{
    public class PrimmsAlgorithm
    {
        public double Prim(int[][] edges)
        {
            var map = BuildAdjMap(edges);

            int[] captured = new int[edges.Length];
            int[] visited = new int[edges.Length];
            double[] importance = new double[edges.Length];
            return BFS(map, 0, captured, visited, importance);
        }

        public double BFS(Dictionary<int, Dictionary<int, double>> map, int src, int[] captured, int[] visited, double[] importance)
        {
            double totalCost = 0;
            captured[src] = 1;
            SortedSet<Tuple<double, int>> ss = new SortedSet<Tuple<double, int>>();

            foreach (var kp in map[src])
            {
                ss.Add(new Tuple<double, int>(kp.Value,kp.Key));
                importance[kp.Key] = kp.Value;
            }

            while (ss.Count > 0)
            {
                var node = ss.First();
                totalCost += node.Item1;
                ss.Remove(ss.First());
                captured[node.Item2] = 1;
                foreach (var neigh in map[node.Item2])
                {
                    if (visited[neigh.Key] == 0)
                    {
                        visited[neigh.Key] = 1;
                        ss.Add(new Tuple<double, int>(neigh.Value, neigh.Key));
                        importance[neigh.Key] = neigh.Value;
                    }
                    else
                    {
                        if (captured[neigh.Key] == 0)
                        {
                            if (neigh.Value < importance[neigh.Key] && importance[neigh.Key] != 0)
                            {
                                foreach (var val in ss)
                                {
                                    if (val.Item2 == neigh.Key)
                                    {
                                        ss.Remove(val);
                                        ss.Add(new Tuple<double, int>(neigh.Value, neigh.Key));
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return totalCost;
        }
        public Dictionary<int, Dictionary<int, double>> BuildAdjMap(int[][] edges)
        {
            Dictionary<int, Dictionary<int, double>> dict = new Dictionary<int, Dictionary<int, double>>();
            for (int i = 0; i < edges.Length; i++)
            {
                var a = edges[i][0];
                var b = edges[i][1];
                var cost = edges[i][2];

                if (!dict.ContainsKey(a))
                {
                    dict[a] = new Dictionary<int, double>();
                }
                dict[a][b] = cost;
                if (!dict.ContainsKey(b))
                {
                    dict[b] = new Dictionary<int, double>();
                }

                dict[b][a] = cost;
            }

            return dict;
        }
    }
}
