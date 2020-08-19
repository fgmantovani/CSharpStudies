using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_T04_Exercises
{
    class Exercise2
    {
        // 2- Write a program and continuously ask the user to enter a number
        // or "ok" to exit.Calculate the sum of all the previously entered
        // numbers and display it on the console.

        public Exercise2()
        {
            var sum = 0f;
            
           
            while (true)
            {
                Console.WriteLine("Write a number, or \"OK\" to exit:");
                var input = Console.ReadLine();


                if (input.ToLower() == "ok")
                {
                    break;
                }

                sum += Convert.ToInt32(input);

            }

            Console.WriteLine("The sum of all numbers is: " + sum);

        }

    }
}
