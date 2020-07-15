using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class MinimumKnightMoves
    {

        int[] delX = new int[] { 1, 1, 2, 2, -1, -1, -2, -2 };
        int[] delY = new int[] { 2, -2, 1, -1, 2, -2, 1, -1 };

        public int MinKnightMoves(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            var queue = new Queue<int[]>();
            queue.Enqueue(new int[] { 0, 0 });

            var visited = new HashSet<string>();
            visited.Add("0,0");

            int result = 0;
            while (queue.Count != 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int[] cur = queue.Dequeue();
                    int curX = cur[0], curY = cur[1];
                    if (curX == x && curY == y)
                        return result;

                    for (int j = 0; j < delX.Length; j++)
                    {
                        int newX = curX + delX[j], newY = curY + delY[j];
                        if (newX >= -2 && newY >= -2 && newX <= x + 2 && newY <= y + 2 &&
                            !visited.Contains(newX + "," + newY))
                        {
                            queue.Enqueue(new int[] { newX, newY });
                            visited.Add(newX + "," + newY);
                        }
                    }
                }

                result++;
            }

            return -1;
        }
    }
}

