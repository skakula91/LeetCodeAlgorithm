using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AlgorithmPart2
{
    public class ItemInContainer
    {
        public static List<int> NumberOfItems(String s, List<int> start, List<int> end)
        {
            List<int>  result = new List<int>();
            Dictionary<int,int> dict = new Dictionary<int, int>();
            List<int> lst = new List<int>();

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '|')
                {
                    dict.Add(i,count);
                    lst.Add(i);
                }
                else
                {
                    if(dict.Count > 0)
                         count++;
                }
            }

            for (int i = 0; i < start.Count; i++)
            {
                int x = start[i] - 1;
                int y = end[i] - 1;
                if (!dict.ContainsKey(x))
                {
                   x= GetNextLargest(x, lst);
                }

                if (!dict.ContainsKey(y))
                {
                    y = GetPrevSmallest(y, lst);
                }

                result.Add(dict[y]-dict[x]);
            }
            return result;
        }

        public static int GetPrevSmallest(int x, List<int> lst)
        {
            if (x < lst[0])
                return lst[0];
            int i = 0;
            for (i = 0; i < lst.Count; i++)
            {
                if (lst[i] > x)
                {
                    break;
                }

            }
            return lst[i-1];
        }
        public static int GetNextLargest(int x, List<int> lst)
        {
            int count = lst.Count - 1;
            if (x > lst[count])
                return lst[count];

            int i = 0;
            for (i = 0; i <= count; i++)
            {
                if (lst[i] > x)
                {
                    break;
                }

            }
            return lst[i];
        }
    }
}
