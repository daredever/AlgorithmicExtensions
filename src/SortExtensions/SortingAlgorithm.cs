using SortExtensions.Sorters.BubbleSort;
using SortExtensions.Sorters.Default;
using SortExtensions.Sorters.SelectionSort;

namespace SortExtensions
{
    public enum SortingAlgorithm
    {
        /// <summary>
        /// Sorts the elements of a zero-based collection with the default .NET implementation of Array.Sort Method.
        /// </summary>
        /// <remarks> 
        /// Worst-case performance O(n log n).
        /// Best-case performance O(n).
        /// To learn more <see cref="DefaultSorter"/>.
        /// </remarks>
        Default,

        /// <summary>
        /// Sorts the elements of a zero-based collection with the Bubble Sort Algorithm.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n).
        /// To learn more <see cref="BubbleSorter"/>.
        /// </remarks>
        BubbleSort,

        /// <summary>
        /// Sorts the elements of a zero-based collection with the Selection Sort Algorithm.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n^2).
        /// To learn more <see cref="SelectionSorter"/>.
        /// </remarks>
        SelectionSort,
    }
}