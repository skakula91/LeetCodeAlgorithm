using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 0,1,3,2};
            //****1. Bubble Sort ****//
            // Time complexity : O(n^2)
            // var sortedArray = BubbleSort.Sort(array);

            //****2. Insertion sort ****//
            // Time complexity : O(n^2)
            //var sortedArray = InsertionSort.Sort(array);

            //****3. Merge sort ****//
            //Time complexity : O(nlogn)
            //array = MergeSort.Sort(array);

            //****4. Quick sort ****//
            // Time complexity best case: O(nlogn)
            // Time complexity best case: O(n^2)
            //QuickSort.Sort(array, 0, array.Length - 1);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //****5. Heap sort ****//
            //int[] array = { 10, 64, 7, 52, 32, 18, 2, 48 };
            //HeapSort hs = new HeapSort();
            //hs.Build_Max_Heap(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //int[] array1 = { 4, 5, 6, 7, 0, 1, 2 };
            //int index = BinarySearch.Search(array1, 0);
            //Console.WriteLine(index);


            //****6. FindMedian ****//
            FindMedian fm = new FindMedian();
            fm.AddNum(40);
            Console.Write(fm.FindMedian_val());
            fm.AddNum(12);
            Console.Write(fm.FindMedian_val());
            fm.AddNum(16);
            Console.Write(fm.FindMedian_val());
            //fm.AddNum(4);
            //Console.Write(fm.FindMedian_val());
            //fm.AddNum(5);
            //Console.Write(fm.FindMedian_val());
            //fm.AddNum(6);
            //Console.Write(fm.FindMedian_val());
            //fm.AddNum(7);
            //Console.Write(fm.FindMedian_val());
            //fm.AddNum(8);
            //Console.Write(fm.FindMedian_val());
            //fm.AddNum(9);
            //Console.Write(fm.FindMedian_val());
            //fm.AddNum(10);
            //Console.Write(fm.FindMedian_val());

            Console.Read();
        }
    }
}
