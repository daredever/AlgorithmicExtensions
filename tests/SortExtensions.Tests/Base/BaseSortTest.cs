using SortExtensions.Sorters;

namespace SortExtensions.Tests.Base
{
    public abstract class BaseSortTest
    {
        public abstract SortingAlgorithm SortingAlgorithm { get; }
        public abstract Sorter Sorter { get; }
    }
}