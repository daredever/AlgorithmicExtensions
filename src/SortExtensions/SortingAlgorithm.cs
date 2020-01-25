using SortExtensions.Sorters.Implementations;

namespace SortExtensions
{
    public enum SortingAlgorithm
    {
        /// <summary>
        /// Sorts the elements of a generic zero-based collection with the default .NET implementation of Array.Sort Method.
        /// </summary>
        /// <remarks> 
        /// Worst-case performance O(n log n).
        /// Best-case performance O(n).
        /// To learn more <see cref="DefaultSorter"/>.
        /// </remarks>
        Default,

        /// <summary>
        /// Sorts the elements of a generic zero-based collection with the Bubble Sort Algorithm.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n).
        /// To learn more <see cref="BubbleSorter"/>.
        /// </remarks>
        BubbleSort,

        /// <summary>
        /// Sorts the elements of a generic zero-based collection with the Selection Sort Algorithm.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n^2).
        /// To learn more <see cref="SelectionSorter"/>.
        /// </remarks>
        SelectionSort,
        
        /// <summary>
        /// The Insertion Sort Algorithm for a generic zero-based collection.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n).
        /// To learn more <see cref="InsertionSorter"/>
        /// </remarks>
        InsertionSort,
        
        /// <summary>
        /// The Merge Sort Algorithm for a generic zero-based collection.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n log n).
        /// Best-case performance O(n).
        /// To learn more <see cref="MergeSorter"/>
        /// </remarks>
        MergeSort,
    }
}