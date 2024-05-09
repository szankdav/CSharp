using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JárműJavítóMűhelyKezelő.Classes
{
    internal class Muhely
    {
        #region PRIVATE FIELDS
        int muhelyId;
        MuhelyCim muhelyCim;
        byte javithatoJarmuvekSzama;
        bool vasarnapNyitva;
        List<Jarmu> muhelyJarmuvei;
        #endregion

        #region PUBLIC PROPERTIES
        public int MuhelyId
        {
            get => muhelyId;
            private set
            {
                if (muhelyId == -1) { muhelyId = value; }
                else { throw new ArgumentException("\"A \\\"muhelyId\\\" módosítása nem lehetséges, mert már van értéke!\");"); }
            }
        }
        public byte JavithatoJarmuvekSzama
        {
            get => javithatoJarmuvekSzama;
            set
            {
                if (value > 9 && value < 26) { javithatoJarmuvekSzama = value; }
                else { throw new ArgumentException("A muhelyben egyszerre javithato jarmuvek szama nem lehet kisebb 10-nel, es nem lehet nagyobb 25-nel!"); }
            }
        }
        public bool VasarnapNyitva
        {
            get => vasarnapNyitva;
            set => vasarnapNyitva = value;
        }
        internal MuhelyCim MuhelyCim { get => muhelyCim; private set => muhelyCim = value; }
        internal List<Jarmu> MuhelyJarmuvei
        {
            get
            {
                List<Jarmu> muhelyJarmuveiMasolat = new List<Jarmu>();
                foreach (Jarmu jarmu in muhelyJarmuvei)
                {
                    muhelyJarmuveiMasolat.Add(jarmu);
                }
                return muhelyJarmuveiMasolat;
            }

            private set => muhelyJarmuvei = value;
        }
        #endregion

        #region CONSTRUCTORS
        public Muhely(byte javithatoJarmuvekSzama, bool vasarnapNyitva, MuhelyCim muhelyCim, int muhelyId = -1)
        {
            if (muhelyId != -1)
            {
                MuhelyId = muhelyId;
            }
            JavithatoJarmuvekSzama = javithatoJarmuvekSzama;
            VasarnapNyitva = vasarnapNyitva;
            MuhelyCim = muhelyCim;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"Muhelyazonosito: {MuhelyId}, Cim: {MuhelyCim}, Javithato jarmuvek szama: {JavithatoJarmuvekSzama}, Vasarnap nyitva: {(VasarnapNyitva ? "Igen" : "Nem")}";
        }

        public void UjJarmu(Jarmu jarmu)
        {
            muhelyJarmuvei.Add(jarmu);
        }

        public int JavitasiKoltseg()
        {
            int osszesJavitasKoltsege = 0;
            foreach (Jarmu jarmu in muhelyJarmuvei)
            {
                osszesJavitasKoltsege += jarmu.JavitasAra;
            }
            return osszesJavitasKoltsege;
        }
        #endregion

    }
}
