using System;

namespace UseOfLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take no input, and returns a string
            Func<string> getHelloWorld = () => "Hello World!";

            // Works as previous example.
            //Func<string> getHelloWorld = delegate ()
            //{
            //    return "Hello World!";
            //};

            // Get an int as input, and an int as output
            Func<int, int> Multiply = x => x * x;

            // Get two ints as input, and one string as output
            Func<int, int, string> convertHere = (int x, int y) => (x + y).ToString();

            Console.WriteLine($"First Delegate: {Multiply(10)}");
            Console.WriteLine($"Second Delegate: {Multyply2(4)}");
            Console.WriteLine($"Third Delegate: {convertHere(13, 5)}");
            Console.WriteLine($"No Input Deegate: {getHelloWorld()}");
        }
        static int Multyply2(int x) => x * 50;
    }
}
