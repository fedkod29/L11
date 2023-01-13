using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Problem_4
{
    internal class PartTimeEmployee : Employee
    {
        private int _workHoursPerWeek = 20;
        public override int WorkHoursPerWeek { get { return _workHoursPerWeek; } set { _workHoursPerWeek = value; } }

        public PartTimeEmployee(string name)
        {
            this.Name = name;
        }
    }
}
