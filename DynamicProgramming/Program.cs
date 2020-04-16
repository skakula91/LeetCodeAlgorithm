using System;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Climbing Stairs
            var uniqueWay = new Climbingstairs().ClimbStairs(3);
            Console.WriteLine(uniqueWay);
            Console.Read();
        }
    }
}
