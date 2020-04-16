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

            // 3. Counting subset of size k
            var count = new UniquePaths().UniquePathsCount(2, 2);
            Console.WriteLine(count);
            Console.Read();
        }
    }
}
