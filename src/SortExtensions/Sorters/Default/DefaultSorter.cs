using System;
using System.Collections.Generic;
using System.Linq;

namespace SortExtensions.Sorters.Default
{
    /// <summary>
    /// Sorts the elements of a zero-based collection with the default .NET implementation of Array.Sort Method.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n log n).
    /// Best-case performance O(n).
    /// To learn more, see https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=netcore-3.1
    /// </remarks>
    public sealed class DefaultSorter: ISorter
    {
        public IList<T> Sort<T>(IList<T> source, int index, int length, IComparer<T> comparer)
        {
            var array = source.ToArray();
            Array.Sort(array, index, length, comparer);
            return array;
        }
    }
}