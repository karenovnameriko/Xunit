using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"5 + 3 = {calc.Add(5, 3)}");
            Console.WriteLine($"5 - 3 = {calc.Subtract(5, 3)}");
            Console.WriteLine($"5 * 3 = {calc.Multiply(5, 3)}");
            Console.WriteLine($"5 / 3 = {calc.Divide(5, 3)}");

            try
            {
                calc.Divide(5, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
