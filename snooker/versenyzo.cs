using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snooker
{
    internal class Versenyzo
    {
        private int helyezes;
        private string nev;
        private string orszag;
        private int nyeremeny;

        public int Helyezes { get => helyezes; set => helyezes = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int Nyeremeny { get => nyeremeny; set => nyeremeny = value; }

        public Versenyzo(int helyezes, string nev, string orszag, int nyeremeny)
        {
            Helyezes = helyezes;
            Nev = nev;
            Orszag = orszag;
            Nyeremeny = nyeremeny;
        }
    }
}
