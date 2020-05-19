using SortExtensions.Sorters.Implementations;

namespace SortExtensions
{
    public enum SortingAlgorithm
    {
        /// <summary>
        /// The Bubble Sort Algorithm for a generic zero-based collection.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n).
        /// To learn more, see <see cref="BubbleSorter"/>.
        /// </remarks>
        BubbleSort,

        /// <summary>
        /// The Selection Sort Algorithm for a generic zero-based collection.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n^2).
        /// To learn more, see <see cref="SelectionSorter"/>.
        /// </remarks>
        SelectionSort,

        /// <summary>
        /// The Insertion Sort Algorithm for a generic zero-based collection.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n).
        /// To learn more, see <see cref="InsertionSorter"/>
        /// </remarks>
        InsertionSort,

        /// <summary>
        /// The Merge Sort Algorithm for a generic zero-based collection.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n log n).
        /// Best-case performance O(n).
        /// To learn more, see <see cref="MergeSorter"/>
        /// </remarks>
        MergeSort,
    }
}