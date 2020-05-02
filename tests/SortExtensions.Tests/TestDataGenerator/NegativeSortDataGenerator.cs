using System.Collections;
using System.Collections.Generic;

namespace SortExtensions.Tests.TestDataGenerator
{
    public class NegativeSortDataGenerator : IEnumerable<object[]>
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
            message = "Specified argument was out of the range of valid values. (Parameter 'index')";
            yield return new object[] {source, index, length, message};

            source = new[] {1};
            index = 0;
            length = -1;
            message = "Non-negative number required. (Parameter 'length')";
            yield return new object[] {source, index, length, message};

            source = new[] {1};
            index = -1;
            length = source.Length;
            message = "Non-negative number required. (Parameter 'index')";
            yield return new object[] {source, index, length, message};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}