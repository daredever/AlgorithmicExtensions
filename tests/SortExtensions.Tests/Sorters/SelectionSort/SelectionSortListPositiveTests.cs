using SortExtensions.Sorters;
using SortExtensions.Sorters.SelectionSort;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.SelectionSort
{
    public class SelectionSortListPositiveTests : BaseSortListPositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.SelectionSort;
        public override ISorter Sorter => new SelectionSorter();
    }
}