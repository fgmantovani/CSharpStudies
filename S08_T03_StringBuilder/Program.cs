using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S08_T03_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Append, AppendLine and Replace
            var builder = new StringBuilder();
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine(builder[0]);
        }
    }
}
