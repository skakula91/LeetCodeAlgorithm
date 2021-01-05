using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class ShoppingPatterns
    {
        public int Solve(int n, int[] a, int[] b)
        {
            HashSet<(int,int)> dict = new HashSet<(int, int)>();
            int[] degree = new int[n+1];

            for (int i = 0; i < a.Length; i++)
            {
                if (!dict.Contains((a[i], b[i])))
                {
                    dict.Add((a[i], b[i]));
                }

                if (!dict.Contains((b[i], a[i])))
                {
                    dict.Add((b[i], a[i]));
                }

                degree[a[i]]++;
                degree[b[i]]++;
            }

            int result = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (dict.Contains((i, j)) && dict.Contains((j, k)) && dict.Contains((k, i)))
                        {
                            result = Math.Min(result, degree[i] + degree[j] + degree[k] - 6);
                        }
                    }
                }
            }

            return result== Int32.MaxValue?-1: result;
        }
    }
}
