using dartsLogic;

namespace statisztika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            logic.Beolvasas("dobasok.txt");
            
            Console.WriteLine("2. feladat");
            Console.WriteLine($"Körök száma: {logic.KorSzamlalo()}");

            Console.WriteLine("3. feladat");
            Console.WriteLine($"3. dobásra Bullseye: {logic.HarmadikDobasraBullsEye()}");

            Console.WriteLine("4. feladat");
            Console.Write("Adja meg a szektor értékét! Szektor= ");
            string szektor = Console.ReadLine();
            var jatekosokSzektorJatszmaSzama = logic.JatekosokSzektorJatszma(szektor);
            Console.WriteLine($"Az 1. játékos a(z) {szektor} szektoros dobásainak száma: {jatekosokSzektorJatszmaSzama.Item1}");
            Console.WriteLine($"A 2. játékos a(z) {szektor} szektoros dobásainak száma: {jatekosokSzektorJatszmaSzama.Item2}");

            Console.WriteLine("5. feladat");
            Console.WriteLine($"Az 1. játékos {logic.ElsoJatekosLegmagasabbPontszamSzama()} db 180-ast dobott.");
            Console.WriteLine($"A 2. játékos {logic.MasodikJatekosLegmagasabbPontszamSzama()} db 180-ast dobott.");

            Console.ReadKey();
        }
    }
}