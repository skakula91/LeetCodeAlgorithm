using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        Point p = new Point(i, j);
                        BFS(p, grid);
                    }
                }
            }

            return count;
        }

        public void BFS(Point p,  char[][] grid)
        {
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(p);
            grid[p.X][p.Y] = '0';
            while (q.Count != 0)
            {
                var node = q.Dequeue();
                foreach (var neigh in GetNeighbours(node, grid))
                {
                    if (grid[neigh.X][neigh.Y] == '1')
                    {
                        grid[neigh.X][neigh.Y] = '0';
                        q.Enqueue(neigh);
                    }
                }
            }
        }

        public List<Point>  GetNeighbours(Point p, char[][] grid)
        {
            List<Point> neighPoints = new List<Point>();
            int x = p.X;
            int y = p.Y;

            if (x + 1 <= grid.Length - 1)
            {
                neighPoints.Add(new Point(x+1,y));
            }
            //length of the column in grid
            if (y + 1 <= grid[0].Length - 1)
            {
                neighPoints.Add(new Point(x, y+1));
            }
            if (x -1 >= 0)
            {
                neighPoints.Add(new Point(x - 1, y));
            }
            if (y - 1 >= 0)
            {
                neighPoints.Add(new Point(x , y-1));
            }

            return neighPoints;
        }
    }
}
