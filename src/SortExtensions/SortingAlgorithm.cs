namespace SortExtensions
{
    public enum SortingAlgorithm
    {
        /// <summary>
        /// Sorts the elements of a zero-based collection with the default .NET implementation of Array.Sort Method.
        /// </summary>
        /// <remarks>
        /// To learn more, see https://docs.microsoft.com/en-us/dotnet/api/system.array.sort?view=netcore-3.1
        /// </remarks>
        Default,

        /// <summary>
        /// Sorts the elements of a zero-based collection with the Bubble Sort Algorithm.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n).
        /// </remarks>
        BubbleSort,
        
        /// <summary>
        /// Sorts the elements of a zero-based collection with the Selection Sort Algorithm.
        /// </summary>
        /// <remarks>
        /// Worst-case performance O(n^2).
        /// Best-case performance O(n^2).
        /// </remarks>
        SelectionSort,
    }
}