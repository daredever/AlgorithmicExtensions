using System;
using System.Collections.Generic;
using FluentAssertions;
using SortExtensions.Tests.TestDataGenerator;
using Xunit;
using static SortExtensions.Sorters.SorterFactory;

namespace SortExtensions.Tests.Base
{
    public abstract class BaseSortListNegativeTests : BaseSortTest
    {
        [Theory]
        [ClassData(typeof(NegativeSortDataGenerator))]
        public void Sort_IList_Index_Is_Not_Valid<T>(T[] income, int index, int length, string expectedMessage)
            where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;

            // Act
            Action action = () => source.Sort(index, length, SortingAlgorithm);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>().WithMessage(expectedMessage);
        }

        [Theory]
        [ClassData(typeof(NegativeRangeSortDataGenerator))]
        public void Sort_IList_Range_Is_Not_Valid<T>(T[] income, int index, int length, string expectedMessage)
            where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;
            var range = new Range(index, index + length);

            // Act
            Action action = () => source.Sort(range, SortingAlgorithm);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>().WithMessage(expectedMessage);
        }

        [Theory]
        [ClassData(typeof(NegativeSortDataGenerator))]
        public void Sort_IList_Index_BySorter_Is_Not_Valid<T>(T[] income, int index, int length, string expectedMessage)
            where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;
            var sorter = GetSorter(SortingAlgorithm);

            // Act
            Action action = () => source.Sort(index, length, sorter);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>().WithMessage(expectedMessage);
        }

        [Theory]
        [ClassData(typeof(NegativeRangeSortDataGenerator))]
        public void Sort_IList_Range_BySorter_Is_Not_Valid<T>(T[] income, int index, int length, string expectedMessage)
            where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;
            var range = new Range(index, index + length);
            var sorter = GetSorter(SortingAlgorithm);

            // Act
            Action action = () => source.Sort(range, sorter);

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>().WithMessage(expectedMessage);
        }
    }
}