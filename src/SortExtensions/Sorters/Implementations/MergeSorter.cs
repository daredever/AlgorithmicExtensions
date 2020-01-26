using System.Collections.Generic;
using System.Linq;

namespace SortExtensions.Sorters.Implementations
{
    /// <summary>
    /// The Merge Sort Algorithm implementation for a generic zero-based collection.
    /// </summary>
    /// <remarks>
    /// Worst-case performance O(n log n).
    /// Best-case performance O(n).
    /// To learn more, see https://en.wikipedia.org/wiki/Merge_sort
    /// </remarks>
    public class MergeSorter : Sorter
    {
        protected override void SortInternal<T>(T[] sortingData, int index, int length, IComparer<T> comparer)
        {
            MergeSort(sortingData, index, index + length - 1, comparer);
        }

        private void MergeSort<T>(T[] sortingData, int low, int high, IComparer<T> comparer)
        {
            if (low >= high)
            {
                return;
            }

            var middle = (low + high) / 2;
            MergeSort(sortingData, low, middle, comparer);
            MergeSort(sortingData, middle + 1, high, comparer);
            Merge(sortingData, low, middle, high, comparer);
        }

        private void Merge<T>(T[] sortingData, int low, int middle, int high, IComparer<T> comparer)
        {
            var leftQueue = new Queue<T>();
            var rightQueue = new Queue<T>();

            for (var i = low; i <= middle; i++)
            {
                leftQueue.Enqueue(sortingData[i]);
            }

            for (var i = middle + 1; i <= high; i++)
            {
                rightQueue.Enqueue(sortingData[i]);
            }

            var index = low;
            while (leftQueue.Any() & rightQueue.Any())
            {
                if (comparer.Compare(leftQueue.Peek(), rightQueue.Peek()) > 0)
                {
                    sortingData[index++] = rightQueue.Dequeue();
                }
                else
                {
                    sortingData[index++] = leftQueue.Dequeue();
                }
            }

            while (leftQueue.Any())
            {
                sortingData[index++] = leftQueue.Dequeue();
            }

            while (rightQueue.Any())
            {
                sortingData[index++] = rightQueue.Dequeue();
            }
        }
    }
}