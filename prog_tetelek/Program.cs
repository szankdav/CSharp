// 1. feladat
using System.IO;

//Console.WriteLine("1. feladat");
Console.Write("Kérem írja be az állomány nevét: ");
string fileNev = Console.ReadLine()!;

//void FajlFeldolgozo(string filenev)
//{
//    StreamReader streamReader = new StreamReader(fileNev);
//    int szamokDarabszama = int.Parse(streamReader.ReadLine());
//    int[] szamok = new int[szamokDarabszama];
//    while (!streamReader.EndOfStream)
//    {
//        for (int i = 0; i < szamok.Length; i++)
//        {
//            szamok[i] = int.Parse(streamReader.ReadLine());
//            Console.WriteLine($"{i + 1}. szám: {szamok[i]}");
//        }
//    }
//    streamReader.Close();

//    Console.WriteLine();
//    for (int i = 0; i < szamok.Length; i++)
//    {
//        Console.Write($"{szamok[i]}\t");
//    }

//    int osszeg = 0;
//    foreach (int szam in szamok)
//    {
//        osszeg += szam;
//    }
//    Console.WriteLine();
//    Console.WriteLine($"A számok összege: {osszeg}");
//    Console.WriteLine();
//    Console.WriteLine($"A számok átlaga: {osszeg / szamok.Length}");

//    int legnagyobb = 0;
//    for (int i = 1; i < szamok.Length; i++)
//    {
//        if (szamok[i] > szamok[legnagyobb])
//        {
//            legnagyobb = i;
//        }
//    }
//    Console.WriteLine($"A legnagyobb érték: {szamok[legnagyobb]}");
//    Console.WriteLine();

//    int legkisebb = 0;
//    for (int i = 1; i < szamok.Length; i++)
//    {
//        if (szamok[i] < szamok[legnagyobb])
//        {
//            legkisebb = i;
//        }
//    }
//    Console.WriteLine($"A legkisebb érték: {szamok[legkisebb]}");
//    Console.WriteLine();

//    bool voltNulla = false;
//    for (int i = 0; i < szamok.Length; i++)
//    {
//        if (szamok[i] == 0)
//        {
//            voltNulla = true;
//        }
//    }
//    Console.WriteLine($"{(voltNulla ? "Volt 0 a számok között!" : "Nem volt 0 a számok között!")}");
//    Console.WriteLine();

//    int negativIndex = 0;
//    int index = 0;
//    bool negativ = false;
//    while (!negativ && index < szamok.Length)
//    {
//        if (szamok[index] < 0)
//        {
//            negativIndex = index;
//            negativ = true;
//        }
//        index++;
//    }
//    if (negativ)
//    {
//        Console.WriteLine($"{negativIndex + 1} helyen található az első negatív szám!");
//    }
//    else
//    {
//        Console.WriteLine("Nem található negatív érték a számok között!");
//    }
//    Console.WriteLine();

//    int pozitiv = 0;
//    for (int i = 0; i < szamok.Length; i++)
//    {
//        if (szamok[i] > 0)
//        {
//            pozitiv++;
//        }
//    }
//    Console.WriteLine($"A számok {Math.Round(((double)pozitiv / (double)szamok.Length) * 100, 2)}%-a pozitív!");

//    StreamWriter streamWriter = new StreamWriter("parosaval.txt");
//    for (int i = 0; i < szamok.Length - 1; i += 2)
//    {
//        streamWriter.WriteLine($"{szamok[i]};{szamok[i + 1]};{(((decimal)szamok[1] + (decimal)szamok[i + 1]) / 2).ToString("#0.00")}");
//    }
//    streamWriter.Close();

//}
//FajlFeldolgozo(fileNev);

Console.WriteLine("2. feladat");
//Console.Write("Kérem írja be az állomány nevét: ");
//fileNev = Console.ReadLine()!;

void MasodikFileFeldolgozo(string fileNev)
{
    string[] nevek = new string[File.ReadAllLines(fileNev).Length];
    
    StreamReader streamReader = new StreamReader(fileNev);;
    while (!streamReader.EndOfStream)
    {
        for (int i = 0; i < nevek.Length; i++)
        {
            nevek[i] = streamReader.ReadLine();
        }
    }
    streamReader.Close();
    Console.WriteLine();

    int ketKeresztNev = 0;
    for (int i = 0; i < nevek.Length; i++)
    {
        string[] nevekSzetszedve = nevek[i].Split(' ');
        if (nevekSzetszedve.Length == 3)
        {
            ketKeresztNev++;
        }
    }
    Console.WriteLine($"{ketKeresztNev} embernek van két keresztneve!");
    
    Console.WriteLine("A nevek névsorban:");

    string[] nevekMasolat = new string[nevek.Length];
    for (int i = 0; i < nevek.Length; i++)
    {
        Array.Copy(nevek, nevekMasolat, nevek.Length);
        Array.Sort(nevekMasolat);
        Console.WriteLine($"\t{nevekMasolat[i]}");
    }

    StreamWriter felelokWriter = new StreamWriter("felelok.txt");
    Random random = new Random();
    string[] felelok = new string[3];
    do
    {
        felelok[0] = nevek[random.Next(0, nevek.Length)];
        felelok[1] = nevek[random.Next(0, nevek.Length)];
        felelok[2] = nevek[random.Next(0, nevek.Length)];
    } while (felelok[0] == felelok[1] || felelok[0] == felelok[2] || felelok[1] == felelok[2]);


    for (int i = 0; i < felelok.Length; i++)
    {
        felelokWriter.WriteLine(felelok[i]);
    }
    felelokWriter.Close();

    StreamWriter nagybetusWriter = new StreamWriter("nagybetus.txt");
    for (int i = 0; i < nevek.Length; i++)
    {
        nagybetusWriter.WriteLine(nevek[i].ToUpper());
    }
    nagybetusWriter.Close();

    StreamWriter rendezettWriter = new StreamWriter("rendezett.txt");
    for (int i = 0; i < nevekMasolat.Length; i++)
    {
        rendezettWriter.WriteLine(nevekMasolat[i]);
    }

    Console.WriteLine("A keresztnevek:");
    for (int i = 0; i < nevekMasolat.Length; i++)
    {
        string teljesKeresztNev = nevekMasolat[i].Substring(nevekMasolat[i].IndexOf(' ') + 1);
        string[] keresztNevek = teljesKeresztNev.Split(' ');
        if (keresztNevek.Length > 1)
        {
            for (int j = 0; j < keresztNevek.Length; j++)
            {
                if (j == 0)
                {
                    Console.Write($"\t{keresztNevek[j]}, ");
                }
                else
                {
                    Console.WriteLine($"{keresztNevek[j]}");
                }
            }
        }
        else
        {
            Console.WriteLine($"\t{keresztNevek[0]}");
        }
    }

    Console.Write("Kérem írjon be egy monogramot: ");
    string monogram = Console.ReadLine()!;
    for (int i = 0; i < nevek.Length; i++)
    {
        if (nevek[i].Split(" ").Length == 2 && monogram.Length == 2)
        {
            if (monogram[0].ToString().ToUpper() == nevek[i].Substring(0, 1) && monogram[1].ToString().ToUpper() == nevek[i].Substring(nevek[i].IndexOf(" ") + 1, 1))
            {
                Console.WriteLine($"A keresett monogrammal rendelkező név: {nevek[i]}");
            }
        }
        else if (monogram.Length == 3)
        {
            if (nevek[i].Split(" ").Length == 3)
            {
                if (monogram[0].ToString().ToUpper() == nevek[i].Substring(0, 1) && monogram[1].ToString().ToUpper() == nevek[i].Substring(nevek[i].IndexOf(" ") + 1, 1) && monogram[2].ToString().ToUpper() == nevek[i].Substring(nevek[i].LastIndexOf(" ") + 1, 1))
                {
                    Console.WriteLine($"A keresett monogrammal rendelkező név: {nevek[i]}");
                }
            }
            else
            {
                if (monogram.Substring(0, 2).ToUpper() == nevek[i].Substring(0, 2).ToUpper() && monogram[2].ToString().ToUpper() == nevek[i].Substring(nevek[i].IndexOf(" ") + 1, 1))
                {
                    Console.WriteLine($"A keresett monogrammal rendelkező név: {nevek[i]}");
                }
            }
        }
        else
        {
            if (nevek[i].Split(" ").Length == 3)
            {
                if (monogram.Substring(0, 2).ToUpper() == nevek[i].Substring(0, 2).ToUpper() && monogram[2].ToString().ToUpper() == nevek[i].Substring(nevek[i].IndexOf(" ") + 1, 1) && monogram[3].ToString().ToUpper() == nevek[i].Substring(nevek[i].LastIndexOf(" ") + 1, 1))
                {
                    Console.WriteLine($"A keresett monogrammal rendelkező név: {nevek[i]}");
                }
            }
        }
    }
}

MasodikFileFeldolgozo(fileNev);



Console.ReadKey();