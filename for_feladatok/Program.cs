// 1. feladat
//Console.WriteLine("1. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= szam; i++)
//{
//    Console.Write($"{i}, ");
//}


// 2. feladat
//Console.WriteLine("2. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= szam; i++)
//{
//	if (Math.Sqrt(i) % 1 == 0)
//	{
//        Console.Write($"{i}, ");
//    }
//}

// 3. feladat
//Console.WriteLine("3. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = szam; i > 0; i--)
//{
//    Console.Write($"{i}, ");
//}

// 4. feladat
//Console.WriteLine("4. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= szam; i++)
//{
//	if (i % 2 == 0)
//	{
//        Console.Write($"{i}, ");
//    }
//}

// 5. feladat
//Console.WriteLine("5. feladat");
//Console.Write("Kérem írja be az első számot: ");
//int elsoSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a második számot: ");
//int masodikSzam = int.Parse(Console.ReadLine()!);

//for (int i = elsoSzam; i < masodikSzam + 1; i++)
//{
//    Console.Write($"{i}, ");
//}

// 6. feladat
//Console.WriteLine("6. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"{szam * i}, ");
//}

// 7. feladat
//Console.WriteLine("7. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = szam; i < 100; i = i * szam)
//{
//    Console.Write($"{i}, ");
//}

// 8. feladat
//Console.WriteLine("8. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = 1; i < szam + 1; i++)
//{
//	if ((szam / i) % 2 == 0)
//	{
//        Console.WriteLine($"{i}, ");
//    }
//}

// 9 . feladat
//Console.WriteLine("9. feladat");
//Console.Write("Kérem írja be a hatványalapot: ");
//int hatvanyAlap = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a hatványkitevőt: ");
//int hatvanyKitevo = int.Parse(Console.ReadLine()!);
//int hatvanyErtek = hatvanyAlap;
//for (int i = 1; i < hatvanyKitevo; i++)
//{
//    hatvanyErtek *= hatvanyAlap;
//}

//Console.WriteLine(hatvanyErtek);

// 10. feladat
//Console.WriteLine("10. feladat");
//Console.Write("Kérem írja be az alsó határszámot: ");
//int elsoSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a felső határszámot: ");
//int masodikSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írjon be egy intervallumba eső számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int i = elsoSzam; i <= masodikSzam; i++)
//{
//	if (i % szam == 0)
//	{
//        Console.Write($"{i}, ");
//    }
//}


// 11. feladat
//Console.WriteLine("11. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);
//Random random = new Random();
//for (int i = 0; i < szam; i++)
//{
//    Console.Write($"{random.Next(0, 101)}, ");
//}

// 12. feladat
//Console.WriteLine("12. feladat");
//Console.Write("Kérem írja be az alsó határszámot: ");
//int elsoSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a felső határszámot: ");
//int masodikSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be hány számot szeretne generálni: ");
//int szam = int.Parse(Console.ReadLine()!);

//Random random = new Random();

//for (int i = 0; i < szam; i++)
//{
//    Console.WriteLine(random.NextDouble() * (elsoSzam - masodikSzam) + masodikSzam);
//}

// 13. feladat
//Console.WriteLine("13. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);
//string[] fejVagyIras = {"fej", "írás"};
//Random random = new Random();
//for (int i = 0; i < szam; i++)
//{
//    Console.WriteLine($"{fejVagyIras[random.Next(0, fejVagyIras.Length)]}");
//}

// 14. feladat
//Console.WriteLine("14. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);
//int ertek = 0;
//for (int i = 1; i <= szam; i++)
//{
//    Console.Write($"{i}*{i + 1}");
//    if (i < szam)
//    {
//        Console.Write("+");
//    }
//    ertek += i * (i + 1);
//	if (i == szam)
//	{
//        Console.Write("=");
//        Console.Write(ertek);
//    }
//}

// 15. feladat
//Console.WriteLine("15. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);
//for (int i = 1; i <= szam; i++)
//{
//	if (i == 1 || i == szam)
//	{
//		for (int j = 1; j <= szam; j++)
//		{
//			if (j < szam)
//			{
//                Console.Write("# ");
//            }
//			else
//			{
//                Console.WriteLine("#");
//            }
//        }
//    }
//	else
//	{
//		for (int k = 1; k <= szam; k++)
//		{
//			if (k == 1)
//			{
//                Console.Write("# ");
//            }
//			else if (k == szam)
//			{
//                Console.WriteLine("#");
//            }
//			else
//			{
//                Console.Write("  ");
//            }
//		}
//	}
//}

// 16. feladat
//Console.WriteLine("16. feladat");
//Console.Write("Kérem írja be az sorok számát: ");
//int sorSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be az oszlopok számát: ");
//int oszlopSzam = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= sorSzam; i++)
//{
//	for (int j = 1; j <= oszlopSzam; j++)
//	{
//		if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
//		{
//            Console.Write("X");
//        }
//        else
//        {
//            Console.Write("O");
//        }

//        if (j == oszlopSzam)
//        {
//            Console.WriteLine();
//        }
//    }
//}

// 17. feladat
//Console.WriteLine("17. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//for (int csillag = 0; csillag < szam; csillag++)
//{
//    for (int i = 0; i < (szam - csillag - 1); i++)
//    {
//        Console.Write(" ");
//    }
//    for (int i = 0; i < (csillag * 2 + 1); i++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

// 18. feladat
//Console.WriteLine("18. feladat");
//for (int i = -99; i < 100; i++)
//{
//	if (i % 3 == 0 && i % 2 != 0)
//	{
//        Console.Write($"{i}, ");
//    }
//}

// 19. feladat
//Console.WriteLine("19. feladat");
//Random random = new Random();
//for (int i = 1; i < 15; i++)
//{
//    Console.WriteLine($"{i}.nap: {random.Next(30, 181)} perc.");
//}

// 20. feladat
//Console.WriteLine("20. feladat");
//for (int i = 100; i < 1000; i++)
//{
//	string haromSzamJegy = i.ToString();
//	double elsoJegy = Char.GetNumericValue(haromSzamJegy[0]);
//    double masodikJegy = Char.GetNumericValue(haromSzamJegy[1]);
//    double harmadikJegy = Char.GetNumericValue(haromSzamJegy[2]);
//    if (Math.Pow(elsoJegy, 3) + Math.Pow(masodikJegy, 3) + Math.Pow(harmadikJegy, 3) == i)
//	{
//        Console.WriteLine(i);
//    }
//}

Console.ReadKey();