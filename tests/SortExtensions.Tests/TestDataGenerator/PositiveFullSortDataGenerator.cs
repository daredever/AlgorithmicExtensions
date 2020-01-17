using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SortExtensions.Sorters;
using SortExtensions.Sorters.Default;

namespace SortExtensions.Tests.TestDataGenerator
{
    public class PositiveFullSortDataGenerator : IEnumerable<object[]>
    {
        ISorter _defaultSorter = new DefaultSorter();

        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source, expected;

            source = new[] {1, 1, 1, 1, 1, 1};
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};

            source = new[] {5, 1, 3, 4, 2, 0};
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};

            source = new[] {5, 1, 3, 4, 2, 100};
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};

            source = new[] {1000, 5, 1, 3, 4, 2, 100};
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};

            source = new int[] { };
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};

            source = new[] {1000};
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};

            source = new[] {1, 2};
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};

            source = new[] {1, -2, 3};
            expected = _defaultSorter.Sort(source, 0, source.Length).ToArray();
            yield return new object[] {source, expected};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}