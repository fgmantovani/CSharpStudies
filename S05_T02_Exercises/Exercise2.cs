using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_T02_Exercises
{
    class Exercise2
    {
        /*
         * 2- Write a program which takes two numbers from the console and displays the maximum of the two.
         */

        public Exercise2()
        {
            Console.WriteLine("Hi. Please, write one number:");

            var userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now write a second number:");

            var userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The maximum of the two number is: " + Math.Max(userInput1, userInput2));
            
        }

    }
}
