using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator calculator = new PrimitiveCalculator();
            calculator.ChangeStrategy();
            string[] input = new string[2];

            Console.Write("Enter numbers or mode: ");
            input = Console.ReadLine().Split(" ");
            while (input[0] != "END")
            {
                if (input[0] == "mode")
                    calculator.ChangeStrategy(Convert.ToChar(input[1]));

                else
                    calculator.PerformCalculation(Convert.ToInt32(input[0]), Convert.ToInt32(input[1]));

                Console.Write("Enter numbers or mode: ");
                input = Console.ReadLine().Split(" ");
            }
        }
    }
}
