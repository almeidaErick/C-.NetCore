using System;

namespace UsingExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var newWord = "Hello World";
            var newInt = 11;

            Console.WriteLine($"Word: {newWord}, Length: {newWord.GetWordCount()}");
            Console.WriteLine($"Number: {newInt}, Is Greater than 10: {newInt.IsGreaterThatTen()}");
        }
    }

    /// <summary>
    /// Define Extension methods for string and integer variables. 
    /// </summary>
    public static class StringExtension
    {
        public static int GetWordCount(this string s) => s.Split().Length;

        public static bool IsGreaterThatTen(this int i) => i > 10;
    }
}
