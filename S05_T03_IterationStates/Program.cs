using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace S05_T03_IterationStates
{
    class Program
    {
        static void Main(string[] args)
        {

            // for loops
            Console.WriteLine("\n");
            Console.WriteLine("#### for Loop ####");

            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\n");

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // for each loops
            Console.WriteLine("\n");
            Console.WriteLine("#### foreach Loop ####");

            var name = "Frederico Mantovani";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\n");

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("\n");

            var numbers = new int[] {1, 2, 3, 4};

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // While
            Console.WriteLine("\n");
            Console.WriteLine("#### While Loop ####");

            var count = 1;

            while (count <= 10)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine(count);
                }

                ++count;
            }

            Console.WriteLine("\n");

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }

            // Random
            Console.WriteLine("\n");
            Console.WriteLine("#### Random Class ####");

            var random = new Random();

            const int pwLenght = 10;
            var buffer = new char[pwLenght];

            for (int i = 0; i < pwLenght; i++)
            {
                buffer[i] = (char)('a' + random.Next(0,26));
            }

            var password = new string(buffer);

            Console.WriteLine(password);
            Console.WriteLine("\n");

        }
    }
}
