using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using SortExtensions.Sorters;
using SortExtensions.Sorters.Implementations;

namespace SortExtensions.Benchmarks
{
	[MemoryDiagnoser]
	public class CompareSorters
	{
		private readonly int[] _data;
		private const int Index = 0;
		private const int Length = 10000;

		public CompareSorters()
		{
			_data = new int[Length];
			for (var i = Index; i < _data.Length; i++)
			{
				_data[i] = new Random(42).Next(-1000, 1000);
			}
		}

		[Benchmark]
		public IList<int> BubbleSort() => _data.Sort(Index, Length, SortingAlgorithm.BubbleSort);

		[Benchmark]
		public IList<int> InsertionSort() => _data.Sort(Index, Length, SortingAlgorithm.InsertionSort);

		[Benchmark]
		public IList<int> MergeSort() => _data.Sort(Index, Length, SortingAlgorithm.MergeSort);

		[Benchmark]
		public IList<int> SelectionSort() => _data.Sort(Index, Length, SortingAlgorithm.SelectionSort);

		[Benchmark]
		public IList<int> DefaultSort()
		{
			var copyData = new int[_data.Length];
			_data.CopyTo(copyData, 0);
			Array.Sort(copyData, Index, Length);

			return copyData;
		}
	}
}