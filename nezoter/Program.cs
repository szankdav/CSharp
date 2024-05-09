namespace nezoter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] foglalasok = new string[15, 20];
            string[,] arKategoriak = new string[15, 20];

            StreamReader foglalasokReader = new StreamReader("foglaltsag.txt");
            while (!foglalasokReader.EndOfStream)
            {
                for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                    string sorAdatok = foglalasokReader.ReadLine();
                    for (int j = 0; j < sorAdatok.Length; j++)
                    {
                        foglalasok[i, j] = sorAdatok[j].ToString();
                    }
                }
            }
            foglalasokReader.Close();

            StreamReader kategoriaReader = new StreamReader("kategoria.txt");
            while (!kategoriaReader.EndOfStream)
            {
                for (int i = 0; i < arKategoriak.GetLength(0); i++)
                {
                    string sorAdatok = kategoriaReader.ReadLine();
                    for (int j = 0; j < sorAdatok.Length; j++)
                    {
                        arKategoriak[i, j] = sorAdatok[j].ToString();
                    }
                }
            }
            kategoriaReader.Close();

            Console.WriteLine("2. feladat:");
            Console.Write("Kérem írja be a sor számát, amiben foglalni szeretne, majd szóközzel elválasztva a szék számát, amit le szeretne foglalni: ");
            string[] foglalas = Console.ReadLine().Split(' ');
            if (foglalasok[int.Parse(foglalas[0]) - 1, int.Parse(foglalas[1]) - 1] == "o")
            {
                Console.WriteLine("A választott szék még szabad!");
            }
            else
            {
                Console.WriteLine("A választott szék már foglalt!");
            }

            Console.WriteLine();
            Console.WriteLine("3. feladat:");
            double foglaltsagSzamlalo = 0;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i,j] == "x")
                    {
                        foglaltsagSzamlalo++;
                    }
                }
            }

            Console.WriteLine($"Az előadásra eddig {foglaltsagSzamlalo} jegyet adtak el, ez a nézőtér {Math.Round((foglaltsagSzamlalo / 300) * 100), 0}%-a.");
            Console.WriteLine();
            Console.WriteLine("4. feladat:");

            List<int> arKategoriaDb = new List<int>{ 0, 0, 0, 0, 0 };
            for (int i = 0; i < arKategoriak.GetLength(0); i++)
            {
                for (int j = 0; j < arKategoriak.GetLength(1); j++)
                {
                    if (arKategoriak[i,j] == "1")
                    {
                        arKategoriaDb[0]++;
                    }
                    else if (arKategoriak[i,j] == "2")
                    {
                        arKategoriaDb[1]++;
                    }
                    else if (arKategoriak[i, j] == "3")
                    {
                        arKategoriaDb[2]++;
                    }
                    else if (arKategoriak[i, j] == "4")
                    {
                        arKategoriaDb[3]++;
                    }
                    else
                    {
                        arKategoriaDb[4]++;
                    }
                }
            }

            int legtobbArKategoria = arKategoriaDb.IndexOf(arKategoriaDb.Max());

            Console.WriteLine($"A legtöbb jegyet a(z) {legtobbArKategoria + 1}. árkategóriában értékesítették.");
            Console.WriteLine();
            Console.WriteLine("5. feladat:");
            Console.Write("árkategória\t1\t2\t3\t4\t5");
            Console.WriteLine();
            Console.Write($"    ár (Ft)\t{arKategoriaDb[0]*5000}\t{arKategoriaDb[1] * 4000}\t{arKategoriaDb[2] * 3000}\t{arKategoriaDb[3] * 2000}\t{arKategoriaDb[4] * 1500}");
            Console.WriteLine();
            Console.WriteLine("6. feladat:");
            int uresHelyekSzama = 0;
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        if (foglalasok[i, j] == "o" && foglalasok[i, j+1] == "x")
                        {
                            uresHelyekSzama++;
                        }
                    }
                    else if (j < foglalasok.GetLength(1) - 1)
                    {
                        if (foglalasok[i, j] == "o" && foglalasok[i, j + 1] == "x" && foglalasok[i, j - 1] == "x")
                        {
                            uresHelyekSzama++;
                        }
                    }
                }
            }
            Console.WriteLine($"{uresHelyekSzama} db egyedülálló hely van a nézőtéren");
            Console.WriteLine();
            Console.WriteLine("7. feladat:");
            StreamWriter streamWriter = new StreamWriter("szabad.txt");
            for (int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if (foglalasok[i, j] == "o")
                    {
                        streamWriter.Write($"{arKategoriak[i,j]}");
                    }
                    else
                    {
                        streamWriter.Write($"{foglalasok[i,j]}");
                    }
                }
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            Console.WriteLine("A fájlba írás megtörtént!");

            Console.ReadKey();
        }
    }
}
