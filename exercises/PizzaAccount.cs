using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programming_Logic_With_Csharp.exercises
{
    public class PizzaAccount
    {
        public decimal CalcPizzaAccount(decimal value, int numberOfClientes)
        {
            if (numberOfClientes <= 0)
                throw new ArgumentException("number of clients must be bigger than zero");
                
            return value / numberOfClientes;
        }
    }
}