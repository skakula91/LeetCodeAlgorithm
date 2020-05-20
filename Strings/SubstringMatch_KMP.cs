using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class SubstringMatch_KMP
    {
        public bool SubstringIndex(string str, string pattern)
        {
            int[] kmpTable = new int[pattern.Length];
            int i = 0;
            int j = i+1;
            while(j < pattern.Length)
            {
                if(pattern[i] == pattern[j])
                {
                    kmpTable[j] = i + 1;
                    i++; j++;
                }
                else
                {
                    kmpTable[j] = 0;
                    if(i == 0)
                    {
                        kmpTable[i] = 0;
                    }
                    else
                    {
                       i = kmpTable[i-1];
                    }
                    j++;
                }
            }
            int x = 0;
            int k = 0;
            while(k <str.Length)
            {        
                if(str[k] == pattern[x])
                {
                    k++;
                    x++;
                }
                else
                {
                    if(k == 0)
                    {
                        x = 0;
                        k++;
                    }
                    else
                    {
                        x = kmpTable[x];
                    }
                }
                if(x == pattern.Length-1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
