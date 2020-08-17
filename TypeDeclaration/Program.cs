using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 5;
            var speed = 2.5f;
            var firstName = "Fred";
            var characther = 'F';
            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(speed);
            Console.WriteLine(firstName);
            Console.WriteLine(characther);
            Console.WriteLine(Pi);

            byte f = 255;
            f += 2;
            Console.WriteLine(f);

            var k = true;
            var y = false;
            var l = true && false;

            Console.WriteLine(l);
        }
    }
}
