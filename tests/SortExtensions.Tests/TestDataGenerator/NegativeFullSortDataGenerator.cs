using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SortExtensions.Sorters;

namespace SortExtensions.Tests.TestDataGenerator
{
    public class NegativeFullSortDataGenerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source;
            int index, length;
            string message;

            source = new[] {1};
            index = 1;
            length = source.Length;
            message = "Param 'length' too big for source bounds. (Parameter 'length')";
            yield return new object[] {source, index, length, message};

            source = new[] {1};
            index = -1;
            length = source.Length;
            message = "Param 'index' should not be less than zero. (Parameter 'index')";
            yield return new object[] {source, index, length, message};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}