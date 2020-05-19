using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.SelectionSort
{
    public class SelectionSortListPositiveTests : BaseSortListPositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.SelectionSort;
    }
}