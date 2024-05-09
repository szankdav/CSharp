using System.IO.Compression;

string[,] gyumolcsok = new string[30, 2];

StreamReader gyumolcsosReader = new StreamReader("gyumolcsok.txt");
int gyumolcsokIndex = 0;
while (!gyumolcsosReader.EndOfStream)
{

    string[] fajlSor = gyumolcsosReader.ReadLine().Split(";");
    gyumolcsok[gyumolcsokIndex, 0] = fajlSor[0];
    gyumolcsok[gyumolcsokIndex, 1] = fajlSor[1];
    gyumolcsokIndex++;
}
gyumolcsosReader.Close();
Console.WriteLine("2. feladat");
for (int i = 0; i < gyumolcsokIndex; i++)
{
    if (gyumolcsok[i, 0] != null)
    {
        Console.WriteLine($"{gyumolcsok[i, 0]}: {gyumolcsok[i, 1]} kg");
    }
}

Console.WriteLine("3. feladat");
int osszesGyumolcsKg = 0;

for (int i = 0; i < gyumolcsokIndex; i++)
{
    osszesGyumolcsKg += int.Parse(gyumolcsok[i, 1]);
}

Console.WriteLine($"Összesen {osszesGyumolcsKg} kg gyümölcs termett!");

Console.WriteLine("4. feladat");
Console.WriteLine($"Átlagosan {osszesGyumolcsKg / gyumolcsokIndex} kg gyümölcs termett!");

Console.WriteLine("5. feladat");
int pontosanTizKiloTermettDarab = 0;

for (int i = 0; i < gyumolcsokIndex; i++)
{
    if (gyumolcsok[i, 1] == "10")
    {
        pontosanTizKiloTermettDarab++;
    }
}

Console.WriteLine($"{pontosanTizKiloTermettDarab} féle gyümcsölből termett pontosan 10 kg!");

Console.WriteLine("6. feladat");
int legtobb = 0;
int legTobbIndex = 0;
for (int i = 0; i < gyumolcsokIndex; i++)
{
    if (int.Parse(gyumolcsok[i, 1]) > int.Parse(gyumolcsok[legTobbIndex, 1]))
    {
        legtobb = int.Parse(gyumolcsok[i, 1]);
        legTobbIndex = i;
    }
}

bool elsoLegtobb = false;
int gyumolcsIndex = 0;
while (elsoLegtobb != true && gyumolcsIndex < gyumolcsokIndex)
{
    if (int.Parse(gyumolcsok[gyumolcsIndex, 1]) == legtobb)
    {
        elsoLegtobb = true;
    }
    gyumolcsIndex++;
}

Console.WriteLine($"{gyumolcsok[gyumolcsIndex, 0]} gyümölcsből termett a legtöbb az idén: {gyumolcsok[gyumolcsIndex, 1]} kg");

Console.WriteLine("7. feladat");
Console.WriteLine("Legalább 30 kg termést hozó gyümölcsök: ");
for (int i = 0; i < gyumolcsokIndex; i++)
{
    if (int.Parse(gyumolcsok[i, 1]) >= 30)
    {
        Console.WriteLine(gyumolcsok[i, 0]);
    }
}

Console.WriteLine("8. feladat:");
int legkevesebb = 0;
int legkevesebbIndex = 0;
for (int i = 0; i < gyumolcsokIndex; i++)
{
    if (int.Parse(gyumolcsok[i, 1]) > int.Parse(gyumolcsok[legkevesebbIndex, 1]))
    {
        legkevesebb = int.Parse(gyumolcsok[i, 1]);
        legkevesebbIndex = i;
    }
}

bool elsoLegkevesebb = false;
int gyumolcsLegkvesebbIndex = 0;
while (elsoLegkevesebb != true && gyumolcsLegkvesebbIndex < gyumolcsokIndex)
{
    if (int.Parse(gyumolcsok[gyumolcsLegkvesebbIndex, 1]) == legkevesebb)
    {
        elsoLegkevesebb = true;
    }
    gyumolcsLegkvesebbIndex++;
}

Console.WriteLine($"{gyumolcsok[gyumolcsLegkvesebbIndex, 0]} gyümölcsből termett a legkevesebb az idén!");


Console.ReadKey();