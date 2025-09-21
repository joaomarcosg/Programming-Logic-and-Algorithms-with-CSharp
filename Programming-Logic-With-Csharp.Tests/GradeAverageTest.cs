using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Logic_With_Csharp.exercises;
using Xunit;

namespace Programming_Logic_With_Csharp.Tests
{
    public class GradeAverageTest
    {
        [Fact]
        public void CalcGradeAverageTest()
        {
            GradeAverage average = new GradeAverage();

            double result = average.CalcGradeAverage(7, 8);

            Assert.Equal(7.5, result);
        }
    }
}