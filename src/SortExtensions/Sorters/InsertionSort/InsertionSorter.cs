using System.Collections.Generic;
using static SortExtensions.Helpers.SwapHelper;

namespace SortExtensions.Sorters.InsertionSort
{
    /// <summary>
    /// The Insertion Sort Algorithm for a generic zero-based collection.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n^2).
    /// Best-case performance O(n).
    /// To learn more, see https://en.wikipedia.org/wiki/Insertion_sort
    /// </remarks>
    public class InsertionSorter : ISorter
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

            // The Insertion Sort Algorithm core.
            var lastIndex = index + length - 1;
            for (var baseIndex = index + 1; baseIndex <= lastIndex; baseIndex++)
            {
                var current = baseIndex;
                while (current > index && comparer.Compare(sortedData[current], sortedData[current - 1]) < 0)
                {
                    Swap(sortedData, current, current - 1);
                    current--;
                }
            }

            return sortedData;
        }
    }
}