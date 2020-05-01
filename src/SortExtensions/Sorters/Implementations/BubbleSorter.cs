using System;
using System.Collections.Generic;
using static SortExtensions.Helpers.SwapHelper;

namespace SortExtensions.Sorters.Implementations
{
    /// <summary>
    /// The Bubble Sort Algorithm implementation for a generic zero-based collection.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n^2).
    /// Best-case performance O(n).
    /// To learn more, see https://en.wikipedia.org/wiki/Bubble_sort
    /// </remarks>
    internal sealed class BubbleSorter : Sorter
    {
        protected override void SortCore<T>(Span<T> sortingData, IComparer<T> comparer)
        {
            // For each iteration decrease last index, cause it's already sorted.
            for (var last = sortingData.Length - 1; last >= 0; last--)
            {
                var isSorted = true;

                // Compare current and next elements, swap if needed.
                // Ascending order sort.
                for (var current = 0; current < last; current++)
                {
                    var next = current + 1;
                    if (comparer.Compare(sortingData[current], sortingData[next]) > 0)
                    {
                        Swap(sortingData, current, next);
                        isSorted = false;
                    }
                }

                // Abort execution if there is no swapped elements,
                // cause collection has already sorted.
                if (isSorted)
                {
                    break;
                }
            }
        }
    }
}