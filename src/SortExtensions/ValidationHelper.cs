using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SortExtensions.Sorters;

namespace SortExtensions
{
    internal static class ValidationHelper
    {
        /// <summary>
        /// Checks if collection is null.
        /// </summary>
        /// <param name="source">Collection</param>
        /// <typeparam name="T">Element type</typeparam>
        /// <exception cref="ArgumentNullException">source is null</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckSource<T>(IEnumerable<T> source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }
        }

        /// <summary>
        /// Checks if sorter is null.
        /// </summary>
        /// <param name="sorter">Implementation of sorting algorithm</param>
        /// <exception cref="ArgumentNullException">sorter is null</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckSorter(ISorter sorter)
        {
            if (sorter is null)
            {
                throw new ArgumentNullException(nameof(sorter));
            }
        }

        /// <summary>
        /// Checks if bounds of range of collection is less than zero.
        /// </summary>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckRangeBounds(int index, int length)
        {
            const string message = "Non-negative number required.";

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), message);
            }

            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), message);
            }
        }

        /// <summary>
        /// Checks if source bounds less than section.
        /// </summary>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <param name="sourceLength">Source elements count</param>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckSourceBounds(int index, int length, int sourceLength)
        {
            const string message = "Specified argument was out of the range of valid values.";

            if (length + index > sourceLength)
            {
                throw new ArgumentOutOfRangeException(nameof(length), message);
            }
        }
    }
}