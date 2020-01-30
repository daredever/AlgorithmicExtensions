using System.Collections.Generic;

namespace SortExtensions.Sorters
{
    /// <summary>
    /// Base sorter implementation for a generic zero-based collection.
    /// </summary>
    public abstract class Sorter : ISorter
    {
        public IList<T> Sort<T>(IList<T> source, int index, int length, IComparer<T> comparer)
        {
            // Copy input data.
            var sortingData = new T[source.Count];
            source.CopyTo(sortingData, 0);

            // Do not need sorting empty section or section with only one element.
            if (length <= 1)
            {
                return sortingData;
            }

            //A Sort Algorithm core.
            SortCore(sortingData, index, length, comparer);

            return sortingData;
        }

        protected abstract void SortCore<T>(T[] sortingData, int index, int length, IComparer<T> comparer);
    }
}