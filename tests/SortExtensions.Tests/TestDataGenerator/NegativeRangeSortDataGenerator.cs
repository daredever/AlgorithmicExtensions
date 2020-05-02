using System.Collections;
using System.Collections.Generic;

namespace SortExtensions.Tests.TestDataGenerator
{
    public class NegativeRangeSortDataGenerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source;
            int index, length;
            string message;

            source = new[] {1};
            index = 0;
            length = source.Length + 1;
            message = "Specified argument was out of the range of valid values. (Parameter 'length')";
            yield return new object[] {source, index, length, message};

            source = new[] {1};
            index = 1;
            length = 1;
            message = "Specified argument was out of the range of valid values. (Parameter 'length')";
            yield return new object[] {source, index, length, message};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}