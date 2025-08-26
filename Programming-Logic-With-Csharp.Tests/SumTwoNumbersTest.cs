using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Logic_With_Csharp.exercises;
using Xunit;

namespace Programming_Logic_With_Csharp.Tests
{
    public class SumTwoNumbersTest
    {
        [Fact]
        public void SumTest()
        {
            SumTwoNumbers sumTwoNumbers = new();

            int result = sumTwoNumbers.Sum(10, 20);

            Assert.Equal(30, result);
        }

    }
}