using System;
using System.Collections.Generic;

namespace SortExtensions.Sorters
{
    public interface ISorter
    {
        IList<T> Sort<T>(IList<T> source, int index, int length) where T : IComparable;
    }
}