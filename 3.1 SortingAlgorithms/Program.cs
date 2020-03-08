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

            // Old way to print an array
            //foreach (var i in bubbleNumbers)
            //    Console.WriteLine(i); // 1 2 3 3 4 6 7

            // New way to print an array
            //Array.ForEach(bubbleNumbers, Console.WriteLine); // 1 2 3 3 4 6 7

            // Print an array like Java
            Console.WriteLine($"[{string.Join(", ", bubbleNumbers)}]"); // [1, 2, 3, 3, 4, 6, 7]

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
            Console.WriteLine("[{0}]", string.Join(", ", mergeNumbers)); // [1, 2, 3, 3, 4, 6, 7]
        }
    }
}
