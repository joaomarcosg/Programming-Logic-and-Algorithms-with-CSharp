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
    }
}