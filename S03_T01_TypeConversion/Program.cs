using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace S03_T01_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);

            try
            {
                var number = "1234";
                int x = Convert.ToByte(number);
                Console.WriteLine(x);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot convert INT into BYTE");
            }

            try
            {
                string str = "true";
                bool g = Convert.ToBoolean(str);
                Console.WriteLine(g);
            }
            catch (Exception)
            {

            }
        }
    }
}
