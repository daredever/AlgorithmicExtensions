using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.SelectionSort
{
    public class SelectionSortListNegativeTests : BaseSortListNegativeTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.SelectionSort;
    }
}