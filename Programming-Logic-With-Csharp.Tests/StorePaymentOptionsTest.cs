using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programming_Logic_With_Csharp.exercises;
using Xunit;

namespace Programming_Logic_With_Csharp.Tests
{
    public class StorePaymentOptionsTest
    {
        [Fact]
        public void PaymentOptionsPrintCorrectValues()
        {
            StorePaymentOptions payment = new StorePaymentOptions();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            payment.PaymentOptions(60.00m);

            var output = stringWriter.ToString();

            Assert.Contains("Cash payment (10% off): 54", output);
            Assert.Contains("54", output);
            Assert.Contains("Payment in installments: 20", output);
            Assert.Contains("20", output);
        }
    }
}