using System;
using System.Collections.Generic;
using FluentAssertions;
using SortExtensions.Sorters;
using SortExtensions.Tests.TestDataGenerator;
using Xunit;

namespace SortExtensions.Tests.Base
{
    public abstract class BaseSortEnumerablePositiveTests
    {
        public abstract SortingAlgorithm SortingAlgorithm { get; }
        public abstract ISorter Sorter { get; }
        
        [Theory]
        [ClassData(typeof(PositiveRangeSortDataGenerator))]
        public void Sort_IEnumerable_Range_Is_Valid<T>(T[] income, int index, int length, T[] expected)
            where T : IComparable
        {
            // Arrange
            var source = (IEnumerable<T>) income;

            // Act
            var sorted = source.Sort(index, length, SortingAlgorithm);

            // Assert
            sorted.Should().Equal(expected);
        }

        [Theory]
        [ClassData(typeof(PositiveRangeSortDataGenerator))]
        public void Sort_IEnumerable_Range_By_Sorter_Is_Valid<T>(T[] income, int index, int length, T[] expected)
            where T : IComparable
        {
            // Arrange
            var source = (IEnumerable<T>) income;

            // Act
            var sorted = source.Sort(index, length, Sorter);

            // Assert
            sorted.Should().Equal(expected);
        }
    }
}