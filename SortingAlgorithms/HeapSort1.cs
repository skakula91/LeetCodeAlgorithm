using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class HeapSort1
    {
        public void Max_heapify(int[] arr, int heapSize, int index)
        {
            int right = 2 * index + 1;
            int left = 2 * index + 2;
            int largest = index;

            if (left < heapSize && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < heapSize && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                int temp = arr[index];
                arr[index] = arr[largest];
                arr[largest] = temp;
                Max_heapify(arr, heapSize, largest);
            }

        }
        public void Build_Max_Heap(int[] arr)
        {
            for(int i = (arr.Length/2)-1; i >= 0; i--)
            {
                Max_heapify(arr, arr.Length, i);
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // Move current root to end 
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap 
                Max_heapify(arr, i, 0);
            }
        }
    }
}
