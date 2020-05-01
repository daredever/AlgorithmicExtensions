using System;
using System.Collections.Generic;
using static SortExtensions.Helpers.SwapHelper;

namespace SortExtensions.Sorters.Implementations
{
    /// <summary>
    /// The Insertion Sort Algorithm implementation for a generic zero-based collection.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n^2).
    /// Best-case performance O(n).
    /// To learn more, see https://en.wikipedia.org/wiki/Insertion_sort
    /// </remarks>
    public class InsertionSorter : Sorter
    {
        protected override void SortCore<T>(Span<T> sortingData, IComparer<T> comparer)
        {
            for (var last = 1; last < sortingData.Length; last++)
            {
                for (var current = last;
                    current > 0 && comparer.Compare(sortingData[current], sortingData[current - 1]) < 0;
                    current--)
                {
                    Swap(sortingData, current, current - 1);
                }
            }
        }
    }
}