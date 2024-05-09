using dartsEredmeny;

namespace dartsLogic
{
    public class Logic
    {
        readonly List<Eredmeny> eredmenyek = new List<Eredmeny>();

        public void Beolvasas(string fajlNev)
        {
            StreamReader reader = new StreamReader(fajlNev);
            while (!reader.EndOfStream)
            {
                string[] adatok = reader.ReadLine().Split(';');
                eredmenyek.Add(new Eredmeny(
                    adatok[1].Contains('T') ? int.Parse(adatok[1].Substring(1)) * 3 : 
                    adatok[1].Contains('D') ? int.Parse(adatok[1].Substring(1)) * 2 :
                    int.Parse(adatok[1]), 
                    adatok[2].Contains('T') ? int.Parse(adatok[2].Substring(1)) * 3 :
                    adatok[2].Contains('D') ? int.Parse(adatok[2].Substring(1)) * 2 :
                    int.Parse(adatok[2]), 
                    adatok[3].Contains('T') ? int.Parse(adatok[3].Substring(1)) * 3 :
                    adatok[3].Contains('D') ? int.Parse(adatok[3].Substring(1)) * 2 :
                    adatok[3].Contains('B') ? 0 : int.Parse(adatok[3]),
                    adatok[1..].ToList(),
                    int.Parse(adatok[0])
                    ));
            }
        }

        public int KorSzamlalo()
        {
            return eredmenyek.Count;
        }

        public int HarmadikDobasraBullsEye()
        {
            return eredmenyek.Count(x => x.HarmadikDobas == 50);
        }

        public (int, int) JatekosokSzektorJatszma(string szektor)
        {
            int elsoJatekosSzektorJatszmaSzam = eredmenyek.Where(x => x.JatekosSzam == 1).Count(x => x.Dobasok.Contains(szektor));

            int masodikJatekosSzektorJatszmaSzam = eredmenyek.Where(x => x.JatekosSzam == 2).Count(x => x.Dobasok.Contains(szektor));

            return (elsoJatekosSzektorJatszmaSzam, masodikJatekosSzektorJatszmaSzam);
        }

        //public int ElsoJatekosSzektorJatszmaSzam(string szektor)
        //{
        //    return eredmenyek.Where(x => x.JatekosSzam == 1).Count(x => x.Dobasok.Contains(szektor));
        //}

        //public int MasodikJatekosSzektorJatszmaSzam(string szektor)
        //{
        //    return eredmenyek.Where(x => x.JatekosSzam == 2).Count(x => x.Dobasok.Contains(szektor));
        //}

        public int ElsoJatekosLegmagasabbPontszamSzama()
        {
            return eredmenyek.Where(x => x.JatekosSzam == 1).Count(y => y.Dobasok.All(z => z == "T20"));
        }

        public int MasodikJatekosLegmagasabbPontszamSzama()
        {
            return eredmenyek.Where(x => x.JatekosSzam == 2).Count(y => y.Dobasok.All(z => z == "T20"));
        }

    }
}