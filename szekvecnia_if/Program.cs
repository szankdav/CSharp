// 1. feladat
//Console.WriteLine("1. feladat");
//Console.Write("Kérem írja be, hogy hány kilogramm almát szeretne vásárolni: ");
//int almaSuly = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be, hogy hány kilogramm szilvát szeretne vásárolni: ");
//int szilvaSuly = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be, hogy hány kilogramm szőlőt szeretne vásárolni: ");
//int szoloSuly = int.Parse(Console.ReadLine()!);

//int almaAr = 240;
//int szilvaAr = 310;
//int szoloAr = 650;

//Console.WriteLine($"Az alma ára kilogrammonként: {almaAr}");
//Console.WriteLine($"Az szilva ára kilogrammonként: {szilvaAr}");
//Console.WriteLine($"Az szőlő ára kilogrammonként: {szoloAr}");
//Console.WriteLine($"Az vásárolni kívánt alma ára: {almaAr * almaSuly}");
//Console.WriteLine($"Az vásárolni kívánt szilva ára: {szilvaAr * szilvaSuly}");
//Console.WriteLine($"Az vásárolni kívánt szőlő ára: {szoloAr * szoloSuly}");
//Console.WriteLine($"A végösszeg: {(almaAr * almaSuly) + (szilvaAr * szilvaSuly) + (szoloAr * szilvaSuly)}");

// 2. feladat
//Console.WriteLine("2. feladat");
//Console.Write("Kérem írja be a napi bevételt: ");
//int napiBevetel = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"A napi jutalom: {Math.Round(napiBevetel * 0.05)}");

// 3. feladat
//Console.WriteLine("3. feladat");
//Console.Write("Kérem írja be, hányan jelentkeztek a színházi előadásra: ");
//int szinhazJelentkezok = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be, hányan jelentkeztek a komolyzenei koncertre: ");
//int komolyzeneJelentkezok = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be, hányan jelentkeztek a népzenei koncertre: ");
//int nepzeneJelentkezok = int.Parse(Console.ReadLine()!);

//Console.WriteLine($"A jegyek a színházi előadásra összesen {szinhazJelentkezok * 2500} Ft.-ba fognak kerülni.");
//Console.WriteLine($"A jegyek a komolyzenei koncertre összesen {komolyzeneJelentkezok * 2200} Ft.-ba fognak kerülni.");
//Console.WriteLine($"A jegyek a népzenei koncertre összesen {nepzeneJelentkezok * 2400} Ft.-ba fognak kerülni.");
//Console.WriteLine($"A jegyek ára összesen: {(szinhazJelentkezok * 2500) + (komolyzeneJelentkezok * 2200) + (nepzeneJelentkezok * 2400)}");

// 4. feladat
//Console.WriteLine("4. feladat");
//Console.Write("Kérem írja be, hogy hanyadika és hány óra van, egy spacel-el elválasztva: ");
//string[] valasz = Console.ReadLine()!.Split(" ");
//string nap = valasz[0];
//string ora = valasz[1];
//if (ora.Length == 2)
//{
//    if (ora[0] == '0')
//    {
//        ora = ora[1].ToString();
//    }
//}
//int honapbanElteltOrak = ((int.Parse(nap) - 1) * 24) + int.Parse(ora);
//Console.WriteLine($"A hónapban eltelt órák száma: {honapbanElteltOrak}");

// 5. feladat
//Console.WriteLine("5. feladat");
//Console.Write("Kérem írja be a pontos órát: ");
//int ora = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a pontos percet: ");
//int perc = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a pontos másodpercet: ");
//int masodPerc = int.Parse(Console.ReadLine()!);

//if ((ora < 0 || ora > 24) || (perc < 0 || perc > 59) || (masodPerc < 0 || masodPerc > 59))
//{
//    Console.WriteLine("Nem megfelelő adatokat adott meg!");
//}
//else
//{
//    Console.WriteLine($"Jelenleg a mai nap {ora}-ik órájában vagyunk!");
//}

// 6. feladat
//Console.WriteLine("6. feladat");
//Console.Write("Kérem adja meg az elért pontszámot: ");
//int elertPontszam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a dolgozaton elérhető maximális pontszámot: ");
//int maxPontszam = int.Parse(Console.ReadLine()!);

//if (elertPontszam > maxPontszam)
//{
//    Console.WriteLine("Nem megfelelő adatok!");
//}
//else if (elertPontszam >= (maxPontszam * 0.85))
//{
//    Console.WriteLine("Jól dolgoztál, ötös a dolgozatod. Ügyes vagy!");
//}
//else
//{
//    Console.WriteLine("Ezt a támakört még gyakorolni kell.");
//}

// 7. feladat
//Console.WriteLine("7. feladat");
//Console.Write("Kérem írja be, hány órakor feküdt le aludni: (hh:mm)");
//string[] elalvasiIdo = Console.ReadLine()!.Split(":");
//int elalvasOra = int.Parse(elalvasiIdo[0]);
//int elalvasiPerc = int.Parse(elalvasiIdo[1]);
//Console.Write("Kérem írja be, hány órakot kelt fel: (hh:mm)");
//string[] kelesiIdo = Console.ReadLine()!.Split(":");
//int kelesiOra = int.Parse(kelesiIdo[0]);
//int kelesiPerc = int.Parse(kelesiIdo[1]);

//int alvasOrak = 0;
//int alvasPercek = 0;
//int elevasiOraUtaniPercek = 0;
//if (elalvasOra > kelesiOra)
//{
//    alvasOrak = (24 - (elalvasOra + 1) + kelesiOra);
//    elevasiOraUtaniPercek = 60 - elalvasiPerc;
//	if (kelesiPerc + elevasiOraUtaniPercek > 59)
//	{
//        alvasPercek = kelesiPerc + elevasiOraUtaniPercek - 60;
//        alvasOrak += 1;
//    }
//	if (alvasOrak >= 7 && alvasOrak < 9)
//	{
//        Console.WriteLine($"{alvasOrak}:{alvasPercek} az alvás ideje.");
//		Console.WriteLine("Megfelelő alvásmennyiség!");
//    }
//	else if (alvasOrak >= 9)
//	{
//        Console.WriteLine($"{alvasOrak}:{alvasPercek} az alvás ideje.");
//        Console.WriteLine("Túl sokat aludtál!");
//    }
//    else if (alvasOrak < 7)
//    {
//        Console.WriteLine($"{alvasOrak}:{alvasPercek} az alvás ideje.");
//        Console.WriteLine("Túl sokat aludtál!");
//    }
//}

Console.ReadKey();