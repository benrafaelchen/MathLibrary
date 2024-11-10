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
            Assert.Equal(5, _calculator.Add(2, 3));
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            Assert.Equal(1, _calculator.Subtract(3, 2));
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            Assert.Equal(6, _calculator.Multiply(2, 3));
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            Assert.Equal(2, _calculator.Divide(6, 3));
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
        }

        [Fact]
        public void Add_ShouldHandleLargeNumbers()
        {
            Assert.Equal(int.MaxValue, _calculator.Add(int.MaxValue, 0));
        }

        [Fact]
        public void Subtract_ShouldHandleNegativeResults()
        {
            Assert.Equal(-1, _calculator.Subtract(0, 1));
        }

        [Fact]
        public void Multiply_ShouldHandleZero()
        {
            Assert.Equal(0, _calculator.Multiply(5, 0));
        }

        [Fact]
        public void Divide_ShouldHandleNegativeNumbers()
        {
            Assert.Equal(-2, _calculator.Divide(-6, 3));
        }
    }
}