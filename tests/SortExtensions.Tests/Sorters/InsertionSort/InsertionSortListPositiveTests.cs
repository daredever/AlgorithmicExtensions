using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.InsertionSort
{
    public class InsertionSortListPositiveTests : BaseSortListPositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.InsertionSort;
    }
}