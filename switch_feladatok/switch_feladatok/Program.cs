// 1. feladat
//Console.WriteLine("1. feladat");
//Console.WriteLine("Kérem írjon be egy érdemjegyet: ");
//int erdemjegy = int.Parse(Console.ReadLine()!);
//Console.WriteLine();
//switch (erdemjegy)
//{
//	case 1:
//		Console.WriteLine("A megadott érdemjegy: elégtelen");
//		break;
//    case 2:
//        Console.WriteLine("A megadott érdemjegy: elégséges");
//        break;
//    case 3:
//        Console.WriteLine("A megadott érdemjegy: közepes");
//        break;
//    case 4:
//        Console.WriteLine("A megadott érdemjegy: jó");
//        break;
//    case 5:
//        Console.WriteLine("A megadott érdemjegy: jeles");
//        break;
//    default:
//		Console.WriteLine("A megadott szám nem érdemjegy!");
//		break;
//}

// 2. feladat
//Console.WriteLine("2. feladat");
//Console.WriteLine("Kérem írja be egy hónap nevét: ");
//string honapNev = Console.ReadLine()!;
//Console.WriteLine();
//switch (honapNev.Trim().ToLower())
//{
//	case "január":
//	case "február":
//	case "március":
//		Console.WriteLine("A beírt hónap az első negyedévben van!");
//		break;
//	case "április":
//	case "május":
//	case "június":
//        Console.WriteLine("A beírt hónap a második negyedévben van!");
//		break;
//    case "július":
//    case "augusztus":
//    case "szeptember":
//        Console.WriteLine("A beírt hónap a harmadik negyedévben van!");
//        break;
//    case "október":
//    case "november":
//    case "december":
//        Console.WriteLine("A beírt hónap a negyedik negyedévben van!");
//        break;
//}

// 3. feladat
//Console.WriteLine("3. feladat");
//Console.WriteLine("Kérem írja be egy hónap sorszámát: ");
//int honapSorszam = int.Parse(Console.ReadLine()!);
//Console.WriteLine();
//switch (honapSorszam)
//{
//	case 1:
//	case 2:
//	case 12:
//		Console.WriteLine("A megadott sorszámú hónap egy téli hónap!");
//		break;
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("A megadott sorszámú hónap egy tavaszi hónap!");
//        break;
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("A megadott sorszámú hónap egy nyári hónap!");
//        break;
//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("A megadott sorszámú hónap egy őszi hónap!");
//        break;
//}

// 4. feladat
//Console.WriteLine("4. feladat");
//Console.WriteLine("Kérem írja be hogy hány órát alszik naponta: ");
//int alvasiOrakSzama = int.Parse(Console.ReadLine()!);
//Console.WriteLine();
//switch (alvasiOrakSzama)
//{
//    case <= 6:
//        Console.WriteLine("Kevés!");
//        break;
//    case 7:
//    case 8:
//    case 9:
//        Console.WriteLine("Átlagos!");
//        break;
//    case 10:
//    case 11:
//    case 12:
//        Console.WriteLine("Sok!");
//        break;
//    case > 13:
//        Console.WriteLine("Sok!");
//        break;
//}

// 5. feladat
//Console.WriteLine("5. feladat");
//Console.WriteLine("Írja be egy szemptemberi nap sorszámát: ");
//int napSzama = int.Parse(Console.ReadLine()!);
//Console.WriteLine();
//switch (napSzama)
//{
//	case 2:
//    case 9:
//    case 16:
//    case 23:
//    case 30:
//        Console.WriteLine("A megadott sorszámú nap hétfőre esik!");
//        Console.WriteLine("A megadott sorszámú napon webfejlesztés órám lesz!");
//        break;
//    case 3:
//    case 10:
//    case 17:
//    case 24:
//        Console.WriteLine("A megadott sorszámú nap keddre esik!");
//        Console.WriteLine("A megadott sorszámú napon adatbázis órám lesz!");
//        break;
//    case 4:
//    case 11:
//    case 18:
//    case 25:
//        Console.WriteLine("A megadott sorszámú nap szerdára esik!");
//        Console.WriteLine("A megadott sorszámú napon angol órám lesz!");
//        break;
//    case 5:
//    case 12:
//    case 19:
//    case 26:
//        Console.WriteLine("A megadott sorszámú nap csütörtökre esik!");
//        Console.WriteLine("A megadott sorszámú napon C# órám lesz!");
//        break;
//    case 6:
//    case 13:
//    case 20:
//    case 27:
//        Console.WriteLine("A megadott sorszámú nap péntekre esik!");
//        Console.WriteLine("A megadott sorszámú napon nincsen órám!");
//        break;
//    case > 30:
//        Console.WriteLine("A hónap csak 30 napos!");
//        break;
//    default:
//        Console.WriteLine("A megadott számú nap hétvégére esik!");
//        break;
//}

// 6. feladat
//Console.WriteLine("6. feladat");
//Console.WriteLine("Írja be az osztály betűjelét: ");
//char osztalyBetu = Console.ReadKey().KeyChar;
//Console.WriteLine();
//switch (osztalyBetu.ToString().Trim().ToLower())
//{
//	case "a":
//        Console.WriteLine("Osztályfőnök: Kis Gizi");
//        Console.WriteLine("Osztályterem: G9");
//        break;
//    case "b":
//        Console.WriteLine("Osztályfőnök: Nagy Béla");
//        Console.WriteLine("Osztályterem: G15");
//        break;
//    case "c":
//        Console.WriteLine("Osztályfőnök: Pici Mici");
//        Console.WriteLine("Osztályterem: G21");
//        break;
//    default:
//        Console.WriteLine("Nincs ilyen osztály!");
//		break;
//}

// 7. feladat
//Console.WriteLine("7. feladat");
//Console.WriteLine("Írja be az első számot: ");
//int elsoSzam = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Írja be a második számot: ");
//int masodikSzam = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Írjon be egy műveleti jelet: ");
//string muveletiJel =  Console.ReadLine()!;
//Console.WriteLine();
//switch (muveletiJel)
//{
//    case "+":
//        Console.WriteLine($"{elsoSzam} + {masodikSzam} = {elsoSzam + masodikSzam}");
//        break;
//    case "-":
//        Console.WriteLine($"{elsoSzam} - {masodikSzam} = {elsoSzam - masodikSzam}");
//        break;
//    case "*":
//        Console.WriteLine($"{elsoSzam} * {masodikSzam} = {elsoSzam * masodikSzam}");
//        break;
//    case "/":
//        Console.WriteLine($"{elsoSzam} / {masodikSzam} = {elsoSzam / masodikSzam}");
//        break;
//    default:
//        Console.WriteLine("A megadott műveleti jel értelmezhetetlen!");
//		break;
//}

// 8. feladat
//Console.WriteLine("8. feladat");
//Console.WriteLine("Írjon be egy összeget: ");
//string osszeg = Console.ReadLine()!;
//Console.WriteLine();
//switch (osszeg.Substring(osszeg.Length - 1, 1))
//{
//	case "1":
//	case "2":
//        Console.WriteLine($"A megadott összeg kerekítve: {osszeg.Remove(osszeg.Length - 1, 1)}0");
//		break;
//    case "3":
//    case "4":
//        Console.WriteLine($"A megadott összeg kerekítve: {osszeg.Remove(osszeg.Length - 1, 1)}5");
//        break;
//    case "6":
//    case "7":
//        Console.WriteLine($"A megadott összeg kerekítve: {osszeg.Remove(osszeg.Length - 1, 1)}5");
//        break;
//    case "8":
//        Console.WriteLine($"A megadott összeg kerekítve: {int.Parse(osszeg) + 2}");
//        break;
//    case "9":
//        Console.WriteLine($"A megadott összeg kerekítve: {int.Parse(osszeg) + 1}"); 
//        break;
//    default:
//        Console.WriteLine("A megadott összeget nem kell kerekíteni.");
//        break;
//}

// 9. feladat
//Console.WriteLine("9. feladat");
//Console.WriteLine("Írjon be egy évszámot: ");
//int evszam = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Írja be egy hónap nevét: ");
//string honapNeve = Console.ReadLine()!;
//Console.WriteLine();
//switch (honapNeve.Trim().ToLower())
//{
//	case "január":
//	case "március":
//	case "május":
//	case "július":
//	case "augusztus":
//	case "október":
//	case "december":
//        Console.WriteLine("A megadott hónap 31 napos!");
//        break;
//    case "április":
//    case "június":
//    case "szeptember":
//    case "november":
//        Console.WriteLine("A megadott hónap 30 napos!");
//        break;
//    case "február":
//        if ((evszam % 4 == 0 && evszam % 100 != 0) || (evszam % 4 == 0 && evszam % 400 == 0))
//        {
//            Console.WriteLine("A megadott hónap 29 napos!");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("A megadott hónap 28 napos!");
//            break;
//        }
//    default:
//		break;
//}

// 10. feladat
//Console.WriteLine("10. feladat");
//Console.WriteLine("Kérem írja be a vásárlás összegét: ");
//int vasarlasOsszege = int.Parse(Console.ReadLine()!);

//string[] zsakbamacska = new string[] { "pohárkrém", "kandírozott gyümölcs", "marcipán figura" };
//string[] poharkremIzek = new string[] { "csokoládé", "vanília", "mogyoró", "puncs" };

//Random random = new Random();
//if (vasarlasOsszege > 3000 && vasarlasOsszege <= 6000)
//{
//    Console.WriteLine($"Gratulálunk, Ön promóciós játékunk keretében ajándékba kap egy kis zacskó gumicukrot, és {vasarlasOsszege / 500} darab nyereményszelvényt!");
//}
//else if (vasarlasOsszege > 6000 && vasarlasOsszege <= 10000)
//{
//    Console.WriteLine($"Gratulálunk, Ön promóciós játékunk keretében ajándékba kap egy tábla csokit, és {vasarlasOsszege / 500} darab nyereményszelvényt!");
//}
//else if(vasarlasOsszege > 10000)
//{
//    string randomZsakbamacska = zsakbamacska[random.Next(0, zsakbamacska.Length)];
//    if (randomZsakbamacska == zsakbamacska[0])
//    {
//        string randomPoharkremIz = poharkremIzek[random.Next(0, poharkremIzek.Length)];
//        Console.WriteLine($"Gratulálunk, Ön promóciós játékunk keretében ajándékba kap egy pohárkrémet {randomPoharkremIz} ízben, és {vasarlasOsszege / 500} darab nyereményszelvényt!");
//    }
//    else
//    {
//        Console.WriteLine($"Gratulálunk, Ön promóciós játékunk keretében ajándékba kap egy {(randomZsakbamacska == zsakbamacska[1] ? randomZsakbamacska + "öt" : randomZsakbamacska.Replace("figura", "figurát"))}, és {vasarlasOsszege / 500} darab nyereményszelvényt!");
//    }
//}
//else
//{
//    Console.WriteLine($"Gratulálunk, Ön promóciós játékunk keretében kap {vasarlasOsszege / 500} darab nyereményszelvényt!");
//}

// 11. feladat
//Console.WriteLine("11. feladat");
//Console.WriteLine("Kérem írja be az időt (hh:mm) formátumban: ");
//string pontosIdo = Console.ReadLine()!;
//int ora; 
//if (pontosIdo.Substring(0, 1) == "0")
//{
//    ora = int.Parse(pontosIdo.Substring(1, 1));
//}
//else
//{
//    ora = int.Parse(pontosIdo.Substring(0, 2));
//}

//if (ora >= 6 && ora <= 20)
//{
//    Console.WriteLine("Elegendő fény szűrödik be az ablakokon?");
//    string valasz = Console.ReadLine()!;
//    if (valasz.Trim().ToLower() == "igen")
//    {
//        Console.WriteLine("A nappali fény nem világít!");
//    }
//    else
//    {
//        Console.WriteLine("A nappali fény világít!");
//    }
//}
//else
//{
//    Console.WriteLine("Az éjszakai fény világít!");
//}

// 12. feladat
//Console.WriteLine("12. feladat");
//Random random = new Random();
//string randomBelepesiKod = string.Empty;
//for (int i = 0; i < 4; i++)
//{
//    randomBelepesiKod += random.Next(1, 10);
//}

//if (int.Parse(randomBelepesiKod.Substring(0, 1)) > 4)
//{
//    Console.WriteLine("A kóddal az 1-es helyiségbe lehet belépni!");
//}
//else if (int.Parse(randomBelepesiKod.Substring(1, 1)) > 4)
//{
//    Console.WriteLine("A kóddal az 2-es helyiségbe lehet belépni!");
//}
//else if (int.Parse(randomBelepesiKod.Substring(2, 1)) > 4)
//{
//    Console.WriteLine("A kóddal az 3-as helyiségbe lehet belépni!");
//}
//else if (int.Parse(randomBelepesiKod.Substring(3, 1)) > 4)
//{
//    Console.WriteLine("A kóddal az 4-es helyiségbe lehet belépni!");
//}
//else if ((int.Parse(randomBelepesiKod.Substring(0, 1))) % 2 == 0 && (int.Parse(randomBelepesiKod.Substring(2, 1))) % 2 == 0)
//{
//    Console.WriteLine("A kóddal az 5-ös helyiségbe lehet belépni!");
//}
//else if ((int.Parse(randomBelepesiKod.Substring(1, 1))) % 2 == 0 && (int.Parse(randomBelepesiKod.Substring(3, 1))) % 2 == 0)
//{
//    Console.WriteLine("A kóddal az 6-os helyiségbe lehet belépni!");
//}
//else if ((int.Parse(randomBelepesiKod.Substring(0, 1))) % 2 == 0 && (int.Parse(randomBelepesiKod.Substring(1, 1))) % 2 == 0 && (int.Parse(randomBelepesiKod.Substring(2, 1))) % 2 == 0 && (int.Parse(randomBelepesiKod.Substring(3, 1))) % 2 == 0 && (randomBelepesiKod[0] != randomBelepesiKod[1] || randomBelepesiKod[0] != randomBelepesiKod[2] || randomBelepesiKod[0] != randomBelepesiKod[3] || randomBelepesiKod[1] != randomBelepesiKod[2] || randomBelepesiKod[1] != randomBelepesiKod[3]) || randomBelepesiKod[2] != randomBelepesiKod[3])
//{
//    Console.WriteLine("A kóddal az 7-es helyiségbe lehet belépni!");
//}
//else
//{
//    Console.WriteLine("A kóddal egyik helyiségbe sem lehet belépni, a kártya érvénytelen!");
//}

//Console.ReadKey();