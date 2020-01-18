using System;
using System.Collections.Generic;
using static SortExtensions.Helpers.SwapHelper;

namespace SortExtensions.Sorters.BubbleSort
{
    /// <summary>
    /// The Bubble Sort Algorithm for a generic zero-based collection.
    /// <remarks>
    /// Worst-case performance O(n^2).
    /// Best-case performance O(n).
    /// To learn more, see https://en.wikipedia.org/wiki/Bubble_sort.
    /// </remarks>
    /// </summary>
    public sealed class BubbleSorter : ISorter
    {
        public IList<T> Sort<T>(IList<T> source, int index, int length, IComparer<T> comparer)
        {
            // Copy input data.
            var sortedData = new T[source.Count];
            source.CopyTo(sortedData, 0);

            // Do not need sorting empty section or section with only one element.
            if (length <= 1)
            {
                return sortedData;
            }

            // The Bubble Sort Algorithm core.
            // For each iteration decrease last index, cause it's already sorted.
            var isSorted = true;
            for (var lastIndex = index + length - 1; lastIndex >= index; lastIndex--)
            {
                // Compare current and next elements, swap if needed.
                // Ascending order sort.
                for (var current = index; current < lastIndex; current++)
                {
                    var next = current + 1;
                    if (comparer.Compare(sortedData[current], sortedData[next]) > 0)
                    {
                        Swap(sortedData, current, next);
                        isSorted = false;
                    }
                }

                // Abort execution if it's no swapped elements, cause collection has already sorted.
                if (isSorted)
                {
                    break;
                }
            }

            return sortedData;
        }
    }
}