using System;
using System.Collections.Generic;

namespace SortExtensions.Sorters.Implementations
{
    /// <summary>
    /// Default .NET implementation of Array.Sort Method for a generic zero-based collection.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n log n).
    /// Best-case performance O(n).
    /// To learn more, see https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=netcore-3.1
    /// </remarks>
    public sealed class DefaultSorter : Sorter
    {
        protected override void SortCore<T>(T[] sortingData, int index, int length, IComparer<T> comparer)
        {
            Array.Sort(sortingData, index, length, comparer);
        }
    }
}