using System;
using SortExtensions.Sorters.BubbleSort;

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
                default:
                    throw new ArgumentOutOfRangeException(nameof(sortingAlgorithm), sortingAlgorithm,
                        "Algorithm is not supported.");
            }
        }
    }
}