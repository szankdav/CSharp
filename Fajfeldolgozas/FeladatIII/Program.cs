using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatIII
{
    internal class Program
    {
        struct Tanulo
        {
            public string nev;
            public double atlag;
        }
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("atlagok.txt", true, Encoding.UTF8);
            StreamWriter file2 = new StreamWriter("atlagok.csv", true, Encoding.UTF8);
            Tanulo temp;
            int i = 1;
            do
            {
                Console.WriteLine($"Kérem, adja meg a(z) {i}. tanuló nevét!");
                temp.nev = Console.ReadLine();
                if (temp.nev.ToLower() != "exit")
                {
                    Console.WriteLine($"Kérem, adja meg a(z) {i}. tanuló átlagát!");
                    while (double.TryParse(Console.ReadLine(), out temp.atlag) == false || (temp.atlag < 1 || temp.atlag > 5))
                    {
                        Console.WriteLine("A beírt adat nem megfelelő! Kérem adjon meg másikat!");
                    }
                    // temp.atlag = Convert.ToDouble(Console.ReadLine());
                    file.WriteLine(temp.nev);
                    file.WriteLine(temp.atlag);
                    file2.WriteLine($"{temp.nev};{temp.atlag}");
                    file.Flush();
                    file2.Flush();
                }
                i++;

            } while (temp.nev.ToLower() != "exit");
            file.Close();
            file2.Close();

            Console.ReadKey();
        }
    }
}
