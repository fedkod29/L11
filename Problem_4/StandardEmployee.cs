using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Problem_4
{
    internal class StandardEmployee : Employee
    {
        private int _workHoursPerWeek = 40;
        public override int WorkHoursPerWeek { get { return _workHoursPerWeek; } set { _workHoursPerWeek = value; } }

        public StandardEmployee(string name)
        {
            this.Name = name;
        }
    }
}
