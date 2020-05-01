using System;
using System.Collections.Generic;

namespace SortExtensions.Sorters
{
    /// <summary>
    /// Base sorter implementation for a generic zero-based collection.
    /// </summary>
    public abstract class Sorter : ISorter
    {
        public IList<T> Sort<T>(IList<T> source, int index, int length, IComparer<T> comparer = null)
        {
            // Copy input data.
            var sortingSource = new T[source.Count];
            source.CopyTo(sortingSource, 0);

            // Do not need sorting empty section or section with only one element.
            if (length <= 1)
            {
                return sortingSource;
            }

            // A Sort Algorithm core.
            var sortingData = new Span<T>(sortingSource, index, length);
            SortCore(sortingData, comparer ?? Comparer<T>.Default);

            return sortingSource;
        }

        protected abstract void SortCore<T>(Span<T> sortingData, IComparer<T> comparer);
    }
}