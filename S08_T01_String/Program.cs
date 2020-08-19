using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S08_T01_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Frederico Mantovani ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.ToLower());

            Console.WriteLine();

            // IndexOf and Substring
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: {0}", firstName);
            Console.WriteLine("LastName: {0}", lastName);

            Console.WriteLine();

            // Split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: {0}", names[0]);
            Console.WriteLine("LastName: {0}", names[1]);

            // Replace
            Console.WriteLine();
            Console.WriteLine(fullName.Replace("Frederico", "Fred"));

            // IsNullOrWhiteSpace
            Console.WriteLine();
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine();
            
            // Convert
            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            Console.WriteLine();

            // ToString
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
