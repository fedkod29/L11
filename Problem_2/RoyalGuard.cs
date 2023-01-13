using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    internal class RoyalGuard
    {
        private string _name;
        private int _helthpoint = 2;
        public string Name { get { return _name; } }
        public int Helthpoint { set { _helthpoint = value; } get { return _helthpoint; } }
        public RoyalGuard(string name)
        {
            _name = name;
        }

        public void Defend()
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending");
        }
    }
}
