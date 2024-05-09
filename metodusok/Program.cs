using System.Drawing;
using System.Xml;
// 1. feladat
//Console.WriteLine("1. feladat");
//void TeglalapRajzolo(int aOldal, int bOldal, string szin)
//{
//	switch (szin.ToLower())
//	{
//		case "fekete":
//			Console.ForegroundColor = ConsoleColor.Black;
//			break;
//        case "sötétkék":
//            Console.ForegroundColor = ConsoleColor.DarkBlue;
//            break;
//        case "sötétzöld":
//            Console.ForegroundColor = ConsoleColor.DarkGreen;
//            break;
//        case "vörös":
//            Console.ForegroundColor = ConsoleColor.DarkRed;
//            break;
//        case "sötétmagenta":
//            Console.ForegroundColor = ConsoleColor.DarkMagenta;
//            break;
//        case "szürke":
//            Console.ForegroundColor = ConsoleColor.Gray;
//            break;
//        case "sötétszürke":
//            Console.ForegroundColor = ConsoleColor.DarkGray;
//            break;
//        case "kék":
//            Console.ForegroundColor = ConsoleColor.Blue;
//            break;
//        case "zöld":
//            Console.ForegroundColor = ConsoleColor.Green;
//            break;
//        case "cián":
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            break;
//        case "piros":
//            Console.ForegroundColor = ConsoleColor.Red;
//            break;
//        case "magenta":
//            Console.ForegroundColor = ConsoleColor.Magenta;
//            break;
//        case "sárga":
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            break;
//        case "black":
//            Console.ForegroundColor = ConsoleColor.Black;
//            break;
//        case "darkblue":
//            Console.ForegroundColor = ConsoleColor.DarkBlue;
//            break;
//        case "darkgreen":
//            Console.ForegroundColor = ConsoleColor.DarkGreen;
//            break;
//        case "darkred":
//            Console.ForegroundColor = ConsoleColor.DarkRed;
//            break;
//        case "darkmagenta":
//            Console.ForegroundColor = ConsoleColor.DarkMagenta;
//            break;
//        case "gray":
//            Console.ForegroundColor = ConsoleColor.Gray;
//            break;
//        case "darkgray":
//            Console.ForegroundColor = ConsoleColor.DarkGray;
//            break;
//        case "blue":
//            Console.ForegroundColor = ConsoleColor.Blue;
//            break;
//        case "green":
//            Console.ForegroundColor = ConsoleColor.Green;
//            break;
//        case "cyan":
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            break;
//        case "red":
//            Console.ForegroundColor = ConsoleColor.Red;
//            break;
//        case "yellow":
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            break;
//        default:
//            Console.ForegroundColor = ConsoleColor.White;
//			break;
//	}

//    for (int i = 1; i <= bOldal; i++)
//    {
//        for (int j = 1; j <= aOldal; j++)
//        {
//            if (i == 1 || i == bOldal)
//            {
//                if (j > 1 || j < aOldal)
//                {
//                    Console.Write("# ");
//                }
//                else
//                {
//                    Console.Write("#");
//                }
//            }
//            else
//            {
//                if (j == 1 || j == aOldal)
//                {
//                    Console.Write("# ");
//                }
//                else
//                {
//                    Console.Write("  ");
//                }
//            }
//            if (j == aOldal)
//            {
//                Console.WriteLine();
//            }
//        }
//    }
//}
//int aOldal;
//int bOldal;

//Console.Write("Kérem adja meg a téglalp a oldalát: ");
//do
//{
//    if (int.TryParse(Console.ReadLine(), out aOldal) == false)
//    {
//        Console.Write("A megadott érték nem szám! Kérem, számot adjon meg: ");
//    }
//    else if (aOldal < 0)
//    {
//        Console.Write("A megadott szám nem pozitív! Kérem pozitív számot adjon meg: ");
//    }
//} while (!(aOldal > 0));

//Console.Write("Kérem adja meg a téglalp b oldalát: ");
//do
//{
//    if (int.TryParse(Console.ReadLine(), out bOldal) == false)
//    {
//        Console.Write("A megadott érték nem szám! Kérem, számot adjon meg: ");
//    }
//    else if (bOldal < 0)
//    {
//        Console.Write("A megadott szám nem pozitív! Kérem pozitív számot adjon meg: ");
//    }
//} while (!(bOldal > 0));

//Console.Write("Kérem írja be a szín nevét, amivel rajzolni szeretne: ");
//string szin = Console.ReadLine()!;

//TeglalapRajzolo(aOldal, bOldal, szin);

// 2.feladat
//Console.WriteLine("2. feladat");
//void RombuszRajzolo(int oldal)
//{

//    for (int i = 0; i < oldal; i++)
//    {
//        for (int j = 0; j < oldal; j++)
//        {

//        }
//    }
//}

// 3. feladat
//Console.WriteLine("3. feladat");
//string Penzvaltas(int osszeg)
//{
//	if ((osszeg - 1) % 5 == 0)
//	{
//		osszeg -= 1;
//	}
//	else if ((osszeg - 2) % 5 == 0)
//	{
//		osszeg -= 2;
//	}
//	else if ((osszeg + 1) % 5 == 0)
//	{
//		osszeg += 1;
//	}
//	else if ((osszeg + 2) % 5 == 0)
//	{
//		osszeg += 2;
//	}

//	int ketszazas = 0;
//	int szazas = 0;
//	int otvenes = 0;
//	int huszas = 0;
//	int tizes = 0;
//	int otos = 0;
//	int maradek;

//	ketszazas = osszeg / 200;
//	maradek = osszeg % 200;
//	if (maradek >= 100)
//	{
//		szazas = maradek / 100;
//		maradek = maradek % 100;
//	}

//	if (maradek >= 50)
//	{
//        otvenes = maradek / 50;
//        maradek = maradek % 50;
//    }

//    if (maradek >= 20)
//    {
//        huszas = maradek / 20;
//        maradek = maradek % 20;
//    }

//    if (maradek >= 10)
//    {
//        tizes = maradek / 10;
//        maradek = maradek % 10;
//    }

//    if (maradek >= 5)
//    {
//        otos = maradek / 5;
//    }

//	return $"A megadott összeghez szükséges érmék: kétszázas: {ketszazas} db, százas: {szazas} db, ötvenes: {otvenes} db, húszas: {huszas} db, tízes: {tizes} db, ötös: {otos} db.";
//}

//Console.WriteLine("Átváltandó összeg: ");
//int szam = int.Parse(Console.ReadLine());

//Console.WriteLine(Penzvaltas(szam));

// 4. feladat
//Console.WriteLine("4. feladat");

//string Madar(string szoveg)
//{
//    char[] maganhangzok = new char[] { 'e', 'é', 'i', 'í', 'u', 'ú', 'ü', 'ű', 'o', 'ó', 'ö', 'ő' };

//    string[] szavak = szoveg.Split(' ');
//    string[] madarSzavak = new string[szavak.Length];
//    for (int i = 0; i < szavak.Length; i++)
//    {
//        string madarSzo = string.Empty;
//        for (int j = 0; j < szavak[i].Length; j++)
//        {
//            if (maganhangzok.Contains(szavak[i][j]))
//            {
//                madarSzo += $"{szavak[i][j]}v{szavak[i][j]}";
//            }
//            else
//            {
//                madarSzo += szavak[i][j];
//            }
//        }
//        madarSzavak[i] = madarSzo;
//    }

//    string madarNyelvuSzoveg = string.Join(" ", madarSzavak);

//    return madarNyelvuSzoveg;
//}

//Console.Write("Írjon be egy szöveget: ");
//string szoveg = Console.ReadLine()!;
//Console.WriteLine(Madar(szoveg));

// 5. feladat
//Console.WriteLine("5. feladat");
//Console.Write("Kérem írja be az első számot: ");
//int elsoSzam = int.Parse(Console.ReadLine()!);
//Console.Write("Kérem írja be a második számot: ");
//int masodikSzam = int.Parse(Console.ReadLine()!);

//int KozosOszto(int a, int b)
//{
//    int nagyobbSzam = (a > b ? a : b);
//    int kisebbSzam = (a > b ? b : a);
//    int kozosOszto = 0;
//    int index = kisebbSzam;
//    while (kozosOszto == 0)
//    {
//        if (nagyobbSzam % index == 0 && kisebbSzam % index == 0)
//        {
//            kozosOszto = index;
//        }
//        index--;
//    }

//    return kozosOszto;
//}

//Console.WriteLine($"A két szám közös osztója: {KozosOszto(elsoSzam, masodikSzam)}");

// 6. feladat
//Console.WriteLine("6. feladat");
//Console.Write("Kérem írjon be egy számot: ");
//int szam = int.Parse(Console.ReadLine()!);

//bool Primszam(int szam)
//{
//	bool prim = true;
//	if (szam != 1 && szam != 2 && szam != 3)
//	{
//        for (int i = szam - 1; i >= szam / 2; i--)
//        {
//            if (szam % i == 0)
//            {
//                prim = false;
//            }
//        }
//    }
//	return prim;
//}

//Console.WriteLine($"A megadott szám: {szam} {(Primszam(szam) ? "prímszám!" : "nem prímszám!")}");

// 7. feladat
//Console.WriteLine("7. feladat");
//Console.Write("Írjon be egy szöveget: ");
//string szoveg = Console.ReadLine()!;

//string Fordito(string szoveg)
//{
//    string[] szavak = szoveg.Split(' ');
//    string[] nagyBetusSzavak = new string[szavak.Length];

//    for (int i = 0; i < szavak.Length; i++)
//    {
//        string szo = "";
//        szo += szavak[i][0].ToString().ToUpper();
//        for (int j = 1; j < szavak[i].Length; j++)
//        {
//            szo += szavak[i][j];
//        }
//        nagyBetusSzavak[i] = szo;
//    }

//    string ujSzoveg = string.Join(' ', nagyBetusSzavak);

//    char[] chars = ujSzoveg.ToCharArray();
//    Array.Reverse(nagyBetusSzavak);
//    string forditott = new string(chars);

//    return string.Join(' ', nagyBetusSzavak);
//}

//Console.WriteLine(Fordito(szoveg));

// 8. feladat
//Console.WriteLine("8. feladat");

//double[] EgyenletMegoldasok(int x, int y, int z)
//{
//    double[] megoldasok = new double[2];

//    megoldasok[0] = (-y + Math.Sqrt(Math.Pow(y, 2) - 4 * x * z)) / 2 * x;
//    megoldasok[1] = (-y - Math.Sqrt(Math.Pow(y, 2) - 4 * x * z)) / 2 * x;

//    return megoldasok;
//}

//Console.Write("Írja be x értékét: ");
//int x = int.Parse(Console.ReadLine()!);

//Console.Write("Írja be y értékét: ");
//int y = int.Parse(Console.ReadLine()!);

//Console.Write("Írja be z értékét: ");
//int z = int.Parse(Console.ReadLine()!);

//double[] megoldasok = EgyenletMegoldasok(x, y, z);
//Console.WriteLine($"A megoldások: {megoldasok[0]}, {megoldasok[1]}, {megoldasok[2]}");

// 9. feladat
//Console.WriteLine("9. feladat");
//bool EmailChecker(string email)
//{
//    bool validEmail = true;
//    int index = 0;
//    while (validEmail && index < email.Length)
//    {
//        if (!char.IsDigit(email[index]) && (!char.IsLetter(email[index]) || char.IsSymbol(email[index])) && !(email[index] == '@') && !(email[index] == '.') || !(email.LastIndexOf('.') > email.IndexOf('@')))
//        {
//            validEmail = false;
//        }
//        index++;
//    }
//    return validEmail;
//}

//Console.Write("Kérem írjon be egy email címet az ellenőrzéshez: ");
//string email = Console.ReadLine()!;
//Console.WriteLine($"{(EmailChecker(email) ? "Az email cím valid!" : "Az email cím nem felel meg a követelményeknek!")}");

Console.ReadKey();