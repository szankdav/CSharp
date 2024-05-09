// 1. feladat
//Console.WriteLine("1. feladat");
//Console.Write("Kérem írja be a maximális pontszámot: ");
//int maxPontszamok = int.Parse(Console.ReadLine()!);
//int jeles = (int)(Math.Ceiling(maxPontszamok * 0.85));
//int jo = (int)(Math.Ceiling(maxPontszamok * 0.70));
//int kozepes = (int)(Math.Ceiling(maxPontszamok * 0.55));
//int elegseges = (int)(Math.Ceiling(maxPontszamok * 0.40));

//Console.WriteLine($"A megadott pontszámhoz tartozó értékelés határok:");
//Console.WriteLine($"\tJeles: {jeles}");
//Console.WriteLine($"\tJo: {jo}");
//Console.WriteLine($"\tKözepes: {kozepes}");
//Console.WriteLine($"\tElégséges: {elegseges}");

//2. feladat
//Console.WriteLine("2. feladat");
//Console.Write("Kérem adja meg az első számot: ");
//int elsoSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem adja meg a második számot: ");
//int masodikSzam = int.Parse(Console.ReadLine()!);
//Random rand = new Random();
//for (int i = 0; i < 6; i++)
//{
//    if (i < 3)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"{rand.Next(elsoSzam, masodikSzam + 1)}");
//    }
//    else
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"{rand.Next(elsoSzam, masodikSzam + 1)}");
//    }
//    Console.ForegroundColor= ConsoleColor.White;
//}

// 3.feladat
//Console.WriteLine("3. feladat");
//Console.Write("Kérem adja meg az első pont x koordinátáját: ");
//int x1 = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem adja meg az első pont y koordinátáját: ");
//int y1 = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem adja meg az második pont x koordinátáját: ");
//int x2 = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem adja meg az második pont y koordinátáját: ");
//int y2 = int.Parse(Console.ReadLine()!);

//double tavolsag = Math.Sqrt((x1 - x2) * (x1 - x2) + (y2 - y1) * (y2 - y1));
//Console.WriteLine(tavolsag);

// 4.feladat
//using System;

//Console.WriteLine("4. feladat");
//Console.Write("Kérem írja be a könyvek összértékét: ");
//int osszertek = int.Parse(Console.ReadLine()!);
//Random random = new Random();
//double kedvezmeny = random.Next(0, 51);
//Console.WriteLine($"A fizetendő összeg a kedvezmény ({Math.Round(kedvezmeny)}%) levonása után: {Math.Round(osszertek * (kedvezmeny / 100))}");


// 5. feladta
//Console.WriteLine("5. feladat");
//Console.Write("Kérem írja be a kör átmérőjét: ");
//int atmero = int.Parse(Console.ReadLine()!);
//double kerulet = atmero * Math.PI;
//double terulet = Math.Pow(atmero / 2, 2) * Math.PI;

//Console.WriteLine($"A kör kerülete: {kerulet.ToString("0.000")}, területe: {terulet.ToString("0.000")}");


// 6. feladat
//Console.WriteLine("6. feladat");
//Console.Write("Kérem írja be az osztály létszámát: ");
//int osztalyLetszam = int.Parse(Console.ReadLine()!);
//Random random = new Random();
//int veletelenDiak = random.Next(0, osztalyLetszam + 1);

//Console.WriteLine($"Az osztály {veletelenDiak}-ik tagja legyen a felelő!");


// 7. feladat
//Console.WriteLine("7. feladat");
//Console.Write("Kérem írja be, hány négyzetlap van: ");
//int negyzetLapok = int.Parse(Console.ReadLine()!);
//int nagyNegyzetOldala = (int)Math.Round(Math.Sqrt(negyzetLapok));
//int maradekLapok = negyzetLapok - (nagyNegyzetOldala * nagyNegyzetOldala);

//Console.WriteLine($"A legnagyobb négyzet oldalának egységhossza ami kirakható: {nagyNegyzetOldala}");
//Console.WriteLine($"A maradék lapok száma: {maradekLapok}");

//Console.ReadKey();