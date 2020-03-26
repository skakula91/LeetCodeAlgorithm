using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmPart1
{
    public class BinaryStrings
    {
        //BFS -- memory O(2pown)
        public static List<string> Binary(int n)
        {
            List<string> result = new List<string>();
            if (n == 1)
            {
                return new List<string>() { "0", "1" };
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

        //DFS -- memory O(n)
        public static void BinaryDFS(int n)
        {
            BinaryDFSHelper("", n);
        }
        private static void BinaryDFSHelper(string slate, int n)
        {
            if (n == 0)
                Console.WriteLine(slate);
            else
            {
                BinaryDFSHelper(slate + "0", n-1);
                BinaryDFSHelper(slate + "1", n-1);
            }

        }
    }
}
