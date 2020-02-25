using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public static class Median
    {
        // There are two sorted arrays nums1 and nums2 of size m and n respectively.
        //Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).
        //You may assume nums1 and nums2 cannot be both empty.

        //Example 1:
        //nums1 = [1, 3]
        //nums2 = [2]
        //The median is 2.0

        //Example 2:
        //nums1 = [1, 2]
        //nums2 = [3, 4]
        //The median is (2 + 3)/2 = 2.5

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int arrayLength = nums1.Length + nums2.Length;
            int[] nums3 = new int[arrayLength];
            int arlen1 = nums1.Length;
            int arlen2 = nums2.Length;
            int j = 0; int k = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                if (k == arlen2)
                {
                    nums3[i] = nums1[j];
                    j++;
                }
                else if (j == arlen1)
                {
                    nums3[i] = nums2[k];
                    k++;
                }
                else if (nums1[j] == nums2[k])
                {
                    nums3[i] = nums1[j];
                    i++;
                    nums3[i] = nums2[k];
                    j++; k++;

                }
                else if (nums1[j] < nums2[k])
                {
                    nums3[i] = nums1[j];
                    j++;
                }
                else
                {
                    nums3[i] = nums2[k];
                    k++;
                }
            }
            double median = 0;
            if (arrayLength % 2 != 0)
            {
                median = nums3[(arrayLength - 1) / 2];
            }
            else
            {
                median = (nums3[(arrayLength / 2) - 1] + nums3[arrayLength / 2]) / 2.0;
            }
            return median;
        }
    }
}
