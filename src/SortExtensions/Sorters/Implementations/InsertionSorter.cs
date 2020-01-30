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
        protected override void SortCore<T>(T[] sortingData, int index, int length, IComparer<T> comparer)
        {
            var lastIndex = index + length - 1;
            for (var baseIndex = index + 1; baseIndex <= lastIndex; baseIndex++)
            {
                for (var current = baseIndex;
                    current > index && comparer.Compare(sortingData[current], sortingData[current - 1]) < 0;
                    current--)
                {
                    Swap(sortingData, current, current - 1);
                }
            }
        }
    }
}