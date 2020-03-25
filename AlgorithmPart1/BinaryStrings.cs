using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPart1
{
    public class BinaryStrings
    {
        public static List<string> Binary(int n)
        {
            List<string> result = new List<string>();
            if (n == 1)
            {
                return new List<string>(){"0" ,"1"};
            }
            else
            {
                var prev = Binary(n - 1);
                foreach (var str in prev)
                {
                    result.Add(str + "0");
                    result.Add(str + "1");
                }
            }

            return result;
        }
    }
}
