using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S06_T02_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists

            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine();

            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine();

            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine();
        }
    }
}
