using System.Globalization;

List<Barlang> barlangAdatok = new List<Barlang>();

StreamReader barlangReader = new StreamReader("feljegyzesek.txt");
int kedvencBarlangSorszama = int.Parse(barlangReader.ReadLine());
while (!barlangReader.EndOfStream)
{
    string line = barlangReader.ReadLine();
    if (line != null)
    {
        string[] lineDatas = line.Split(';');
        barlangAdatok.Add(new Barlang(lineDatas[0], double.Parse(lineDatas[1], CultureInfo.InvariantCulture), double.Parse(lineDatas[2], CultureInfo.InvariantCulture), lineDatas[3], lineDatas[4]));
    }
}
barlangReader.Close();

Console.WriteLine("A kedvenc barlangok adatai:");
Console.WriteLine($"\tNeve: {barlangAdatok[kedvencBarlangSorszama - 2].barlangNev}");
Console.WriteLine($"\tHossza: {barlangAdatok[kedvencBarlangSorszama - 2].barlangHossz}");
Console.WriteLine($"\tMélysége: {barlangAdatok[kedvencBarlangSorszama - 2].barlangMelyseg}");
Console.WriteLine($"\tLokáció: {barlangAdatok[kedvencBarlangSorszama - 2].telepulesNev}");
Console.WriteLine($"\tMár meglátogatta: {(barlangAdatok[kedvencBarlangSorszama - 1].meglatogatott == "i" ? "Igen" : "Nem")}");
Console.WriteLine();

double barlangokTeljesHossza = barlangAdatok.Sum(x => x.barlangHossz);


Console.WriteLine($"A barlangok teljes hossza km-ben: {Math.Round(barlangokTeljesHossza / 1000, 2)}");
Console.WriteLine();

Barlang legmelyebbBarlangIndexe = barlangAdatok.Find(y => y.barlangMelyseg == barlangAdatok.Max(x => x.barlangMelyseg));

Console.WriteLine("A legmélyebb barlang adatai:");
Console.WriteLine($"\tNeve: {legmelyebbBarlangIndexe.barlangNev}");
Console.WriteLine($"\tHossza: {legmelyebbBarlangIndexe.barlangHossz}");
Console.WriteLine($"\tMélysége: {legmelyebbBarlangIndexe.barlangMelyseg}");
Console.WriteLine($"\tLokáció: {legmelyebbBarlangIndexe.telepulesNev}");
Console.WriteLine($"\tMár meglátogatta: {(legmelyebbBarlangIndexe.meglatogatott == "i" ? "Igen" : "Nem")}");
Console.WriteLine();

bool regiesNev(Barlang barlang)
{
    if (barlang.barlangNev.Contains("lyuk") || barlang.barlangNev.Contains("zsomboly") || barlang.barlangNev.Contains("lik"))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int szamlalo = 0;
szamlalo += barlangAdatok.Count(x => regiesNev(x));

if (szamlalo > 0)
{
    Console.WriteLine($"Régies nevű barlangok száma: {szamlalo} db");
}
else
{
    Console.WriteLine("Nincs régies barlangnév!");
}

Console.WriteLine("\tRégies nevű barlangok:");
Console.WriteLine();
foreach (Barlang barlang in barlangAdatok)
{
    if (regiesNev(barlang))
    {
        Console.WriteLine($"\t{barlang.barlangNev}");
    }
}

Console.Write("Kérem írjon be egy településnevet: ");
string bekertTelepulesnev = Console.ReadLine();

double telepulesBarlangjainakHossza = barlangAdatok.FindAll(x => x.telepulesNev == bekertTelepulesnev).Average(y => y.barlangHossz);

if (telepulesBarlangjainakHossza > 0)
{
    Console.WriteLine($"{bekertTelepulesnev} településen található barlangok átlagos hossza: {Math.Round(telepulesBarlangjainakHossza)} m");
}
Console.WriteLine();

StreamWriter telepulesWriter = new StreamWriter("telepulesek.txt");

//var b = from barlang in barlangAdatok group barlang by barlang.telepulesNev into barlangok select (barlangok.Key, barlangok.Count());

//foreach (var c in b)
//{
//    Console.WriteLine($"{c.Key}, {c.Item2}");
//}

Console.WriteLine();
Console.WriteLine();
List<string> result = barlangAdatok.GroupBy(x => x.telepulesNev).Select(z => $"{z.Key}: {z.Count()}").ToList();
result.Sort();
foreach (var c in result)
{
    Console.WriteLine(c);
    telepulesWriter.WriteLine(c);
}
telepulesWriter.Close();

Console.WriteLine("A leghosszabb barlang, ahol még nem járt Benő:");
Console.WriteLine($"{barlangAdatok.FindAll(x => x.meglatogatott == "n").MaxBy(y => y.barlangHossz).barlangNev}");

Console.ReadKey();

record Barlang(string barlangNev, double barlangHossz, double barlangMelyseg, string telepulesNev, string meglatogatott);
