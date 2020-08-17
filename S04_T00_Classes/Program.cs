using Classes.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Classes;

namespace S04_T00_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var fred = new Person();
            fred.FirstName = "Frederico";
            fred.LastName = "Mantovani";
            fred.Introduce();

            Calculator calc = new Calculator();
            var result = calc.Add(5, 2);
            Console.WriteLine(result);
        }
    }
}
