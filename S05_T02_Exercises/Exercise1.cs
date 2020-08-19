using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_T02_Exercises
{
    class Exercise1
    {
        /*1- Write a program and ask the user to enter a number.The number should be between 1 to 10.
         If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". 
        (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        */

        public Exercise1()
        {
            Console.WriteLine("Hi. Please, write a number:");

            var userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput >= 0 && userInput <= 10)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }

    }
}
