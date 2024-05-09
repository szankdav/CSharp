namespace cukraszda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int>[] tortak = new Tuple<string, int>[40];

            StreamReader tortaReader = new StreamReader("tortak.txt");
            int index = 0;
            while (!tortaReader.EndOfStream)
            {
                string[] adatok = tortaReader.ReadLine().Split(';');
                Tuple<string, int> torta = new Tuple<string, int>(adatok[0], int.Parse(adatok[1]));
                tortak[index] = torta;
                index++;
            }

            Console.WriteLine("2. feladat:");
            for (int i = 0; i < tortak.Length; i++)
            {
                if (tortak[i] != null)
                {
                    Console.WriteLine($"{tortak[i].Item1} ({tortak[i].Item2} Ft)");
                }
            }
            Console.WriteLine("3. feladat:");
            double osszTortaAr = 0;
            int tortaDarab = 0;
            for (int i = 0;i < tortak.Length; i++)
            {
                if (tortak[i] != null)
                {
                    osszTortaAr += tortak[i].Item2;
                    tortaDarab++;
                }
            }
            Console.WriteLine($"Átlagosan {(osszTortaAr / tortaDarab).ToString("0.00")} Ft.-ba kerül egy torta.");

            Console.WriteLine("4. feladat");
            int legdragabbTortaIndexe = 0;

            for (int i = 0; i < tortak.Length; i++)
            {
                if (tortak[i] != null)
                {
                    if (tortak[legdragabbTortaIndexe].Item2 < tortak[i].Item2)
                    {
                        legdragabbTortaIndexe = i;
                    }
                }
            }

            Console.WriteLine($"A legdrágább torta neve: {tortak[legdragabbTortaIndexe].Item1}, ára: {tortak[legdragabbTortaIndexe].Item2} Ft.-");

            Console.WriteLine("5. feladat");
            for (int i = 0; i < tortak.Length; i++)
            {
                if (tortak[i] != null)
                {
                    if (tortak[i].Item2 <= 4500)
                    {
                        Console.WriteLine($"{tortak[i].Item1}");
                    }
                }
            }

            Console.WriteLine("6. feladat");
            Console.Write("Kérem adja meg a keresett torta nevét: ");
            string keresettTorta = Console.ReadLine();
            bool vanTorta = false;
            for (int i = 0; i < tortak.Length; i++)
            {
                if (tortak[i] != null)
                {
                    if (tortak[i].Item1 == keresettTorta)
                    {
                        Console.WriteLine($"Igen, rendelhető {tortak[i].Item1} torta, melynek ára: {tortak[i].Item2} Ft.-");
                        vanTorta= true;
                        break;
                    }
                }
            }
            if (vanTorta == false)
            {
                Console.WriteLine($"Nem rendelhető {keresettTorta} nevű torta!");
            }

            Console.ReadKey();
        }
    }
}
