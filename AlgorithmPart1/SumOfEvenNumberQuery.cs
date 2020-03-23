using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class SumOfEvenNumberQuery
    {
        public static int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            int[] rest = new int[queries.Length];
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    sum = sum + A[i];
                }
            }

            int resultSum = sum;
            for (int j = 0; j < queries.Length; j++)
            {
                int addVal = queries[j][0];
                int pos = queries[j][1];
                if ((A[pos] + addVal) % 2 == 0)
                {
                    if (A[pos] % 2 != 0)
                    {
                        rest[j] = resultSum + A[pos] + addVal;
                    }
                    else
                    {
                        rest[j] = resultSum  + addVal;
                    }
                    resultSum = rest[j];
                }

                else if (A[pos] % 2 == 0)
                {
                    resultSum = resultSum - A[pos];
                    rest[j] = resultSum;
                }
                else
                {
                    rest[j] = resultSum;
                }
                A[pos] = A[pos] + addVal;
            }
            return rest;
        }
    }
}
