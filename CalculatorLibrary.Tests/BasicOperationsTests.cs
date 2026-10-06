using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.Tests
{
    public class BasicOperationsTests
    {
        // Making 4 basic tests to ensure methods fail on first try before code is added
        [Fact]
        public void AddTwoNumbersShouldFail()
        {
            // Arrange
            BasicOperations operations = new BasicOperations();
            double expected = 5;

            // Act
            double actual = operations.AddTwoNumbers(2, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractTwoNumbersShouldFail()
        {
            // Arrange
            BasicOperations operations = new BasicOperations();
            double expected = 2;

            // Act
            double actual = operations.SubtractTwoNumbers(5, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplyTwoNumbersShouldFail()
        {
            // Arrange
            BasicOperations operations = new BasicOperations();
            double expected = 10;

            // Act
            double actual = operations.MultiplyTwoNumbers(2, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideTwoNumbersShouldFail()
        {
            // Arrange
            BasicOperations operations = new BasicOperations();
            double expected = 1;

            // Act
            double actual = operations.DivideTwoNumbers(3, 3);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Testing each operation using InlineData
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 20, 30)]
        [InlineData(100, 200, 300)]
        [InlineData(1.5, 2.5, 4)]
        [InlineData(65.75, 34.25, 100)]
        public void AddTwoNumbersReturnCorrectValue(double a, double b, double expected)
        {
            // Arrange
            BasicOperations operations = new BasicOperations();

            // Act
            double actual = operations.AddTwoNumbers(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(2, 2, 0)]
        [InlineData(50, 20, 30)]
        [InlineData(500, 200, 300)]
        [InlineData(6.5, 2.5, 4)]
        [InlineData(65.75, 34.25, 31.5)]
        public void SubractTwoNumbersReturnCorrectValue(double a, double b, double expected)
        {
            // Arrange
            BasicOperations operations = new BasicOperations();

            // Act
            double actual = operations.SubtractTwoNumbers(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 20, 200)]
        [InlineData(100, 200, 20000)]
        [InlineData(1.5, 2.5, 3.75)]
        [InlineData(65.75, 34.25, 2284.8125)]
        public void MultiplyTwoNumbersReturnCorrectValue(double a, double b, double expected)
        {
            // Arrange
            BasicOperations operations = new BasicOperations();

            // Act
            double actual = operations.MultiplyTwoNumbers(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 20, 0.5)]
        [InlineData(100, 200, 0.5)]
        [InlineData(1.5, 2.5, 0.6)]
        [InlineData(65.75, 34.25, 1.8920863309)]
        public void DivideTwoNumbersReturnCorrectValue(double a, double b, double expected)
        {
            // Arrange
            BasicOperations operations = new BasicOperations();

            // Act
            double actual = operations.DivideTwoNumbers(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        // Returning divide by zero exception
        [Fact]
        public void DivideTwoNumbersReturnsDivideByZeroException()
        {
            // Arrange
            BasicOperations divide = new BasicOperations();

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => divide.DivideTwoNumbers(2, 0));
        }
    }
}
