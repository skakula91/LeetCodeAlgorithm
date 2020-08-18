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
            //int[] a = {1,2,3 };
            //var subsets = new CountingSubsets().CombinationSum(a, 3);

            //** 7. Combination sums II **//
            //int[] a = { 2, 5, 2, 1, 2 };
            //var subsets = new CombinationII().CombinationSum2(a, 5);

            //** 8. check if sum possible **//
            //long[] a = { 1,1 };
            //var subsets =  TargetSum.check_if_sum_possible(a, 0);

            //** 9. Generate Paranthesis **//
            //var subsets =  new GenerateParanthesis().GenerateParenthesis(3);
            //foreach(string str in subsets)
            //{
            //    Console.WriteLine(str);
            //}

            //** 10. Valid Paranthesis **//
            //var count =  new ValidParanthesis().LongestValidParentheses("()");
            //Console.WriteLine(count);

            //** 11. N Queen **//
            //var strs = new NQueen().SolveNQueens(4);
            //foreach(var str in strs)
            //{
            //    foreach (var s in str)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //** 12. Palindrome Partitioning **//
            //var strs = new PalindromePartitioning().Partition("aab");
            //foreach (var str in strs)
            //{
            //    foreach (var s in str)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //** 13. Task scheduler **//
            //char[] tasks = { 'A', 'A', 'A', 'B', 'B', 'B' };
            //var intervals = new TaskSheduduler().LeastInterval(tasks, 2);
            //Console.WriteLine(intervals);

            //** 14. K Closest Points to Origin **//
            // use min heap of size k - revisit
            //int[][] points = {new int[] {1, 3}, new int[] {-2, 2}};
            //var closestPoints = new TopKClosestpoints().KClosest(points, 1);
            //Console.WriteLine(intervals);

            //** 15. Combinations of length K **//
            var combinations = new Combinations().GenerateCombination("abcde", 4);
            foreach (var s in combinations)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
