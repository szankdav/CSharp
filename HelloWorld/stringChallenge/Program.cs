using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringVariable;

            Console.WriteLine("Please enter your name and press enter!");
            stringVariable = Console.ReadLine();
            Console.WriteLine(stringVariable.ToUpper());
            Console.WriteLine(stringVariable.ToLower());
            Console.WriteLine(stringVariable.Trim());
            Console.WriteLine(stringVariable.Substring(0, 3));
            Console.WriteLine("My name is {0}", stringVariable);

            Console.WriteLine("Enter a string here:");
            string enteredString = Console.ReadLine();
            Console.WriteLine("Enter the character to search:");
            char searchedCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine(enteredString.IndexOf(searchedCharacter));
            Console.WriteLine("Please give your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please give your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");

            Console.ReadKey();
        }
    }
}
