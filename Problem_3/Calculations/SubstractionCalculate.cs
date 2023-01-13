using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    internal class SubstractionCalculate : Calculations
    {
        public override int Calculate(int x, int y)
        {
            return Convert.ToInt32(x / y);
        }
    }
}
