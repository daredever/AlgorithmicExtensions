using System;
using System.Collections.Generic;
using SortExtensions.Sorters;
using static SortExtensions.Helpers.ValidationHelper;

namespace SortExtensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements of the collection.
        /// If comparer is null, the elements are compared to each other using the IComparable
        /// interface, which in that case must be implemented by all elements of the collection.
        /// </summary>
        /// <param name="source">Collection of elements</param>
        /// <param name="sortingAlgorithm">Sorting algorithm</param>
        /// <param name="comparer">Comparer</param>
        /// <typeparam name="T">Element type, must be IComparable</typeparam>
        /// <returns>The sorted collection</returns>
        /// <exception cref="ArgumentNullException">source is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        /// <exception cref="ArgumentOutOfRangeException">wrong sorting algorithm specified</exception>
        public static IList<T> Sort<T>(this IList<T> source,
            SortingAlgorithm sortingAlgorithm, IComparer<T> comparer = null)
            where T : IComparable
        {
            CheckSource(source);

            return ListSort(source, 0, source.Count, SorterFactory.GetSorter(sortingAlgorithm), comparer);
        }

        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements of the collection.
        /// If comparer is null, the elements are compared to each other using the IComparable
        /// interface, which in that case must be implemented by all elements of the collection.
        /// </summary>
        /// <param name="source">Collection of elements</param>
        /// <param name="sorter">Implementation of sorting algorithm</param>
        /// <param name="comparer">Comparer</param>
        /// <typeparam name="T">Element type, must be IComparable</typeparam>
        /// <returns>The sorted collection</returns>
        /// <exception cref="ArgumentNullException">source is null</exception>
        /// <exception cref="ArgumentNullException">sorter is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        public static IList<T> Sort<T>(this IList<T> source, ISorter sorter, IComparer<T> comparer = null)
            where T : IComparable
        {
            CheckSource(source);
            CheckSorter(sorter);

            return ListSort(source, 0, source.Count, sorter, comparer);
        }

        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements in the given section of the collection.
        /// If comparer is null, the elements are compared to each other using the IComparable
        /// interface, which in that case must be implemented by all elements of the collection.
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
        public static IList<T> Sort<T>(this IList<T> source, int index, int length,
            SortingAlgorithm sortingAlgorithm, IComparer<T> comparer = null)
            where T : IComparable
        {
            CheckSource(source);
            CheckSectionBounds(index, length);
            CheckSourceBounds(index, length, Math.Max(source.Count - 1, 0));

            return ListSort(source, index, length, SorterFactory.GetSorter(sortingAlgorithm), comparer);
        }

        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements in the given section of the collection.
        /// If comparer is null, the elements are compared to each other using the IComparable
        /// interface, which in that case must be implemented by all elements of the collection.
        /// </summary>
        /// <param name="source">Collection of elements</param>
        /// <param name="range">Range for sorting</param>
        /// <param name="sortingAlgorithm">Sorting algorithm</param>
        /// <param name="comparer">Comparer</param>
        /// <typeparam name="T">Element type, must be IComparable</typeparam>
        /// <returns>The sorted collection</returns>
        /// <exception cref="ArgumentNullException">source is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        /// <exception cref="ArgumentOutOfRangeException">wrong sorting algorithm specified</exception>
        public static IList<T> Sort<T>(this IList<T> source, Range range, SortingAlgorithm sortingAlgorithm,
            IComparer<T> comparer = null)
            where T : IComparable
        {
            var index = range.Start.Value;
            var length = range.End.Value - range.Start.Value;

            CheckSource(source);
            CheckSectionBounds(index, length);
            CheckSourceBounds(index, length, Math.Max(source.Count - 1, 0));

            return ListSort(source, index, length, SorterFactory.GetSorter(sortingAlgorithm), comparer);
        }

        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements in the given section of the collection.
        /// If comparer is null, the elements are compared to each other using the IComparable
        /// interface, which in that case must be implemented by all elements of the collection.
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
        public static IList<T> Sort<T>(this IList<T> source, int index, int length, ISorter sorter,
            IComparer<T> comparer = null)
            where T : IComparable
        {
            CheckSource(source);
            CheckSorter(sorter);
            CheckSectionBounds(index, length);
            CheckSourceBounds(index, length, Math.Max(source.Count - 1, 0));

            return ListSort(source, index, length, sorter, comparer);
        }

        /// <summary>
        /// Sorts the elements of a zero-based collection with specified algorithm.
        /// The sort compares the elements to each other using the IComparable interface,
        /// which must be implemented by all elements in the given section of the collection.
        /// If comparer is null, the elements are compared to each other using the IComparable
        /// interface, which in that case must be implemented by all elements of the collection.
        /// </summary>
        /// <param name="source">Collection of elements</param>
        /// <param name="range">Range for sorting</param>
        /// <param name="sorter">Implementation of sorting algorithm</param>
        /// <param name="comparer">Comparer</param>
        /// <typeparam name="T">Element type, must be IComparable</typeparam>
        /// <returns>The sorted collection</returns>
        /// <exception cref="ArgumentNullException">source is null</exception>
        /// <exception cref="ArgumentNullException">sorter is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        public static IList<T> Sort<T>(this IList<T> source, Range range, ISorter sorter, IComparer<T> comparer = null)
            where T : IComparable
        {
            var index = range.Start.Value;
            var length = range.End.Value - range.Start.Value;

            CheckSource(source);
            CheckSorter(sorter);
            CheckSectionBounds(index, length);
            CheckSourceBounds(index, length, Math.Max(source.Count - 1, 0));

            return ListSort(source, index, length, sorter, comparer);
        }

        private static IList<T> ListSort<T>(IList<T> source, int index, int length, ISorter sorter,
            IComparer<T> comparer = null)
            where T : IComparable
        {
            return sorter.Sort(source, index, length, comparer ?? Comparer<T>.Default);
        }
    }
}