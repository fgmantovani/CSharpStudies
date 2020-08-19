using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S06_T03_Exercises
{
    class Exercise2
    {
        // 2- Write a program and ask the user to enter their name.
        // Use an array to reverse the name and then store the result
        // in a new string. Display the reversed name on the console.

        public Exercise2()
        {

            Console.WriteLine("Write your name:");

            var input = Console.ReadLine();

            Console.WriteLine("You name is: " + input);

            var newNameArray = new string(input.Reverse().ToArray());

            Console.WriteLine("Your reversed name is: " + newNameArray);
        }
    }
}
