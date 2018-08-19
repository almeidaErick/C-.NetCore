using System;
using System.Collections.Generic;
namespace Custom.UseOfCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var newEnumerable = GetNewCollection();
            var enumerator = newEnumerable.GetEnumerator();

            // Iterate over IEnumerator
            // Generally use "while(nameOfEnumerator.MoveNext())" to iterate over an Ienumerator
            Console.WriteLine("USING IENUMERATOR: ");
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


            // Iterate over IEnumerable
            // Generally use "forach" statement to iterate over an IEnumerable 
            Console.WriteLine("USING IENUMERABLE: ");
            foreach (var nombre in newEnumerable)
            {
                Console.WriteLine(nombre);
            }
        }

        /// <summary>
        /// Gets the new collection.
        /// Static method to easily create a new collection from the main method
        /// </summary>
        /// <returns>The new collection.</returns>
        static IEnumerable<string> GetNewCollection () {
            IEnumerable<string> enumerable = new List<string>() { "1", "2", "3" };
            return enumerable;
        }
    }
}
