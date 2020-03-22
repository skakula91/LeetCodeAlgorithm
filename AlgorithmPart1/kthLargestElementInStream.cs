using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    // Min heap
    //Example
   //    int k = 3;
   //    int[] arr = [4, 5, 8, 2];
   //    KthLargest kthLargest = new KthLargest(3, arr);
   //    kthLargest.add(3);   // returns 4
   //kthLargest.add(5);   // returns 5
   //kthLargest.add(10);  // returns 5
  //kthLargest.add(9);   // returns 8
  //kthLargest.add(4);   // returns 8
    public class kthLargestElementInStream
    {
        private int[] heap;
        public void KthLargest(int k, int[] nums)
        {
            heap = new int[k];
            for (int j = 0; j < k; j++)
            {
                heap[j] = j < nums.Length ? nums[j] : int.MinValue;
            }
            for (int i = (k / 2); i >= 0; i--)
            {
                Heapify(i);
            }
            for (int j = k; j < nums.Length; j++)
            {
                Add(nums[j]);
            }
        }

        public int Add(int val)
        {
            if (val > heap[0])
            {
                heap[0] = val;
                Heapify(0);
            }
            return heap[0];
        }


        public void Heapify(int index)
        {
            int smallest = index;
            int right = (2 * index) + 2;
            int left = (2 * index) + 1;
            if (left < heap.Length && heap[left] < heap[smallest])
                smallest = left;
            if (right < heap.Length && heap[right] < heap[smallest])
                smallest = right;
            if (index != smallest)
            {
                int temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;
                Heapify(smallest);
            }
        }
    }
}
