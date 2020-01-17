using System;
using System.Collections.Generic;
using System.Linq;
using SortExtensions.Sorters;
using static SortExtensions.Helpers.ValidationHelper;

namespace SortExtensions.Helpers
{
    internal static class SortHelper
    {
        internal static IList<T> ListSort<T>(IList<T> source, int index, int length, ISorter sorter)
            where T : IComparable
        {
            return sorter.Sort(source, index, length);
        }

        internal static IEnumerable<T> EnumerableSort<T>(IEnumerable<T> source, int index, int length, ISorter sorter)
            where T : IComparable
        {
            // Do not need sorting empty section or section with only one element.
            if (length <= 1)
            {
                foreach (var item in source)
                {
                    yield return item;
                }

                yield break;
            }

            // Return unsorted elements before specified section.
            foreach (var item in source.Take(index))
            {
                yield return item;
            }

            // Return sorted elements in specified section.
            var sourceForSort = source.Skip(index).Take(length).ToArray();
            CheckSourceBounds(0, length, Math.Max(sourceForSort.Length - 1, 0));
            var sortedSource = ListSort(sourceForSort, 0, length, sorter);
            foreach (var item in sortedSource)
            {
                yield return item;
            }

            // Return unsorted elements after specified section.
            foreach (var item in source.Skip(index + length))
            {
                yield return item;
            }
        }
    }
}