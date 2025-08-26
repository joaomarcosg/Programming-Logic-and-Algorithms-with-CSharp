using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Programming_Logic_With_Csharp.exercises;

namespace Programming_Logic_With_Csharp.Tests
{
    public class DoubleNumberTest
    {
        [Fact]
        public void DoubleOfNumberTest()
        {
            var doubleOfNumber = new DoubleNumber();

            var result = doubleOfNumber.DoubleOfNumber(5);

            Assert.Equal(10, result);
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(7, 14)]
        [InlineData(-3, -6)]
        public void DoubleOfNumberWithInputs(int input, int expected)
        {
            var doubleOfNumber = new DoubleNumber();
            var result = doubleOfNumber.DoubleOfNumber(input);
            Assert.Equal(expected, result);
        }
    }
}