using System;
using System.Collections.Generic;
using System.Linq;

namespace SortExtensions.Sorters.Default
{
    public class DefaultSorter: ISorter
    {
        public IList<T> Sort<T>(IList<T> source, int index, int length) where T : IComparable
        {
            var array = source.ToArray();
            Array.Sort(array, index, length);
            return array;
        }
    }
}