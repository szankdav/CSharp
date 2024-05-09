using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_osztaly
{
    internal class Auto
    {
        public List<int> sebessegek = new List<int>();

        private string tipus;
        private string vezeto;
        private int maxsebesseg;
        private double atlagSebesseg = 0;

        public string Tipus { get => tipus; init => tipus = value; }
        public string Vezeto { get => vezeto; set => vezeto = value; }
        public int Maxsebesseg
        {
            get => maxsebesseg;
            init { if (value > 100) { maxsebesseg = value; } else { maxsebesseg = 100; } }
        }
        public double AtlagSebesseg { get => atlagSebesseg; }

        public Auto() 
        {
            Tipus = "Ismeretlen";
            Vezeto = string.Empty;
            Maxsebesseg = 100;
        }

        public Auto(string tipus, string vezeto, int maxsebesseg)
        {
            Tipus = tipus;
            Vezeto = vezeto;
            Maxsebesseg = maxsebesseg;
        }

        public int SebessegMeres()
        {
            Random random = new Random();
            if (Vezeto == string.Empty)
            {
                return 0;
            }
            else
            {
                int veletlenSebesseg = random.Next(Maxsebesseg / 4, Maxsebesseg + 1);
                sebessegek.Add(veletlenSebesseg);
                return veletlenSebesseg;
            }
        }

        public string Log()
        {
            return $"Az autó sofőrje: {Vezeto}, az autó átlagsebessége: {AtlagSebesseg}";
        }

        public int Osszehasonlitas(Auto auto)
        {
            if (this.atlagSebesseg > auto.atlagSebesseg)
            {
                return 1;
            }
            else if (this.atlagSebesseg < auto.atlagSebesseg)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
