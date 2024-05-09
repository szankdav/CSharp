namespace csipetcsapat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader gyujtemenyReader = new StreamReader("gyujtemeny.txt");
            int[] gyujtemeny = new int[int.Parse(gyujtemenyReader.ReadLine())];
            int index = 0;
            while (!gyujtemenyReader.EndOfStream)
            {
                gyujtemeny[index] = int.Parse(gyujtemenyReader.ReadLine());
                index++;
            }
            gyujtemenyReader.Close();

            Console.WriteLine("3. feladat:");
            VoltENullasNap(gyujtemeny);

            Console.WriteLine("4. feladat:");
            Console.WriteLine($"{AlkalomSzamlalo(gyujtemeny)} alkalommal szedtek legalább 45 darab mogyorót és diót!");

            Console.WriteLine("5. feladat:");
            Console.Write("Kérem írja be a keresett számot: ");
            int keresettSzam = int.Parse(Console.ReadLine());
            GyujtottNapKeresese(keresettSzam);

            Console.WriteLine("6. feladat:");
            Console.WriteLine($"{NemOszthatoGyujtesekSzama(gyujtemeny)} alkalommal fordult elő, hogy nem tudták egyenlő részre szétosztani maguk között az elemózsiát.");

            Console.WriteLine("7. feladat:");
            Console.WriteLine($"{ElsoNapAmikorOtFeleOszthatoAZsakmany(gyujtemeny)}. nap volt az első olyan nap, amikor 5 fele szétosztható az élelem a csapattagok számára");

            Console.WriteLine("8.feladat:");
            FajlKiiras(turboTombLetrehozasa(gyujtemeny));

            void VoltENullasNap(int[] tomb)
            {
                bool voltNap = false;
                for (int i = 0; i < gyujtemeny.Length; i++)
                {
                    if (gyujtemeny[i] == 0)
                    {
                        voltNap = true;
                        break;
                    }
                }

                if (voltNap == false)
                {
                    Console.WriteLine("Nem volt olyan nap, hogy nem gyűjtöttek egyetlen mogyorót és diót sem!");
                }
                else
                {
                    Console.WriteLine("Volt olyan nap, amikor nem gyűjtöttek egyetlen mogyorót és diót sem!");
                }
            }

            int AlkalomSzamlalo(int[] tomb)
            {
                int alkalmakSzama = 0;
                for (int i = 0; i < gyujtemeny.Length; i++)
                {
                    if (gyujtemeny[i] >= 45)
                    {
                        alkalmakSzama++;
                    }
                }
                return alkalmakSzama;
            }

            void GyujtottNapKeresese(int szam)
            {
                bool voltIlyenNap = false;
                for (int i = 0; i < gyujtemeny.Length; i++)
                {
                    if (gyujtemeny[i] == szam)
                    {
                        Console.WriteLine($"A(z) {i + 1}.-ik napon gyűjtöttek pontosan ennyi mogyorót és diót!");
                        voltIlyenNap = true;
                        break;
                    }
                }
                if (voltIlyenNap == false)
                {
                    Console.WriteLine($"Nem volt ilyen nap, amikor pontosan {szam} mogyorót és diót gyűjtöttek!");
                }
            }

            int NemOszthatoGyujtesekSzama(int[] tomb)
            {
                int nemOszthatoGyujtesekSzama = 0;

                for (int i = 0; i < gyujtemeny.Length; i++)
                {
                    if (gyujtemeny[i] % 2 != 0)
                    {
                        nemOszthatoGyujtesekSzama++;
                    }
                }

                return nemOszthatoGyujtesekSzama;
            }

            int ElsoNapAmikorOtFeleOszthatoAZsakmany(int[] tomb)
            {
                int index = 0;

                for (int i = 0; i < gyujtemeny.Length; i++)
                {
                    if (gyujtemeny[i] % 5 == 0)
                    {
                        index = i + 1;
                        break;
                    }
                }
                return index;
            }

            int[] turboTombLetrehozasa(int[] tomb)
            {
                int[] turboTomb = new int[tomb.Length];
                for (int i = 0; i < tomb.Length; i++)
                {
                    turboTomb[i] = tomb[i] * 3;
                }
                return turboTomb;
            }

            void FajlKiiras(int[] tomb)
            {
                StreamWriter turboTombWriter = new StreamWriter("turbo.txt");
                for (int i = 0; i < tomb.Length; i++)
                {
                    turboTombWriter.WriteLine($"{i + 1}. nap: {tomb[i]} darab");
                }
                turboTombWriter.Close();
                Console.WriteLine("A fájl kiírása megtörtént!");
            }


            Console.ReadKey();
        }
    }
}
