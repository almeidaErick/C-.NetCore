using System;

namespace UseOfDelegates
{
    delegate double DoubleOp(double x);
    delegate int Prueba(int x);
    class Program
    {
        static void Main(string[] args)
        {
            DoubleOp[] operations =
            {
                MathOperations.MultiplyByTwo,
                MathOperations.Square
            };

            Prueba prueba2 = GetHereNumber;

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"Using operations [{i}]");
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
            }

            Console.WriteLine($"Delegate used: {prueba2.Method}, Result: {prueba2(20)}");
        }

        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);
            Console.WriteLine($"Value is {value}, result of operation is {result}");
        }

        static int GetHereNumber(int x)
        {
            return x * 5;
        }
    }

    class MathOperations
    {
        public static double MultiplyByTwo(double value) => value * 2;
        public static double Square(double value) => value * value;

    }
}
