using System;

namespace DelegateExample
{
    public delegate void CalculationDelegate(int a, int b);

    class Program
    {
        public static void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum: {num1 + num2}");
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine($"Product: {num1 * num2}");
        }

    }
}