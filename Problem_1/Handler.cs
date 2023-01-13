using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_1
{
    internal class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"Dispatcher’s name changed to {args.Name}");
        }
    }
}
