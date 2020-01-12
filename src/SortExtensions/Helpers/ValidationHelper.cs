using System;
using System.Collections.Generic;
using SortExtensions.Sorters;

namespace SortExtensions.Helpers
{
    internal static class ValidationHelper
    {
        /// <summary>
        /// Checks if collection is null.
        /// </summary>
        /// <param name="source">Collection</param>
        /// <typeparam name="T">Element type</typeparam>
        /// <exception cref="ArgumentNullException">source is null</exception>
        internal static void CheckSource<T>(IEnumerable<T> source)
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
        internal static void CheckSorter(ISorter sorter)
        {
            if (sorter is null)
            {
                throw new ArgumentNullException(nameof(sorter));
            }
        }

        /// <summary>
        /// Checks if bounds of section of collection is less than zero.
        /// </summary>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <exception cref="ArgumentOutOfRangeException">index or length less than zero</exception>
        internal static void CheckSectionBounds(int index, int length)
        {
            if (index < 0 || length < 0)
            {
                var paramName = length < 0 ? nameof(length) : nameof(index);
                var message = $"Param '{paramName}' should not be less than zero.";
                throw new ArgumentOutOfRangeException(paramName, message);
            }
        }

        /// <summary>
        /// Checks if source bounds less than section.
        /// </summary>
        /// <param name="index">Start index for sorting</param>
        /// <param name="length">Elements count for sorting</param>
        /// <param name="max">Max index in collection</param>
        /// <exception cref="ArgumentOutOfRangeException">collection bounds less than section</exception>
        internal static void CheckSourceBounds(int index, int length, int max)
        {
            if (index > max || length > max - index + 1)
            {
                var paramName = length > max - index ? nameof(length) : nameof(index);
                var message = $"Param '{paramName}' too big for source bounds.";
                throw new ArgumentOutOfRangeException(paramName, message);
            }
        }
    }
}