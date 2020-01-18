using System;
using SortExtensions.Sorters.BubbleSort;
using SortExtensions.Sorters.SelectionSort;

namespace SortExtensions.Sorters
{
    internal static class SorterFactory
    {
        internal static ISorter GetSorter(SortingAlgorithm sortingAlgorithm)
        {
            switch (sortingAlgorithm)
            {
                case SortingAlgorithm.BubbleSort:
                    return new BubbleSorter();
                case SortingAlgorithm.SelectionSort:
                    return new SelectionSorter();
                default:
                    throw new ArgumentOutOfRangeException(nameof(sortingAlgorithm), sortingAlgorithm,
                        "Algorithm is not supported.");
            }
        }
    }
}