using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programming_Logic_With_Csharp.exercises
{
    public class NeighboringNumbers
    {
        public (int prev, int next) CalcNeighbor(int num)
        {
            return (num - 1, num + 1);
        }
    }
}