using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Islands
    {

        public int NumIslands(char[][] grid)
        {
            int rows = grid.Length;
            int columns = grid[0].Length;
            int numberofIslands = 0;
            HashSet<string> visited = new HashSet<string>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (grid[i][j] == '1' && !visited.Contains($"{i}.{j}"))
                    {
                        BFS(grid, visited, new Point(i, j));
                        numberofIslands++;
                    }
                }
            }

            return numberofIslands;
        }

        public void BFS(char[][] grid, HashSet<string> visited, Point point)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(point);

            while (q.Count != 0)
            {
                int qlen = q.Count;
                for (int i = 0; i < qlen; i++)
                {
                    var p = q.Dequeue();
                    if (grid[p.X][p.Y] == '1' && !visited.Contains($"{p.X}.{p.Y}"))
                    {
                        visited.Add($"{p.X}.{p.Y}");
                        q = GetNeighbours(grid, q, p);
                    }
                }
            }
        }

        public Queue<Point> GetNeighbours(char[][] grid, Queue<Point> q, Point p)
        {
            int x = p.X;
            int y = p.Y;

            if (x - 1 >= 0)
            {
                q.Enqueue(new Point(x - 1, y));
            }
            if (y - 1 >= 0)
            {
                q.Enqueue(new Point(x, y - 1));
            }
            if (x + 1 <= grid.Length - 1)
            {
                q.Enqueue(new Point(x + 1, y));
            }
            if (y + 1 <= grid[0].Length - 1)
            {
                q.Enqueue(new Point(x, y + 1));
            }
            return q;
        }
    }
}
