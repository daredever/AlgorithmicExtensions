using System;
using System.Collections;
using System.Collections.Generic;

namespace SortExtensions.Tests.TestDataGenerators
{
    public class PositiveFullSortDataGenerator : IEnumerable<object[]>
    {
        private readonly IComparer<int> _comparer = Comparer<int>.Default;

        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source;

            source = new[] {1, 1, 1, 1, 1, 1};
            yield return new object[] {source, GetSortedArray(source)};

            source = new[] {5, 1, 3, 4, 2, 0};
            yield return new object[] {source, GetSortedArray(source)};

            source = new[] {5, 1, 3, 4, 2, 100};
            yield return new object[] {source, GetSortedArray(source)};

            source = new[] {1000, 5, 1, 3, 4, 2, 100};
            yield return new object[] {source, GetSortedArray(source)};

            source = new int[] { };
            yield return new object[] {source, GetSortedArray(source)};

            source = new[] {1000};
            yield return new object[] {source, GetSortedArray(source)};

            source = new[] {1, 2};
            yield return new object[] {source, GetSortedArray(source)};

            source = new[] {1, -2, 3};
            yield return new object[] {source, GetSortedArray(source)};
        }

        private int[] GetSortedArray(int[] source)
        {
            var expected = new int[source.Length];
            source.CopyTo(expected, 0);
            Array.Sort(expected, 0, source.Length, _comparer);

            return expected;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}