using System;
using System.Collections.Generic;
using System.Linq;

namespace SortExtensions.Sorters.Default
{
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