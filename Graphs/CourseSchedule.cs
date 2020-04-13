using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class CourseSchedule
    {
        public int[] departure;
        public int[] arrival;
        public int[] visited;
        public int Time = 0;
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
           departure = new int[numCourses];
           arrival = new int[numCourses];
           visited = new int[numCourses];
           var adjMap =  BuildAdjacencyMap(numCourses, prerequisites);

           for (int i = 0; i < numCourses; i++)
           {
               if (visited[i] == 0)
               {
                   bool result = DFS(i, adjMap);
                   if (result)
                       return false;
               }
           }

           return true;
        }

        public bool DFS(int src, Dictionary<int,List<int>> adjMap)
        {
            arrival[src] = ++Time;
            visited[src] = 1;
            foreach (var course in adjMap[src])
            {
                if (visited[course] == 0)
                {
                    if (DFS(course, adjMap))
                        return true;
                }
                else
                {
                    //Back edge
                    // Back edge is going from node to it's ancestor.
                    // since the ancestor is still in stack waiting for it's decedent to finish execution just check departure
                    // array of the ancestor it should be 0.
                    if (departure[course] == 0)
                        return true;
                }
            }
            departure[src] = ++Time;
            return false;
        }

        public Dictionary<int, List<int>> BuildAdjacencyMap(int n, int[][] prerequisites)
        {
            var map = new Dictionary<int,List<int>>();
            for (int i = 0; i < n; ++i)
            {
                map.Add(i,new List<int>());
            }

            foreach (var course in prerequisites)
            {
                map[course[0]].Add(course[1]);
            }

            return map;
        }
    }
}
