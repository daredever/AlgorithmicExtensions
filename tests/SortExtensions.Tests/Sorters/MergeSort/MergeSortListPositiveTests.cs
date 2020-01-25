using SortExtensions.Sorters;
using SortExtensions.Sorters.Implementations;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.MergeSort
{
    public class MergeSortListPositiveTests : BaseSortListPositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.MergeSort;
        public override Sorter Sorter => new MergeSorter();
    }
}