using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_T02_Exercises
{
    
    class Exercise3
    {
        /*
        * 3- Write a program and ask the user to enter the width and height of an image.
        * Then tell if the image is landscape or portrait.
        */
        public Exercise3()
        {
            Console.WriteLine("Hi. Please, write the width of the image:");

            var userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now write the height of the image:");

            var userInput2 = Convert.ToInt32(Console.ReadLine());

            string aspect = userInput1 > userInput2 ? "Landscape" : userInput1 < userInput2 ? "Portrait" : "Square!";

            Console.WriteLine("The image is a {0}. The aspect ratio is {1} x {2}.", aspect, userInput1, userInput2);

        }
    }
}
