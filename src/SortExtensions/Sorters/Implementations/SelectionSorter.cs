using System;
using System.Collections.Generic;
using static SortExtensions.Helpers.SwapHelper;

namespace SortExtensions.Sorters.Implementations
{
    /// <summary>
    /// The Selection Sort Algorithm implementation for a generic zero-based collection.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n^2).
    /// Best-case performance O(n^2).
    /// To learn more, see https://en.wikipedia.org/wiki/Selection_sort
    /// </remarks>
    internal sealed class SelectionSorter : Sorter
    {
        protected override void SortCore<T>(Span<T> sortingData, IComparer<T> comparer)
        {
            // For each iteration increase first index, cause it's already sorted.
            for (var first = 0; first < sortingData.Length - 1; first++)
            {
                // Compare current and next elements, swap if needed.
                // Ascending order sort.
                var min = first;
                for (var current = first + 1; current < sortingData.Length; current++)
                {
                    if (comparer.Compare(sortingData[min], sortingData[current]) > 0)
                    {
                        min = current;
                    }
                }

                if (first != min)
                {
                    Swap(sortingData, first, min);
                }
            }
        }
    }
}