using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class FindMedian
    {
        List<double> maxHeap;
        List<double> minHeap;
        /** initialize your data structure here. */
        public FindMedian()
        {
            maxHeap = new List<double>(); // left
            minHeap = new List<double>(); // right
        }

        public void AddNum(int num)
        {
            if (maxHeap.Count == 0)
            {
                maxHeap.Add(num);
            }
            else if (maxHeap.Count > minHeap.Count)
            {
                if (num >= maxHeap[0]) //it belongs to minheap, and there is enough space
                {
                    minHeap.Insert(0, num);
                    Heapify_min(0);
                }
                else
                {
                    minHeap.Insert(0, maxHeap[0]);
                    maxHeap.RemoveAt(0);
                    Heapify_min(0);
                    maxHeap.Insert(0, num);
                    Heapify_max(0);
                }
            }
            else if (maxHeap.Count == minHeap.Count)
            {
                if (num <= maxHeap[0]) //it belongs to minheap, but there is no enough space
                {
                    maxHeap.Insert(0, num);
                    Heapify_max(0);

                }
                else //it belongs to maxheap and there is enough space
                {
                    maxHeap.Insert(0, minHeap[0]);
                    minHeap.RemoveAt(0);
                    Heapify_max(0);
                    minHeap.Insert(0, num);
                    Heapify_min(0);
                }
            }
        }

        public double FindMedian_val()
        {
            int count = minHeap.Count + maxHeap.Count;

            if (count == 1)
                return maxHeap[0];
            else if (count % 2 == 0)
            {
                return (minHeap[0] + maxHeap[0]) / 2.0;
            }
            else
            {
                return maxHeap[0];
            }
        }

        private void Heapify_max(int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;

            if (left < maxHeap.Count && maxHeap[left] > maxHeap[largest])
            {
                largest = left;
            }

            if (right < maxHeap.Count && maxHeap[right] > maxHeap[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                double temp = maxHeap[largest];
                maxHeap[largest] = maxHeap[index];
                maxHeap[index] = temp;
                Heapify_max(largest);
            }
        }
        private void Heapify_min(int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int smallest = index;

            if (left < minHeap.Count && minHeap[left] < minHeap[smallest])
            {
                smallest = left;
            }

            if (right < minHeap.Count && minHeap[right] < minHeap[smallest])
            {
                smallest = right;
            }

            if (smallest != index)
            {
                double temp = minHeap[smallest];
                minHeap[smallest] = minHeap[index];
                minHeap[index] = temp;
                Heapify_min(smallest);
            }
        }
    }
}
