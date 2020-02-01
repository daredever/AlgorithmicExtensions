using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using SortExtensions.Sorters;
using SortExtensions.Sorters.Implementations;

namespace SortExtensions.Benchmarks
{
    public class CompareSorters
    {
        private readonly int[] _data;
        private const int StartIndex = 0;
        private const int Length = 1000;

        private readonly IComparer<int> _comparer = Comparer<int>.Default;

        private readonly ISorter _bubbleSorter = new BubbleSorter();
        private readonly ISorter _insertionSorter = new InsertionSorter();
        private readonly ISorter _mergeSorter = new MergeSorter();
        private readonly ISorter _defaultSorter = new DefaultSorter();
        private readonly ISorter _selectionSorter = new SelectionSorter();

        public CompareSorters()
        {
            _data = new int[Length];
            for (var i = 0; i < _data.Length; i++)
            {
                _data[i] = new Random(42).Next(-1000, 1000);
            }
        }

        [Benchmark]
        public IList<int> BubbleSort() => _bubbleSorter.Sort(_data, StartIndex, Length, _comparer);

        [Benchmark]
        public IList<int> InsertionSort() => _insertionSorter.Sort(_data, StartIndex, Length, _comparer);

        [Benchmark]
        public IList<int> MergeSort() => _mergeSorter.Sort(_data, StartIndex, Length, _comparer);

        [Benchmark]
        public IList<int> DefaultSort() => _defaultSorter.Sort(_data, StartIndex, Length, _comparer);

        [Benchmark]
        public IList<int> SelectionSort() => _selectionSorter.Sort(_data, StartIndex, Length, _comparer);
    }
}