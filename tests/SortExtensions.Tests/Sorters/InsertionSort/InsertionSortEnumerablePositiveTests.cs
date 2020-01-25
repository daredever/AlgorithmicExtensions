using SortExtensions.Sorters;
using SortExtensions.Sorters.Implementations;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.InsertionSort
{
    public class InsertionSortEnumerablePositiveTests : BaseSortEnumerablePositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.InsertionSort;
        public override Sorter Sorter => new InsertionSorter();
    }
}