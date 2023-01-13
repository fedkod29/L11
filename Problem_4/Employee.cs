using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    abstract class Employee
    {
        private string _name;

        public string Name { get { return this._name; } set { this._name = value; } }
        public abstract int WorkHoursPerWeek { get; set; }

    }
}
