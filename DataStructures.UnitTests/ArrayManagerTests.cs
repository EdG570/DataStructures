using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures;

namespace DataStructures.UnitTests
{
    public class ArrayManagerTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        [InlineData(5)]
        public void Create_ShouldReturnArrayOfArgumentLength_WhenValidLengthIsPassed(int length)
        {
            // Arrange
            var arrayManager = new ArrayManager<int>();

            // Act
            var result = arrayManager.Create(length);

            // Assert
            Assert.Equal(length, result.Length);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-99)]
        [InlineData(-5)]
        public void Create_ShouldThrowArgumentOutOfRangeException_WhenInvalidLengthArgPassed(int length)
        {
            // Arrange
            var arrayManager = new ArrayManager<int>();

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => arrayManager.Create(length));
        }

        [Fact]
        public void Increase_ShouldIncreaseLengthByOne_WhenValidArrayArgPassed()
        {
            // Arrange
            var arrayManager = new ArrayManager<int>();
            var testArray = new int[] { 1, 2, 3 };

            // Act
            var result = arrayManager.Increase(testArray);

            // Act
            Assert.Equal(testArray.Length, result.Length - 1);
        }

        [Fact]
        public void Increase_ShouldThrowArgNullException_WhenArgIsNull()
        {
            // Arrange
            var arrayManager = new ArrayManager<int>();
            var testArray = (int[])null;

            // Assert
            Assert.Throws<ArgumentNullException>(() => arrayManager.Increase(testArray));
        }
    }
}
