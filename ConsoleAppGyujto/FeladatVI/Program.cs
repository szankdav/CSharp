using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatVI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber;
            int num;
            do
            {
                Console.WriteLine("Please give a number: ");

                isNumber = int.TryParse(Console.ReadLine(), out num);

                if (!isNumber)
                {
                    Console.WriteLine("The given data is not a number! Please give a valid number!");
                }
            } while (!isNumber);

            /*if (num % 2 == 0)
            {
                double numEven = Math.Pow(num, 2);
                Console.WriteLine(numEven);
            } 
            else
            {
                double numOdd = Math.Pow(num, 3);
                Console.WriteLine(numOdd);
            }*/

            Console.WriteLine(Math.Pow(num, (num % 2 == 0) ? 2 : 3));

            Console.ReadKey();
        }
    }
}
