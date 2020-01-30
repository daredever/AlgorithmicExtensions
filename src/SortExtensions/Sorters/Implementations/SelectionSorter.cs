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
    public sealed class SelectionSorter : Sorter
    {
        protected override void SortCore<T>(T[] sortingData, int index, int length, IComparer<T> comparer)
        {
            // For each iteration increase first index, cause it's already sorted.
            var lastIndex = index + length - 1;
            for (var firstIndex = index; firstIndex < lastIndex; firstIndex++)
            {
                // Compare current and next elements, swap if needed.
                // Ascending order sort.
                var minIndex = firstIndex;
                for (var current = firstIndex + 1; current <= lastIndex; current++)
                {
                    if (comparer.Compare(sortingData[current], sortingData[minIndex]) < 0)
                    {
                        minIndex = current;
                    }
                }

                if (firstIndex != minIndex)
                {
                    Swap(sortingData, firstIndex, minIndex);
                }
            }
        }
    }
}