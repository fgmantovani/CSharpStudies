﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S06_T03_Exercises
{
    class Exercise3
    {
        // 3- Write a program and ask the user to enter 5 numbers. If a number
        // has been previously entered, display an error message and ask the user
        // to re-try. Once the user successfully enters 5 unique numbers, sort them
        // and display the result on the console.

        public Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);

        }

        
    }
}
