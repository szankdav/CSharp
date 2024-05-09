using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVBeolvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("beolvasas.csv", Encoding.UTF8);
            while (!file.EndOfStream)
            {
                Console.WriteLine(file.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
