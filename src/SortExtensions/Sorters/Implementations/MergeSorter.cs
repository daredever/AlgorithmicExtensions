using System;
using System.Collections.Generic;
using System.Linq;

namespace SortExtensions.Sorters.Implementations
{
    /// <summary>
    /// The Merge Sort Algorithm implementation for a generic zero-based collection.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n log n).
    /// Best-case performance O(n).
    /// To learn more, see https://en.wikipedia.org/wiki/Merge_sort
    /// </remarks>
    public class MergeSorter : Sorter
    {
        protected override void SortCore<T>(Span<T> sortingData, IComparer<T> comparer)
        {
            MergeSort(sortingData, 0, sortingData.Length - 1, comparer);
        }

        private static void MergeSort<T>(Span<T> sortingData, int low, int high, IComparer<T> comparer)
        {
            if (low >= high)
            {
                return;
            }

            var middle = (low + high) / 2;
            MergeSort(sortingData, low, middle, comparer);
            MergeSort(sortingData, middle + 1, high, comparer);
            Merge(sortingData, low, middle, high, comparer);
        }
        
        private static void Merge<T>(Span<T> sortingData, int low, int middle, int high, IComparer<T> comparer)
        {
            // Prepare left sorted part for merging.
            var leftSortedPart = new Queue<T>(middle - low + 1);
            for (var index = low; index <= middle; index++)
            {
                leftSortedPart.Enqueue(sortingData[index]);
            }

            // Prepare right sorted part for merging.
            var rightSortedPart = new Queue<T>(high - middle);
            for (var index = middle + 1; index <= high; index++)
            {
                rightSortedPart.Enqueue(sortingData[index]);
            }

            // Merge sorted data and update sorting collection.
            var current = low;
            while (leftSortedPart.TryPeek(out var leftElement) & rightSortedPart.TryPeek(out var rightElement))
            {
                var rightElementIsGreater = comparer.Compare(leftElement, rightElement) > 0;
                sortingData[current++] = rightElementIsGreater ? rightSortedPart.Dequeue() : leftSortedPart.Dequeue();
            }

            // Update sorting collection by residue.
            var residue = leftSortedPart.Concat(rightSortedPart);
            foreach (var element in residue)
            {
                sortingData[current++] = element;
            }
        }
    }
}