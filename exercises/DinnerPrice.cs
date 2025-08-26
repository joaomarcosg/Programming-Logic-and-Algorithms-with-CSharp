using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programming_Logic_With_Csharp.exercises
{
    public class DinnerPrice
    {
        public decimal CalcDinnerPrice(decimal value)
        {
            decimal waitersTip = value * 10 / 100;
            return value + waitersTip;
        }
    }
}