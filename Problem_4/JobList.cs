using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    internal class JobList
    {
        public string _Name { get; set; }
        public int HoursOfWorkRequired { get; set; } 

        public JobList(string name, int hoursOfWorkRequired)
        {
            _Name = name;
            HoursOfWorkRequired = hoursOfWorkRequired;
        }
    }
}
