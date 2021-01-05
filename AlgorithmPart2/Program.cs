using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // **1.Towers of Hanoii **//
            //TowersOfHanoii.Towers(3, '1', '2', '3');

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
            // var combinations = new Combinations().GenerateCombination("abcde", 4);
            //foreach (var s in combinations)
            //{
            //    Console.WriteLine(s);
            //}

            //** 16. Find Right Interval **//
            //int[][] input = {new int[] {3, 4}, new int[] {2, 3}, new int[] {1, 2}};
            //var resultFindRight = new FindRightInterval().FindRight(input);
            //foreach (var s in resultFindRight)
            //{
            //    Console.WriteLine(s);
            //}

            //** 17. Subset Product Less Than K **//
            //int[] a = {1,2,3 };
            //var result = new SubsetProductLessThanK().NumSubarrayProductLessThanK(a, 6);
            //Console.WriteLine(result);

            //** 18. Complement of Base 10 Integer **//
            //var result = new BitWiseComplement().BitwiseComplement(5);
            // Console.WriteLine(result);

            //** 19. Throttling connections **// 
            //int[] a = new[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 7, 11, 11, 11, 11 };
            //var result = new ThrottlingGateway().DroppedConnections(a);
            //Console.WriteLine(result);

            //** 20. Find Fruit Combs  **// 
            //string[] shoppingCart = { "orange", "apple", "banana", "orange", "apple", "orange", "orange", "banana", "apple", "banana" };
            //string[][] codeList = { new string[]{ "anything", "anything", "anything", "apple" }, new string[] { "banana", "anything", "banana" } };
            //var result =  FindFruitCombs.winPrize(codeList,shoppingCart);

            //** 21. Items in Containers  **// 
            //string str = "*|**|***|";
            //var result = ItemInContainer.NumberOfItems(str, new List<int>(){ 1, 2, 4, 1 },new List<int>(){ 4, 6, 6, 9 });

            //** 22. Turnstile **// 
            //int numOfCustomers = 5;
            //int[] arrival = { 0, 1, 1, 3, 3 };
            //int[] direction = { 0, 1, 0, 0, 1 };
            //var result = new Turnstile().getTimes(numOfCustomers,arrival,direction);

            //** 23. Minimum Difficulty of a Job Schedule **// 
            int[] jobDifficulty = { 6, 5, 4, 3, 2, 1 };
            var result = new MinimumDiffcultyofJobSchedule().MinDifficulty(jobDifficulty, 2);
            Console.WriteLine(result);

            //** 24. Utilization checks **//
            //int[] utilization = { 0, 5, 4, 8, 19, 89 };
            //var result =  UtilizationChecks.solution(5, utilization.ToList());
            //Console.WriteLine(result);

            //** 25. Substring of size K **//
            //string inputString = "wawaglknagagwunagkwkwagl";
            //var result = new SubstringofSizeK().Solve(inputString,4);

            //** 26. Transaction logs **//
            //string[] input = { "345366 89921 45", "029323 38239 23", "38239 345366 15", "029323 38239 77", "345366 38239 23", "029323 345366 13", "38239 38239 23" };
            //var result = new TransactionLogs().Solve(input, 3);

            //** 27. Shopping Patterns **//
            //int[] products_from = { 1, 2, 2, 3, 4, 5 };
            //int[] products_to = { 2, 4, 5, 5, 5, 6 };
            //var result = new ShoppingPatterns().Solve(6, products_from, products_to);

            //** 28. Five star sellers **//
            //int[][] productRatings = {new int[]{4,4},new int[]{1,2},new int[]{3,6},new int[] { 4, 14 }, new int[] { 1, 22 }, new int[] { 3, 16 }, new int[] { 4, 24 }, new int[] { 0, 2 }, new int[] { 6, 6 } };
            //var result = new FiveStarSellers().Solve(productRatings,90);
            Console.Read();
        }
    }
}
