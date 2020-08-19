using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_T04_Exercises
{
    class Exercise4
    {
        // 4- Write a program that picks a random number between 1 and 10.
        // Give the user 4 chances to guess the number.If the user guesses
        // the number, display “You won"; otherwise, display “You lost".
        // (To make sure the program is behaving correctly, you can display
        // the secret number on the console first.)

        public Exercise4()
        {

            var randomNumber = new Random().Next(1, 10);
            var tries = 0;

            Console.WriteLine("The secret number is: " + randomNumber);

            while (true)
            {
                if (tries >= 4)
                {
                    Console.WriteLine("You lost!");
                    break;
                }

                Console.WriteLine("Try to guess a number between 1 and 10? Write your guess:");
                
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess != randomNumber)
                {
                    ++tries;
                    continue;
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("You Won.");
                    break;
                }

            }
        }
    }
}
