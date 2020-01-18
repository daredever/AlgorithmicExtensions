using System;
using System.Collections.Generic;
using static SortExtensions.Helpers.ValidationHelper;

namespace SortExtensions.Helpers
{
    internal static class SwapHelper
    {
        /// <summary>
        /// Swap two elements in collection.
        /// </summary>
        /// <param name="source">Source data structure</param>
        /// <param name="sourceIndex">First item index</param>
        /// <param name="destinationIndex">Second item index</param>
        /// <typeparam name="T">Generic type</typeparam>
        /// <exception cref="ArgumentNullException">source is null</exception>
        internal static void Swap<T>(IList<T> source, int sourceIndex, int destinationIndex)
        {
            CheckSource(source);

            var temp = source[sourceIndex];
            source[sourceIndex] = source[destinationIndex];
            source[destinationIndex] = temp;
        }
    }
}