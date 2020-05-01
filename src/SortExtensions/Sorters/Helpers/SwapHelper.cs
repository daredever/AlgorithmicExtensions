using System;

namespace SortExtensions.Sorters.Helpers
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
        public static void Swap<T>(Span<T> source, int sourceIndex, int destinationIndex)
        {
            var temp = source[sourceIndex];
            source[sourceIndex] = source[destinationIndex];
            source[destinationIndex] = temp;
        }
    }
}