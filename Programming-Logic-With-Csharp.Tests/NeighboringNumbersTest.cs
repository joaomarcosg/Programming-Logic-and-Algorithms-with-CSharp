using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Logic_With_Csharp.exercises;
using Xunit;

namespace Programming_Logic_With_Csharp.Tests
{
    public class NeighboringNumbersTest
    {
        [Fact]

        public void NeighborTest()
        {
            NeighboringNumbers neighbor = new();

            var result = neighbor.CalcNeighbor(15);

            Assert.Equal(14, result.prev);
            Assert.Equal(16, result.next);
        }
    }
}