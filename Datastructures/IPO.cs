using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructures
{
    public class IPO
    {
        public int FindMaximizedCapital(int k, int W, int[] Profits, int[] Capital)
        {
            // using sorted List for RemoveAt function
            // minHeap for captial
            SortedList<int, int> projectsPq = new SortedList<int, int>(Comparer<int>.Create((x, y) => x != y ? x.CompareTo(y) : 1));

            for (int i = 0; i < Profits.Length; i++)
            {
                projectsPq.Add(Capital[i], Profits[i]);
            }


            // maxHeap for profit
            SortedList<int, int> feasible = new SortedList<int, int>(Comparer<int>.Create((x, y) => x != y ? y.CompareTo(x) : 1));

            while (k > 0)
            {
                while (projectsPq.Count != 0 && projectsPq.First().Key <= W)
                {
                    feasible.Add(projectsPq.First().Value, projectsPq.First().Value);
                    projectsPq.RemoveAt(0);
                }

                if (feasible.Count == 0)
                {
                    return W;
                }
                W += feasible.First().Value;
                feasible.RemoveAt(0);
                k--;
            }

            return W;
        }
    }
}
