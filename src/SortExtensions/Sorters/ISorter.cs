using System.Collections.Generic;

namespace SortExtensions.Sorters
{
    public interface ISorter
    {
        /// <summary>
        /// Sorts a zero-base collection in ascending order. 
        /// </summary>
        /// <param name="source">Collection of elements</param>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <param name="comparer">Comparer</param>
        /// <typeparam name="T">Element type, must be IComparable</typeparam>
        /// <returns>Sorted collection</returns>
        IList<T> Sort<T>(IList<T> source, int index, int length, IComparer<T> comparer);
    }
}