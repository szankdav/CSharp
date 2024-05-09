namespace dartsEredmeny
{
    public class Eredmeny
    {
        int elsoDobas;
        int masodikDobas;
        int harmadikDobas;
        List<string> dobasok = new List<string>();
        int jatekosSzam;

        public int ElsoDobas { get => elsoDobas; set => elsoDobas = value; }
        public int MasodikDobas { get => masodikDobas; set => masodikDobas = value; }
        public int HarmadikDobas { get => harmadikDobas; set => harmadikDobas = value; }
        public List<string> Dobasok { get => dobasok; set => dobasok = value; }
        public int JatekosSzam { get => jatekosSzam; set => jatekosSzam = value; }

        public Eredmeny(int elsoDobas, int masodikDobas, int harmadikDobas, List<string> dobasok, int jatekosSzam)
        {
            ElsoDobas = elsoDobas;
            MasodikDobas = masodikDobas;
            HarmadikDobas = harmadikDobas;
            Dobasok = dobasok;
            JatekosSzam = jatekosSzam;
        }
    }
}