using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SortExtensions.Sorters;
using SortExtensions.Sorters.Default;

namespace SortExtensions.Tests.TestDataGenerator
{
    public class PositiveRangeSortDataGenerator : IEnumerable<object[]>
    {
        ISorter _defaultSorter = new DefaultSorter();

        public IEnumerator<object[]> GetEnumerator()
        {
            int[] source;
            int[] expected;
            int index;
            int length;

            source = new int[] { };
            index = 0;
            length = source.Length;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};

            source = new int[] {1};
            index = 0;
            length = source.Length;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};

            source = new int[] {1, 2};
            index = 0;
            length = 0;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};

            source = new int[] {1, 2, 3};
            index = 1;
            length = 1;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};

            source = new int[] {1, 2, 3};
            index = 1;
            length = 2;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};

            source = new int[] {4, 1, 2, 3};
            index = 1;
            length = 2;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};

            source = new int[] {4, 1, 2, 3, 100, 1, 1000};
            index = 1;
            length = source.Length - 1;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};

            source = new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1};
            index = 1;
            length = source.Length - 2;
            expected = _defaultSorter.Sort(source, index, length).ToArray();
            yield return new object[] {source, index, length, expected};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}