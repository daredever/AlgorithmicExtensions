using System;
using System.Collections.Generic;

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
        /// <exception cref="ArgumentNullException">If source is null</exception>
        internal static void Swap<T>(IList<T> source, int sourceIndex, int destinationIndex)
        {
            ValidationHelper.CheckSource(source);

            var temp = source[sourceIndex];
            source[sourceIndex] = source[destinationIndex];
            source[destinationIndex] = temp;
        }
    }
}