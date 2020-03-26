using System;
using System.Text;

namespace AlgorithmPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //** 1. Towers of Hanoii **//
            //TowersOfHanoii.Towers(3, 'a','b','c');

            //** 2. Permutations **//
            int[] a = { 1, 2, 3 };
            var result = Permutations.Permute(a);
            for(int i = 0; i <result.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                for (int j =0; j< result[i].Count; j++)
                {
                    sb.Append(result[i][j].ToString());
                }
                Console.WriteLine(sb);
            }
            Console.Read();
        }
    }
}
