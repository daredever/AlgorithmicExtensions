using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.InsertionSort
{
    public class InsertionSortListNegativeTests : BaseSortListNegativeTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.InsertionSort;
    }
}