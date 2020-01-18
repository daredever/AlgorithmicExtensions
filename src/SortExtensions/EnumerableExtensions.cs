using System;
using System.Collections.Generic;
using System.Linq;
using SortExtensions.Sorters;
using static SortExtensions.Helpers.SortHelper;
using static SortExtensions.Helpers.ValidationHelper;

namespace SortExtensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements in the given section of the collection.
        /// </summary>
        /// <param name="source">Collection of elements</param>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <param name="sortingAlgorithm">Sorting algorithm</param>
        /// <param name="comparer">Comparer</param>
        /// <typeparam name="T">Element type, must be IComparable</typeparam>
        /// <returns>The sorted collection</returns>
        /// <exception cref="ArgumentNullException">source is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        /// <exception cref="ArgumentOutOfRangeException">wrong sorting algorithm specified</exception>
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> source, int index, int length,
            SortingAlgorithm sortingAlgorithm = SortingAlgorithm.Default, IComparer<T> comparer = null)
            where T : IComparable
        {
            CheckSource(source);
            CheckSectionBounds(index, length);

            return EnumerableSort(source, index, length, SorterFactory.GetSorter(sortingAlgorithm), comparer);
        }

        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements in the given section of the collection.
        /// </summary>
        /// <param name="source">Collection of elements</param>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <param name="sorter">Implementation of sorting algorithm</param>
        /// <param name="comparer">Comparer</param>
        /// <typeparam name="T">Element type, must be IComparable</typeparam>
        /// <returns>The sorted collection</returns>
        /// <exception cref="ArgumentNullException">source is null</exception>
        /// <exception cref="ArgumentNullException">sorter is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> source, int index, int length, ISorter sorter,
            IComparer<T> comparer = null)
            where T : IComparable
        {
            CheckSource(source);
            CheckSorter(sorter);
            CheckSectionBounds(index, length);

            return EnumerableSort(source, index, length, sorter , comparer);
        }
    }
}