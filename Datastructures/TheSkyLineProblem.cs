using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Datastructures
{
    public class TheSkyLineProblem
    {
        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            SortedSet<(int,int)> maxHeapPQ = new SortedSet<(int, int)>(Comparer<(int,int)>.Create((a, b) => a.Item1 != b.Item1 ? b.Item1.CompareTo(a.Item1) : a.Item2.CompareTo(b.Item2)));

            List<int[]> buildingStartEnd = new List<int[]>();
            int bNum = 1;
            foreach (var build in buildings)
            {
                // 0 is start, 1 is end
                buildingStartEnd.Add(new int[] { build[0], build[2], 0, bNum });
                buildingStartEnd.Add(new int[] { build[1], build[2], 1, bNum });
                bNum++;
            }

            var lst = buildingStartEnd.OrderBy(x => x[0]).ToList();

            List<IList<int>> result = new List<IList<int>>();

            maxHeapPQ.Add((0,0));

            int max_height = 0;
            foreach (var bentry in lst)
            {
                // start of building
                if (bentry[2] == 0)
                {
                    maxHeapPQ.Add((bentry[1],bentry[3]));
                    if (bentry[1] > max_height)
                    {
                        max_height = bentry[1];
                        result.Add(new List<int>() { bentry[0], max_height });
                    }
                }
                // end of building
                else if (bentry[2] == 1)
                {
                    Console.WriteLine(bentry[1]);
                    maxHeapPQ.Remove((bentry[1],bentry[3]));

                    int top = maxHeapPQ.First().Item1;
                    //Console.WriteLine(top);
                    //Console.WriteLine(max_height);
                    if (top < max_height)
                    {
                        max_height = top;
                        result.Add(new List<int>() { bentry[0], max_height });
                    }
                }

            }
            return result;

        }
    }
}
