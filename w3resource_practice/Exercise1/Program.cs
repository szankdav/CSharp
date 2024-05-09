using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print Hello and your name in a separate line. 
            Console.WriteLine("Please give your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello: " + name);
            Console.ReadKey();
        }
    }
}
