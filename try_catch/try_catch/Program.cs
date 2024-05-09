using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kerem adjon meg egy szamot 1 es 10 kozott!");
                int szam = Convert.ToInt32(Console.ReadLine());
                if (szam >= 1 && szam <= 10)
                {
                    Console.WriteLine($"A beirt szam: {szam}");
                }
                else
                {
                    throw new Exception("A beirt szam nem a kert tartomanyban van! Kerem, 1 es 10 kozotti szamot adjon meg!");
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
