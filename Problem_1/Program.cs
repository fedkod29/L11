using System;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            while(input != "END")
            {
                Console.Write("Enter name: ");
                input = Console.ReadLine();

                dispatcher.Name = input;
            }
        }
    }
}