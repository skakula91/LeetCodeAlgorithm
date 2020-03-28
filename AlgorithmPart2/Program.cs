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
            //int[] a = { 1, 2, 3 };
            //var result = Permutations.Permute(a);
            //for(int i = 0; i <result.Count; i++)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    for (int j =0; j< result[i].Count; j++)
            //    {
            //        sb.Append(result[i][j].ToString());
            //    }
            //    Console.WriteLine(sb);
            //}

            //** 3. Letter permutations **//
            //string s = "a1b2";
            //var strArr = new LetterPermutations().LetterCasePermutation(s);
            //foreach(var str in strArr)
            //{
            //    Console.WriteLine(str);
            //}

            //** 4. Letter Combinations of a Phone Number **//
            //string s = "23";
            //var strArr = new LetterCombinationPhoneNumber().LetterCombinations(s);
            //foreach (var str in strArr)
            //{
            //    Console.WriteLine(str);
            //}

            //** 5. Subsets **//
            //int[] a = { 1, 2, 3 };
            //var subsets = new Subsets().SubsetsList(a);

            //** 6. Counting Subsets **//
            int[] a = {1,2,3 };
            var subsets = new CountingSubsets().CombinationSum(a, 3);
            Console.Read();
        }
    }
}
