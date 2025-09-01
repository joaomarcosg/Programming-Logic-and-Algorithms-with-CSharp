using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programming_Logic_With_Csharp.exercises
{
    public class StorePaymentOptions
    {
        public void PaymentOptions(decimal value)
        {
            decimal discount = value * 10 / 100;

            decimal cashPayment = value - discount;

            decimal paymentInInstallments = value / 3;

            Console.WriteLine($"Cash payment (10% off): {cashPayment}");
            Console.WriteLine($"Payment in installments: {paymentInInstallments}");

        } 
    }
}