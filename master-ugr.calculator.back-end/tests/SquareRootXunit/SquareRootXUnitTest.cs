using System;
using Xunit;
using calculator.lib;

namespace SquareRootXunit
{
    public class SquareRootTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 2)]
        [InlineData(9, 3)]
        [InlineData(2, 1.41421356237)]
        [InlineData(16, 4)]
        public void SQRT_ReturnsExpected(double input, double expected)
        {
            double actual = SquareRoot.SQRT(input);
            double tolerance = 1e-6;
            Assert.InRange(actual, expected - tolerance, expected + tolerance);
        }

        [Fact]
        public void SQRT_Zero_ReturnsZero()
        {
            Assert.Equal(0d, SquareRoot.SQRT(0));
        }

        [Fact]
        public void SQRT_Negative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SquareRoot.SQRT(-1));
        }
    }
}