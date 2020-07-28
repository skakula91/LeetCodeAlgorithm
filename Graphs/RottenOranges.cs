using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class RottenOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            Queue<int[]> q = new Queue<int[]>();
            int fresh = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        q.Enqueue(new int[] {i, j});
                    }
                    else if (grid[i][j] == 1)
                    {
                        fresh++;
                    }
                }
            }

            if (fresh == 0)
                return 0;

            int result = -1;

            while (q.Count != 0)
            {
                int qlen = q.Count;
                for (int i = 0; i < qlen; i++)
                {
                    var curr = q.Dequeue();
                    foreach (var neigh in GetNeighbours(grid, curr[0], curr[1]))
                    {
                        if (grid[neigh[0]][neigh[1]] == 1)
                        {
                            fresh--;
                            grid[neigh[0]][neigh[1]] = 2;
                            q.Enqueue(new int[] {neigh[0], neigh[1]});
                        }
                    }
                }

                result++;
            }

            return (fresh == 0) ? result : -1;
        }

        public List<int[]> GetNeighbours(int[][] grid, int x, int y)
        {
            List<int[]> lst = new List<int[]>();
            if (x - 1 >= 0 && grid[x - 1][y] == 1)
            {
                lst.Add(new int[] {x - 1, y});
            }

            if (y - 1 >= 0 && grid[x][y - 1] == 1)
            {
                lst.Add(new int[] {x, y - 1});
            }

            if (x + 1 <= grid.Length - 1 && grid[x + 1][y] == 1)
            {
                lst.Add(new int[] {x + 1, y});
            }

            if (y + 1 <= grid[0].Length - 1 && grid[x][y + 1] == 1)
            {
                lst.Add(new int[] {x, y + 1});
            }

            return lst;
        }
    }
}
