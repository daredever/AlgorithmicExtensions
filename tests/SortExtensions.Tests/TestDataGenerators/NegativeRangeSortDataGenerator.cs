using System;
using System.Collections;
using System.Collections.Generic;

namespace SortExtensions.Tests.TestDataGenerators
{
    public class NegativeRangeSortDataGenerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source;
            Range range;
            string message;

            source = new[] {1};
            range = new Range(1, 2);
            message = "Specified argument was out of the range of valid values. (Parameter 'length')";
            yield return new object[] {source, range, message};

            source = new[] {1};
            range = new Range(2, 2);
            message = "Specified argument was out of the range of valid values. (Parameter 'length')";
            yield return new object[] {source, range, message};
            
            source = new[] {1};
            range = new Range(0, 10);
            message = "Specified argument was out of the range of valid values. (Parameter 'length')";
            yield return new object[] {source, range, message};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}