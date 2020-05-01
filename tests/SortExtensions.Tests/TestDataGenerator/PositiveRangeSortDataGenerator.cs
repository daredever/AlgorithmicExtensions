using System;
using System.Collections;
using System.Collections.Generic;

namespace SortExtensions.Tests.TestDataGenerator
{
    public class PositiveRangeSortDataGenerator : IEnumerable<object[]>
    {
        private readonly IComparer<int> _comparer = Comparer<int>.Default;

        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source;
            int index, length;

            source = new int[] { };
            index = 0;
            length = source.Length;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};

            source = new[] {1};
            index = 0;
            length = source.Length;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};

            source = new[] {1, 2};
            index = 0;
            length = 0;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};

            source = new[] {1, 2, 3};
            index = 1;
            length = 1;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};

            source = new[] {1, 2, 3};
            index = 1;
            length = 2;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};

            source = new[] {4, 1, 2, 3};
            index = 1;
            length = 2;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};

            source = new[] {4, 1, 2, 3, 100, 1, 1000};
            index = 1;
            length = source.Length - 1;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};

            source = new[] {1, 1, 1, 1, 1, 1, 1, 1, 1};
            index = 1;
            length = source.Length - 2;
            yield return new object[] {source, index, length, GetSortedArray(source, index, length)};
        }

        private int[] GetSortedArray(int[] source, int index, int length)
        {
            var expected = new int[source.Length];
            source.CopyTo(expected, 0);
            Array.Sort(expected, index, length, _comparer);

            return expected;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}