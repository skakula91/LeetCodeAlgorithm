using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class MeetingRoomsII
    {
        List<int> minHeap = new List<int>();
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 1 || intervals.Length == 0)
                return intervals.Length;

            intervals = intervals.OrderBy(x => x[0]).ToArray();
            minHeap.Add(intervals[0][1]);

            int count = 1;
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= minHeap[0])
                {
                    minHeap.RemoveAt(0);
                }
                else
                {
                    count++;
                }
                Insert(intervals[i][1]);
            }
            return count;

        }

        public void Insert(int data)
        {
            minHeap.Add(data);
            int count = minHeap.Count;
            for (int i = count /2-1; i >= 0; i--)
            {
                Heapify_min(i);
            }
        }

        public void Heapify_min(int index)
        {
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            int count = minHeap.Count;

            if (left < count && minHeap[left] < minHeap[smallest])
            {
                smallest = left;
            }

            if (right < count && minHeap[right] < minHeap[smallest])
            {
                smallest = right;
            }

            if (smallest != index)
            {
                int temp = minHeap[smallest];
                minHeap[smallest] = minHeap[index];
                minHeap[index] = temp;
                Heapify_min(smallest);
            }
        }
    }
}
