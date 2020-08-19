using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace S05_T01_IfElseSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            // Conditional Statements

            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            // Conditional Operators

            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
            
            // Switch\Case

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn.");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's Spring.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's Summer.");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's Winter.");
                    break;

                default:
                    Console.WriteLine("Not Season.");
                    break;
            }

        }
    }
}
