using System;
using System.Collections.Generic;

namespace AlgorithmPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            // **** 1. Algorithm: Two sum ****//
            //int[] a = { 2, 7,5,11, 15 };
            //var value = TwoSum.Sum(a,12);
            //Console.WriteLine(value[0] + " " + value[1]);

            // **** 3. Algorithm: Length of Longest Substring ****//
            //var longestString = LengthOfLongestSubstring.LongestSubstring("abba");
            //Console.WriteLine(longestString);

            // **** 4. Algorithm: Median of two sorted Arrays ****//
            //int[] nums1 = { 1, 3 };
            //int[] nums2 = { 2, 4 };
            //double med = Median.FindMedianSortedArrays(nums1, nums2);
            //Console.WriteLine(med);

            // **** 5. Algorithm: Longest Palindromic Substring ****//
            //var longestString = LongestPalindrome.Palindrome("babad");
            //Console.WriteLine(longestString);


            // **** 7. Algorithm: Reverse Integer ****//
            //var reverseIntegerVal = ReverseInteger.Reverse(123);
            //Console.WriteLine(reverseIntegerVal);

            // **** 9. Algorithm: Integer Palindrome ****//
            //var isPalindrome = IntegerPalindrome.IsPalindrome(0);
            //Console.WriteLine(isPalindrome);

            //****10.Algorithm: Regular Expression Match ****//
            // var ismatch = RegularExpressionMatching.IsMatch("ab",".*c");
            //Console.WriteLine(ismatch);

            //****11.Three sum ****//
            // int[] array = { -1, 0, 1, 2, -1, -4 };
            //var list = ThreeSum.ThreeSums(array);
            // Console.WriteLine(ismatch);

            //****12.Increasing Decreasing String ****//
            //String s = "vrwhhkaydscvllvcsdyakhhwrv";
            //var str = IncreasingDecreasingString.SortString(s);
            //Console.WriteLine(str);

            //****13.Reverse string ****//
            //String s = "teststring";
            //var str = ReverseString.Reverse(s, 2);
            //Console.WriteLine(str);

            //****14.Group anagrams****//
            //String[] s = {"eat", "tea", "tan", "ate", "nat", "bat"};
            //var anagramLst = GroupAnagrams.Anagram(s);
            //foreach(var val in anagramLst)
            //{
            //    foreach(String str in val)
            //    {
            //        Console.WriteLine(str);
            //    }
            //}

            //****15.Binary gap ****//
            //var gap = BinaryGap.Gap(5);
            //Console.WriteLine(gap);

            //****16.Search in Rotated Sorted Array****//
            //int[] a = {4, 5, 6, 7, 0, 1, 2};
            //var index = SearchinRotatedSortedArray.Search(a, 0);
            //Console.WriteLine(index);

            //****17.Search in Rotated Sorted Array****//
            //var str = ReorganizeString.Reorganize("aaabbc");
            //Console.WriteLine(str);

            //****18.Longest Valid parantheses****//
            //int count = LongestValidParanthesis.LongestValidParentheses(")()");
            //Console.WriteLine(count);

            //****19.Kth Largest Element****//
            //int[] a = { 4, 5, 6, 7, 0, 1, 2 };
            //int element = new KthLargestNuminArr().FindKthLargest(a,2);
            //Console.WriteLine(element);

            //****20.Meeting Rooms****//
            //int[][] meetings = { new int[] {7,10 } , new int[] {2, 4 } };
            //bool canAttend = MeetingRooms.CanAttendMeetings(meetings);
            //Console.WriteLine(canAttend);

            //****21.Sum of Even Numbers After Queries****//
            //int[][] queries = { new int[] { 1, 0 }, new int[] { -3, 1 }, new int[] { -4, 0 }, new int[] { 2, 3 } };
            //int[] array = { 1, 2, 3, 4 };
            //int[] result = SumOfEvenNumberQuery.SumEvenAfterQueries(array, queries);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //****22.Binary Strings****//
            //List<string> result = BinaryStrings.Binary(4);
            //foreach (var str in result)
            //{
            //    Console.WriteLine(str);
            //}
            BinaryStrings.BinaryDFS(3);
            Console.Read();
        }
    }
}
