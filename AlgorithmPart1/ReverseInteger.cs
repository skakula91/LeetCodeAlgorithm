using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    // Given a 32-bit signed integer, reverse digits of an integer.
    //Example 1:
    // Input: 123
    //Output: 321

    //Example 2:
    // Input: -123
    //Output: -321

    //Example 3:
    // Input: 120
    //Output: 21

    //    Note:
    //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: 
    //[−231,  231 − 1]. For the purpose of this problem, assume that your function returns 0 when the 
    //reversed integer overflows.
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            long reverseNum = 0;
            while (x != 0)
            {
                reverseNum = reverseNum * 10 + (x % 10);
                x = x / 10;
            }
            return (reverseNum > Int32.MaxValue || reverseNum < Int32.MinValue) ? 0 : (int)reverseNum;
        }
    }
}

