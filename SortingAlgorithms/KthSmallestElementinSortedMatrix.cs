using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class KthSmallestElementinSortedMatrix
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            int result = 0;

            SortedList<int, (int, int)> list = new SortedList<int, (int, int)>(Comparer<int>.Create((a, b) => a != b ? a.CompareTo(b) : a));

            for (int i = 0; i < matrix.Length; i++)
            {
                list.Add(matrix[i][0], (i, 0));
            }


            while (k > 0)
            {
                k--;
                result = list.First().Key;
                int x = list.First().Value.Item1;
                int y = list.First().Value.Item2;
                list.RemoveAt(0);

                if (y < matrix[0].Length - 1)
                {
                    list.Add(matrix[x][y + 1], (x, y + 1));
                }
            }

            return result;
        }
    }
}
