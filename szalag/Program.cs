using szalagLibrary;

namespace szalag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RekeszLogic rekeszLogic = new RekeszLogic();

            StreamReader szalagAdatokReader = new StreamReader("szallit.txt");

            string[] elsoSor = szalagAdatokReader.ReadLine().Trim().Split(" ");
            Szalag szalag = new Szalag(int.Parse(elsoSor[0]), int.Parse(elsoSor[1]));

            while (!szalagAdatokReader.EndOfStream)
            {
                string[] adatok = szalagAdatokReader.ReadLine().Trim().Split(" ");
                rekeszLogic.Add(new Rekesz(int.Parse(adatok[0]), int.Parse(adatok[1]), int.Parse(adatok[2]), int.Parse(adatok[3])));
            }

            foreach (Rekesz rekesz in rekeszLogic.rekeszAdatok) 
            {
                Console.WriteLine($"{rekesz.FelhelyezesIdoEgyseg} {rekesz.FelhelyezesHosszusagEgyseg} {rekesz.LekerulesHosszusagEgyseg} {rekesz.Tomeg}");
            }

            Console.WriteLine("2. feladat");
            Console.Write("Adja meg, melyik adatsorra kíváncsi! ");
            int sorszam = int.Parse(Console.ReadLine());
            Console.WriteLine(rekeszLogic.HonnanHova(sorszam));

            Console.WriteLine("3. feladat");
            Console.WriteLine($"A legnagyobb távolság: {rekeszLogic.LegnagyobbTavolsag()}");
            Console.Write($"A maximális távolságú szállítások sorszáma: {String.Join(" ", rekeszLogic.LegnagyobbTavolsagSorszamok())}");

            Console.ReadKey();
        }
    }
}
