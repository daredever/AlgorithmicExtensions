using System;
using System.Collections.Generic;
using FluentAssertions;
using SortExtensions.Sorters;
using SortExtensions.Tests.TestDataGenerator;
using Xunit;

namespace SortExtensions.Tests.Base
{
    public abstract class BaseSortListNegativeTests
    {
        public abstract SortingAlgorithm SortingAlgorithm { get; }
        public abstract ISorter Sorter { get; }
        
        [Theory]
        [ClassData(typeof(NegativeFullSortDataGenerator))]
        public void Sort_IList_Full_Is_Not_Valid<T>(T[] income, int index, int length, string expectedMessage)
            where T : IComparable
        {
            // Arrange
            var source = (IList<T>) income;

            // Act
            Action action = () => source.Sort(index, length, SortingAlgorithm);

            // Assert
            action.Should().Throw<ArgumentException>().WithMessage(expectedMessage);
        }
    }
}