using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    public class MinDeletionstoMakeFrequencyofEachLetterUnique
    {
        public int minDelete(string s)
        {
            int result = 0;
            int[] arr = new int[26];
            foreach(var c in s)
            {
                arr[c - 'a']++;
            }
            SortedDictionary<int, int> dict = new SortedDictionary<int, int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    if(!dict.ContainsKey(arr[i]))
                    {
                        dict.Add(arr[i], 0);
                    }
                    dict[arr[i]]++;
                }
            }

            int count = dict.Count;
            for (int i = 0; i < count; i++)
            {
                var kvp = dict.ElementAt(i);
                if (kvp.Key == 0)
                    break;

                while(dict.ElementAt(i).Value > 1)
                {
                   int temp = dict[kvp.Key];
                   result++;
                   temp--;
                   dict[kvp.Key]--;
                   if(dict.ContainsKey(kvp.Key - 1))
                   {
                       dict[kvp.Key - 1]++;
                   }
                   else
                   {
                        dict.Add(kvp.Key - 1, 1);
                        count = dict.Count;
                   }
                }
            }

            return result;
        }
    }
}
