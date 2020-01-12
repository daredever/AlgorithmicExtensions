using SortExtensions.Sorters;
using SortExtensions.Sorters.BubbleSort;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.BubbleSort
{
    public class BubbleSortListPositiveTests : BaseSortListPositiveTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.BubbleSort;
        public override ISorter Sorter => new BubbleSorter();
    }
}