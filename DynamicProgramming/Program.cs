using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Climbing Stairs
            //var uniqueWay = new Climbingstairs().ClimbStairs(3);
            //Console.WriteLine(uniqueWay);

            // 2. Counting subset of size k
            //var count = new CountSubsetKsize().Count(5,2);
            //Console.WriteLine(count);

            // 3. Unique paths
            //var count = new UniquePaths().UniquePathsCount(2, 2);
            //Console.WriteLine(count);

            // 4. Min path sum
            //int[][] input = {new int[] {1, 2, 5}, new int[] {3, 2, 1}};
            //var pathSum = new MinPathsum().Pathsum(input);
            //Console.WriteLine(pathSum);

            // 5. Min Cost Climbing Stairs
            // int[] input = new int[] {10, 15, 20};
            // var pathCost = new MinCostClimbingStairs().MinCostClimbingStairsSum(input);
            //Console.WriteLine(pathCost);

            // 6. Coin Change
            //int[] input = new int[] { 1, 2, 5 };
            //var numberOfCoins = new Coinschange().CoinChange(input,11);
            //Console.WriteLine(numberOfCoins);

            // 7. Rod Cutting
            //int[] prices = new int[] { 0,1,3,3,8,8,10 };
            //var maxPrice = new RodPrice().MaxPrice(prices, 6);
            //Console.WriteLine(maxPrice);

            // 8. Test for Tie - combined weight for people in group 1 should be equal to group 2
            //int[] peopleWeights = new int[] { 1, 2, 3, 4, 5, 7 };
            //var isPossible = new TestForTie().IsPossibleDp(peopleWeights);
            //Console.WriteLine(isPossible);

            // 9. Edit Distance
            //var distance = new EditDistance().Distance("ball","car");
            //Console.WriteLine(distance);

            // 10. Word Break
            //List<string>  dict = new List<string>(){ "leet", "code"};
            //bool isPossible = new WorkBreakI().WordBreak("leetcode", dict);
            //Console.WriteLine(isPossible);

            // 11. Detectcapital
            bool hasCycle = new DetectCaptial().DetectCapitalUse("waHaha");
            Console.WriteLine(hasCycle);
            Console.Read();
        }
    }
}
