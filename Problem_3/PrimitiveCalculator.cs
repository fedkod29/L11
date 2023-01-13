using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Problem_3
{
    public delegate int StrategyHandler(int x, int y);
    public class PrimitiveCalculator
    {
        public StrategyHandler strategyHandler;

        Calculations calculations;

        public void ChangeStrategy(char @operator = '+')
        {
            if (@operator == '+') calculations = new AdditionCalculate();
            else if (@operator == '-') calculations = new SubstractionCalculate();
            else if (@operator == '*') calculations = new MultiplicationCalculate();
            else if (@operator == '/') calculations = new DivisionCalculate();

            else throw new ArgumentException($"{@operator} invalid!");

            strategyHandler += calculations.Calculate;
        }

        public void PerformCalculation(int firstOperand, int secondOperand)
        {
            Console.WriteLine(strategyHandler.Invoke(firstOperand, secondOperand));
            strategyHandler -= calculations.Calculate;
        }
    }
}
