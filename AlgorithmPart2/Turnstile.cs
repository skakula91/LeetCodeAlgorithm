using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace AlgorithmPart2
{
    public class Turnstile
    {
        public int[] getTimes(int numCustomers, int[] arrTime, int[] direction)
        {
            Queue<int[]> entry = new Queue<int[]>();
            Queue<int[]> exit = new Queue<int[]>();
            int[] result = new int[numCustomers];
            int time = 0;
            int prev = -1;

            int i = 0;
            while(i < numCustomers || entry.Count != 0 || exit.Count != 0)
            {
                while (i < numCustomers && arrTime[i] <= time)
                {
                    if (direction[i] == 1)
                    {
                        exit.Enqueue(new int[] { arrTime[i], i });
                    }
                    else
                    {
                        entry.Enqueue(new int[] { arrTime[i], i });
                    }

                    i++;
                }

                if (entry.Count == 0 && exit.Count == 0)
                {
                    prev = -1;
                    time++;
                    continue;
                }

                if (entry.Count != 0 && exit.Count != 0)
                {
                    if (prev == -1 || prev == 1)
                    {
                        var node = exit.Dequeue();
                        result[node[1]] = time;
                        time++;
                        prev = 1;
                    }
                    else
                    {
                        var node = entry.Dequeue();
                        result[node[1]] = time;
                        time++;
                        prev = 0;
                    }
                    continue;
                }

                if (entry.Count != 0)
                {
                    var node = entry.Dequeue();
                    result[node[1]] = time;
                    time++;
                    prev = 0;
                    continue;
                }

                if (exit.Count != 0)
                {
                    var node = exit.Dequeue();
                    result[node[1]] = time;
                    time++;
                    prev = 1;
                    continue;
                }

            }

          
            return result;
        }
    }
}
