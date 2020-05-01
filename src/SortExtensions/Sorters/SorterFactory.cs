using System;
using SortExtensions.Sorters.Implementations;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("SortExtensions.Tests")]

namespace SortExtensions.Sorters
{
    internal static class SorterFactory
    {
        public static ISorter GetSorter(SortingAlgorithm sortingAlgorithm) =>
            sortingAlgorithm switch
            {
                SortingAlgorithm.BubbleSort => new BubbleSorter(),
                SortingAlgorithm.SelectionSort => new SelectionSorter(),
                SortingAlgorithm.InsertionSort => new InsertionSorter(),
                SortingAlgorithm.MergeSort => new MergeSorter(),
                _ => throw new ArgumentOutOfRangeException(nameof(sortingAlgorithm), sortingAlgorithm,
                    "Algorithm is not supported.")
            };
    }
}