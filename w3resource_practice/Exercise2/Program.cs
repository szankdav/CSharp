using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print the sum of two numbers. 
            bool isNumeric;
            int number1;
            int number2;
            do
            {
                Console.WriteLine("Please give the first number:");
                isNumeric = int.TryParse(Console.ReadLine(), out number1);
                if (!isNumeric)
                {
                    Console.WriteLine("The given value is not a number! Please give a valid number!");
                }
                } while (!isNumeric) ;

            do
            {
                Console.WriteLine("Please give the second number:");
                isNumeric = int.TryParse(Console.ReadLine(), out number2);
                if (!isNumeric)
                {
                    Console.WriteLine("The given value is not a number! Please give a valid number!");
                }
            } while (!isNumeric);

            int sum = number1 + number2;
            Console.WriteLine("The sum of the two numbers: " +  sum);
            Console.ReadKey();
        }
    }
}
