using System;

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
            int[][] input = {new int[] {1, 2, 5}, new int[] {3, 2, 1}};
            var pathSum = new MinPathsum().Pathsum(input);
            Console.WriteLine(pathSum);
            Console.Read();
        }
    }
}
