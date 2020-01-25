using SortExtensions.Sorters;
using SortExtensions.Sorters.Implementations;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.SelectionSort
{
    public class SelectionSortEnumerablePositiveTests : BaseSortEnumerablePositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.SelectionSort;
        public override Sorter Sorter => new SelectionSorter();
    }
}