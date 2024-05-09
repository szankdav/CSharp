using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float floatNumberFromStringForFloat = float.Parse(stringForFloat, CultureInfo.InvariantCulture);
            int intNumberFromStringForInt = int.Parse(stringForInt);

            int age = 33;
            string name = "David";

            Console.WriteLine("Hi, my name is {0}, I'am {1} years old", name, age);

            Console.Beep();

            Console.ReadKey();
        }
    }
}
