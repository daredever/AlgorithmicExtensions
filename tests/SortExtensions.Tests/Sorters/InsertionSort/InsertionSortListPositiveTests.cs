using SortExtensions.Sorters;
using SortExtensions.Sorters.BubbleSort;
using SortExtensions.Sorters.InsertionSort;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.InsertionSort
{
    public class InsertionSortListPositiveTests : BaseSortListPositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.InsertionSort;
        public override ISorter Sorter => new InsertionSorter();
    }
}