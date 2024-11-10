using Xunit;
using MathLibrary;

namespace MathLibrary.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int a = 3;
            int b = 2;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            // Arrange
            int a = 1;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Fact]
        public void Add_ShouldHandleLargeNumbers()
        {
            // Arrange
            int a = int.MaxValue;
            int b = 0;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void Subtract_ShouldHandleNegativeResults()
        {
            // Arrange
            int a = 0;
            int b = 1;

            // Act
            int result = _calculator.Subtract(a, b);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Multiply_ShouldHandleZero()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act
            int result = _calculator.Multiply(a, b);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Divide_ShouldHandleNegativeNumbers()
        {
            // Arrange
            int a = -6;
            int b = 3;

            // Act
            int result = _calculator.Divide(a, b);

            // Assert
            Assert.Equal(-2, result);
        }
    }
}