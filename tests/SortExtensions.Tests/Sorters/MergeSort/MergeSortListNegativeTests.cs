using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.MergeSort
{
    public class MergeSortListNegativeTests : BaseSortListNegativeTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.MergeSort;
    }
}