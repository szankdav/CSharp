using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroJackpotRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<byte>> huzasok = new List<List<byte>>();
            StreamReader reader = new StreamReader("eurojackpot.csv", Encoding.UTF8);
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string[] sor = reader.ReadLine().Split(';');
                List<byte> szamok = new List<byte>
                {
                    (byte.Parse(sor[28])),
                    (byte.Parse(sor[29])),
                    (byte.Parse(sor[30])),
                    (byte.Parse(sor[31])),
                    (byte.Parse(sor[32])),
                    (byte.Parse(sor[33])),
                    (byte.Parse(sor[34]))
                };
                huzasok.Add(szamok);
            }
            reader.Close();
            foreach (List<byte> sor in huzasok)
            {
                string szamSor = string.Join(";", sor);
                Console.WriteLine(szamSor);
            }

            Random random = new Random();
            List<int> veletelenOtSzam = new List<int>();
            List<int> veletlenKettoSzam = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                if (i < 2)
                {
                    veletlenKettoSzam.Add(random.Next(1, 11));
                    Console.WriteLine("Kettes: " + veletlenKettoSzam[i]);
                }
                veletelenOtSzam.Add(random.Next(1, 51));
                Console.WriteLine("Otos: " + veletelenOtSzam[i]);
            }
            
            Console.ReadKey();
        }
    }
}
