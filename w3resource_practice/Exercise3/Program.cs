using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print the result of dividing two numbers. 
            bool isNumber;
            double number1;
            double number2;

            do
            {
                Console.WriteLine("Please give the first number:");
                isNumber = double.TryParse(Console.ReadLine(), out number1);
                if (!isNumber)
                {
                    Console.WriteLine("The given value is not a number! Please give a valid number!");
                }
            } while (!isNumber);

            do
            {
                Console.WriteLine("Please give the second number:");
                isNumber = double.TryParse(Console.ReadLine(), out number2);
                if (!isNumber)
                {
                    Console.WriteLine("The given value is not a number! Please give a valid number!");
                }
            } while (!isNumber);

            double dividedNumbers = number1 / number2;
            Console.WriteLine("The result is: " + dividedNumbers);

            Console.ReadKey();
        }
    }
}
