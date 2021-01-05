using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class ShortestBridge
    {
        public int[][] directions = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };

        public int ShortestBridgeI(int[][] A)
        {
            List<int[]> islandA = new List<int[]>();
            List<int[]> islandB = new List<int[]>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[0].Length; j++)
                {
                    if (A[i][j] == 1)
                    {
                        if (islandA.Count == 0)
                        {
                            BFS(i, j, islandA, A);
                        }
                        else
                        {
                            BFS(i, j, islandB, A);
                        }
                    }
                }
            }

            int result = Int32.MaxValue;
            for (int i = 0; i < islandA.Count; i++)
            {
                for (int j = 0; j < islandB.Count; i++)
                {
                    int temp = Math.Abs(islandA[i][0] - islandB[j][0]) + Math.Abs(islandA[i][1] - islandB[j][1]);
                    result = Math.Min(result, temp);
                }
            }

            return result;
        }


        public void BFS(int x, int y, List<int[]> coord, int[][] A)
        {
            Queue<int[]> q = new Queue<int[]>();

            q.Enqueue(new int[] { x, y });

            while (q.Count != 0)
            {
                var node = q.Dequeue();
                coord.Add(node);
                foreach (var dir in directions)
                {
                    int tempx = dir[0] + node[0];
                    int tempy = dir[1] + node[1];

                    if (tempx >= 0 && tempx < A.Length && tempy >= 0 && tempy < A[0].Length && A[tempx][tempy] == 1)
                    {
                        q.Enqueue(new int[] { tempx, tempy });
                    }
                }
            }
        }
    }
}
