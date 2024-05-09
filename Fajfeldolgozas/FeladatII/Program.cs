using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("NevekFajlba.txt", true, Encoding.Default);

            string nev;
            do
            {
                Console.WriteLine("Kérem, adjon meg egy nevet!");
                nev = Console.ReadLine();
                if (nev.Trim().ToLower() != "exit")
                {
                    file.WriteLine(nev);
                    file.Flush();
                }

            } while (nev.Trim().ToLower() != "exit");
            file.Close();

            Console.ReadKey();
        }
    }
}
