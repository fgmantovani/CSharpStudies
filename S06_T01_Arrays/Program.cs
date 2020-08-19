using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S06_T01_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array 
            var numbers = new[] { 3, 4, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);
            Console.WriteLine("\n");

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);
            Console.WriteLine("\n");

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear(): ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            // Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            // Sort()
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            // Reverse()
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

        }
    }
}
