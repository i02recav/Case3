using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculator.lib;   

namespace calculator.backend.test.steps
    {
        public class SquareRootTests
        {
            [Theory]
            [InlineData(1, 1)]
            [InlineData(4, 2)]
            [InlineData(9, 3)]
            [InlineData(2, 1.41421356237)]
            [InlineData(16, 4)]
            [InlineData(100, 10)]
            [InlineData(2500, 50)]
            [InlineData(123456, 351.364182867)]
            [InlineData(5000000, 2236.0679775)]
            [InlineData(750000, 866.02540378)]
            [InlineData(56547896574698547, 237798016.32899798)]


        public void SQRT_ReturnsExpected(double input, double expected)
            {
                double actual = SquareRoot.SQRT(input);
                double tolerance = 1e-2;
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