using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programming_Logic_With_Csharp.exercises
{
    public class TripDuration
    {
        public int CalcTripDuration(int days, int hours)
        {
            return (days * 24) + hours;
        }
    }
}