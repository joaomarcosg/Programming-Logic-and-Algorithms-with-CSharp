using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Logic_With_Csharp.exercises;
using Xunit;

namespace Programming_Logic_With_Csharp.Tests
{
    public class DinnerPriceTest
    {
        [Fact]

        public void CalcDinnerPriceTest()
        {
            DinnerPrice calcDinnerPrice = new();

            decimal result = calcDinnerPrice.CalcDinnerPrice(80);

            Assert.Equal(88, result);
        }
    }
}