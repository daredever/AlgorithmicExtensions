using System;
using System.Collections.Generic;
using SortExtensions.Sorters;

namespace SortExtensions.Helpers
{
    internal static class SortHelper
    {
        internal static IList<T> ListSort<T>(IList<T> source, int index, int length, ISorter sorter,
            IComparer<T> comparer = null)
            where T : IComparable
        {
            return sorter.Sort(source, index, length, comparer ?? Comparer<T>.Default);
        }
    }
}