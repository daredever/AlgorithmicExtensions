using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SortExtensions.Sorters;
using SortExtensions.Sorters.Default;

namespace SortExtensions.Tests.TestDataGenerator
{
    public class NegativeFullSortDataGenerator : IEnumerable<object[]>
    {
        ISorter _defaultSorter = new DefaultSorter();

        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source;
            int index;
            int length;
            string message;

            source = new int[] {1};
            index = 1;
            length = source.Length;
            message = "Param 'length' too big for source bounds. (Parameter 'length')";
            yield return new object[] {source, index, length, message};

            source = new int[] {1};
            index = -1;
            length = source.Length;
            message = "Param 'index' should not be less than zero. (Parameter 'index')";
            yield return new object[] {source, index, length, message};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}