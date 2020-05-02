using System;
using System.Collections.Generic;
using FluentAssertions;
using SortExtensions.Tests.TestDataGenerators;
using Xunit;
using static SortExtensions.Sorters.SorterFactory;

namespace SortExtensions.Tests.Base
{
    public abstract class BaseSortListPositiveTests : BaseSortTest
    {
        [Theory]
        [ClassData(typeof(PositiveRangeSortDataGenerator))]
        public void Sort_IList_Index_IsValid<T>(T[] income, int index, int length, T[] expected) where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;

            // Act
            var sorted = source.Sort(index, length, SortingAlgorithm);

            // Assert
            sorted.Should().Equal(expected);
        }

        [Theory]
        [ClassData(typeof(PositiveRangeSortDataGenerator))]
        public void Sort_IList_Index_BySorter_IsValid<T>(T[] income, int index, int length, T[] expected)
            where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;
            var sorter = GetSorter(SortingAlgorithm);

            // Act
            var sorted = source.Sort(index, length, sorter);

            // Assert
            sorted.Should().Equal(expected);
        }

        [Theory]
        [ClassData(typeof(PositiveRangeSortDataGenerator))]
        public void Sort_IList_Range_IsValid<T>(T[] income, int index, int length, T[] expected) where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;
            var range = new Range(index, length + index);

            // Act
            var sorted = source.Sort(range, SortingAlgorithm);

            // Assert
            sorted.Should().Equal(expected);
        }

        [Theory]
        [ClassData(typeof(PositiveRangeSortDataGenerator))]
        public void Sort_IList_Range_BySorter_IsValid<T>(T[] income, int index, int length, T[] expected)
            where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;
            var range = new Range(index, length + index);
            var sorter = GetSorter(SortingAlgorithm);

            // Act
            var sorted = source.Sort(range, sorter);

            // Assert
            sorted.Should().Equal(expected);
        }

        [Theory]
        [ClassData(typeof(PositiveFullSortDataGenerator))]
        public void Sort_IList_Full_IsValid<T>(T[] income, T[] expected) where T : IComparable
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
        public void Sort_IList_Full_BySorter_IsValid<T>(T[] income, T[] expected) where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;
            var sorter = GetSorter(SortingAlgorithm);

            // Act
            var sorted = source.Sort(sorter);

            // Assert
            sorted.Should().Equal(expected);
        }
    }
}