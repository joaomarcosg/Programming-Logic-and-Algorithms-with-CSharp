using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Logic_With_Csharp.exercises;
using Xunit;

namespace Programming_Logic_With_Csharp.Tests
{
    public class PizzaAccountTest
    {
        [Fact]

        public void CalcPizzaAccountTest()
        {
            PizzaAccount calcPizzaAccount = new();

            decimal result = calcPizzaAccount.CalcPizzaAccount(90m, 3);

            Assert.Equal(30, result);
        }
    }
}