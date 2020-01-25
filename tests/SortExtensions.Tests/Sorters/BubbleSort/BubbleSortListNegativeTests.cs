using SortExtensions.Sorters;
using SortExtensions.Sorters.Implementations;
using SortExtensions.Tests.Base;

namespace SortExtensions.Tests.Sorters.BubbleSort
{
    public class BubbleSortListNegativeTests : BaseSortListNegativeTests
    {
        public override SortingAlgorithm SortingAlgorithm => SortingAlgorithm.BubbleSort;
        public override Sorter Sorter => new BubbleSorter();
    }
}