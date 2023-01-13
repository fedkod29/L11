using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    public delegate void ReactionOnAttack();
    internal class King
    {
        private string _name;

        public string Name { get { return _name; } }

        public King(string name)
        {
            _name = name;
        }

        public event ReactionOnAttack HelpKing;

        public void Attack()
        {
            Console.WriteLine($"The king {this.Name} is under attack");
            HelpKing?.Invoke();
        }
    }
}
