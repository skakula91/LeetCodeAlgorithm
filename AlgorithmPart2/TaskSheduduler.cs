using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class TaskSheduduler
    {
        public int LeastInterval(char[] tasks, int n)
        {
            int[] taskarray = new int[26];
            foreach (var task in tasks)
            {
                taskarray[task - 'A']++;
            }

            Array.Sort(taskarray);
            int idleslots = (taskarray[25] - 1) * n;

            for (int i = 24; i >= 0; i--)
            {
                idleslots = idleslots - Math.Min(taskarray[i], taskarray[25] - 1);
            }

            return idleslots > 0 ? idleslots + tasks.Length : tasks.Length;
        }
    }
}
