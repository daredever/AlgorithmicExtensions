using System;
using System.Collections.Generic;
using static SortExtensions.Helpers.SwapHelper;

namespace SortExtensions.Sorters.SelectionSort
{
    /// <summary>
    /// The Selection Sort Algorithm for a generic zero-based collection.
    /// <remarks>
    /// Worst-case performance O(n^2).
    /// Best-case performance O(n^2).
    /// To learn more, see https://en.wikipedia.org/wiki/Selection_sort.
    /// </remarks>
    /// </summary>
    public sealed class SelectionSorter : ISorter
    {
        public IList<T> Sort<T>(IList<T> source, int index, int length)
            where T : IComparable
        {
            // Copy input data.
            var sortedData = new T[source.Count];
            source.CopyTo(sortedData, 0);

            // Do not need sorting empty section or section with only one element.
            if (length <= 1)
            {
                return sortedData;
            }

            // The Selection Sort Algorithm core.
            // For each iteration increase first index, cause it's already sorted.
            var lastIndex = index + length - 1;
            for (var firstIndex = index; firstIndex < lastIndex; firstIndex++)
            {
                // Compare current and next elements, swap if needed.
                // Ascending order sort.
                var minIndex = firstIndex;
                for (var current = firstIndex + 1; current <= lastIndex; current++)
                {
                    if (sortedData[current].CompareTo(sortedData[minIndex]) < 0)
                    {
                        minIndex = current;
                    }
                }

                if (firstIndex != minIndex)
                {
                    Swap(sortedData, firstIndex, minIndex);
                }
            }

            return sortedData;
        }
    }
}