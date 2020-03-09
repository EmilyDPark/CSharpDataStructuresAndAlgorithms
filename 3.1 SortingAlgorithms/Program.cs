using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------- Bubble Sort --------------------
            var bubbleNumbers = new[] { 7, 3, 1, 4, 6, 2, 3 };
            var bubbleSorter = new BubbleSort();
            bubbleSorter.Sort(bubbleNumbers);
            Console.WriteLine($"[{string.Join(", ", bubbleNumbers)}]");

            // -------------------- Selection Sort --------------------
            var selectionNumbers = new[] { 7, 3, 1, 4, 6, 2, 3 };
            var selectionSorter = new SelectionSort();
            selectionSorter.Sort(selectionNumbers);
            Console.WriteLine("[{0}]", string.Join(", ", selectionNumbers));

            // -------------------- Insertion Sort --------------------
            var insertionNumbers = new[] { 7, 3, 1, 4, 6, 2, 3 };
            var insertionSorter = new InsertionSort();
            insertionSorter.Sort(insertionNumbers);
            Console.WriteLine("[{0}]", string.Join(", ", insertionNumbers));

            // -------------------- Merge Sort --------------------
            int[] mergeNumbers = { 7, 3, 1, 4, 6, 2, 3 };
            var mergeSorter = new MergeSort();
            mergeSorter.Sort(mergeNumbers);
            Console.WriteLine("[{0}]", string.Join(", ", mergeNumbers));

            // -------------------- Quick Sort --------------------
            int[] quickNumbers = { 7, 3, 1, 4, 6, 2, 3 };
            var quickSorter = new QuickSort();
            quickSorter.Sort(quickNumbers);
            Console.WriteLine("[{0}]", string.Join(", ", quickNumbers));

            // -------------------- Counting Sort --------------------
            int[] countingNumbers = { 7, 3, 1, 4, 6, 2, 3 };
            var countingSorter = new CountingSort();
            countingSorter.Sort(countingNumbers);
            Console.WriteLine("[{0}]", string.Join(", ", countingNumbers));

            // -------------------- Bucket Sort --------------------
            int[] bucketNumbers = { 7, 3, 1, 4, 6, 2, 3 };
            var bucketSorter = new BucketSort();
            bucketSorter.Sort(bucketNumbers, 3);
            Console.WriteLine("[{0}]", string.Join(", ", bucketNumbers));
        }
    }
}
