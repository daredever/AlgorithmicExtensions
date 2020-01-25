using System;
using System.Collections.Generic;
using FluentAssertions;
using SortExtensions.Sorters;
using SortExtensions.Tests.TestDataGenerator;
using Xunit;

namespace SortExtensions.Tests.Base
{
    public abstract class BaseSortListPositiveTests: BaseSortTest
    {
        [Theory]
        [ClassData(typeof(PositiveRangeSortDataGenerator))]
        public void Sort_IList_Range_Is_Valid<T>(T[] income, int index, int length, T[] expected) where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;

            // Act
            var sorted = source.Sort(index, length, SortingAlgorithm);

            // Assert
            sorted.Should().Equal(expected);
        }

        [Theory]
        [ClassData(typeof(PositiveFullSortDataGenerator))]
        public void Sort_IList_Full_Is_Valid<T>(T[] income, T[] expected) where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;

            // Act
            var sorted = source.Sort(SortingAlgorithm);

            // Assert
            sorted.Should().Equal(expected);
        }
        
        [Theory]
        [ClassData(typeof(PositiveFullSortDataGenerator))]
        public void Sort_IList_Full_By_Sorter_Is_Valid<T>(T[] income, T[] expected) where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;

            // Act
            var sorted = source.Sort(Sorter);

            // Assert
            sorted.Should().Equal(expected);
        }
    }
}