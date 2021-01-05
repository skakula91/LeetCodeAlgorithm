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
            int j = 1;
            while(j < pattern.Length)
            {
                if(pattern[i] == pattern[j])
                {
                    kmpTable[j] = i + 1;
                    i++; j++;
                }
                else
                {
                    if (i == 0)
                    {
                        j++;
                    }
                    else
                    {
                        i = kmpTable[i - 1];
                    }
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
                    if (x == pattern.Length)
                    {
                        return true;
                    }                    
                }
                else
                {
                    if(x == 0)
                    {
                        k++;
                    }
                    else
                    {
                        x = kmpTable[x-1];
                    }
                }            
            }
            return false;
        }
    }
}
