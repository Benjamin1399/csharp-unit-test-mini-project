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
    }
}
