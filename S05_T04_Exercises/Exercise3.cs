using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_T04_Exercises
{
    class Exercise3
    {
        // 3- Write a program and ask the user to enter a number.Compute the factorial of the number
        // and print it on the console.For example, if the user enters 5, the program should
        // calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        public Exercise3()
        {

            Console.WriteLine("Enter a number:");

            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for (int i = input; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("The !{0} = " + factorial, input);

        }

    }
}
