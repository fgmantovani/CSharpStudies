using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05_T02_Exercises
{
    class Exercise4
    {
        /*
         * 4- Your job is to write a program for a speed camera. For simplicity,
         * ignore the details such as camera, sensors, etc and focus purely on the logic.
         * Write a program that asks the user to enter the speed limit. Once set, the
         * program asks for the speed of a car. If the user enters a value less than the
         * speed limit, program should display Ok on the console. If the value is above the
         * speed limit, the program should calculate the number of demerit points.
         * For every 5km/hr above the speed limit, 1 demerit points should be incurred and
         * displayed on the console. If the number of demerit points is above 12, the program
         * should display License Suspended.
         */

        public Exercise4()
        {
            Console.WriteLine("Please, write the speed limit:");

            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the speed of the car:");

            var carSpeed = Convert.ToInt32(Console.ReadLine());

            var demeritPoints = carSpeed > speedLimit ? ((carSpeed - speedLimit) / 5.0f) : 0f;
            var demeritExist = demeritPoints != 0 ? "" : "no ";
            var demeritMessage = carSpeed < speedLimit ? "OK" : demeritPoints > 12f ? "License Suspended!" : "OK.";
            var messageLimit = carSpeed > speedLimit ? "above" : "below";

            Console.WriteLine("License {0}. The Car Speed is {1} the speed limit. Measured Car Speed is {2} and {3}the Demerit Points Applied are {4}.", demeritMessage, messageLimit, carSpeed, demeritExist, demeritPoints);

        }
    }
}
