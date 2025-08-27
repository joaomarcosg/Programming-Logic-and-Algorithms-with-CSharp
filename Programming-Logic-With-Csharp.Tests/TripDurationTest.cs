using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Logic_With_Csharp.exercises;
using Xunit;

namespace Programming_Logic_With_Csharp.Tests
{
    public class TripDurationTest
    {
        [Fact]

        public void CalcTripDurationTest()
        {
            TripDuration calcTripDuration = new();

            int result = calcTripDuration.CalcTripDuration(2, 5);

            Assert.Equal(53, result);
        }
    }
}