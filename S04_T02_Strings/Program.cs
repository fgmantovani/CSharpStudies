using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S04_T02_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Frederico";
            var lastName = "Mantovani";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Fred", "Arthur", "Ana" };
            var fomrmattedNames = string.Join(", ", names);
            Console.WriteLine(fomrmattedNames);

            var text = @"Hi Fred
Look into the following paths
C:\Folder1\Folder2\Folder3\Folder4\Folder5";

            Console.WriteLine(text);
        }
    }
}
