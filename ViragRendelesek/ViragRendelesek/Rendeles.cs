using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ViragRendelesek
{
    internal class Rendeles
    {
        #region PRIVATE FIELDS
        string megnevezes;
        Virag[] viragok;
        #endregion

        #region PUBLIC PROPERTIES
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    megnevezes = value;
                }
                else
                {
                    throw new ArgumentException("A rendeles megnevezese nem lehet ures!");
                }
            }
        }
        internal Virag[] Viragok
        {
            //get
            //{
            //    Virag[] masolat = new Virag[viragok.Length];
            //    for (int i = 0; i < viragok.Length; i++)
            //    {
            //        masolat[i] = viragok[i];
            //    }
            //    //return viragok;
            //    return masolat;
            //}
            get { return (Virag[])viragok.Clone(); }
            //set => viragok = value; 
        }
        #endregion

        #region CONSTRUCTORS
        public Rendeles(string megnevezes, Virag[] viragok)
        {
            Megnevezes = megnevezes;
            if (viragok.Length <= 10)
            {
                this.viragok = viragok;
            }
            else
            {
                this.viragok = new Virag[0];
            }
        }
        #endregion

        #region METHODS
        public uint RendelesAra()
        {
            uint sum = 0;
            for (int i = 0; i < this.viragok.Length; i++)
            {
                //sum += this.viragok[i].Ar * this.viragok[i].DarabSzam;
                sum += viragok[i].ViragokAra();
            }
            return sum;
        }

        public static uint OsszesRendelesAra(Rendeles[] rendelesek)
        {
            uint sum = 0;
            foreach (Rendeles item in rendelesek)
            {
                sum += item.RendelesAra();
            }
            //for (int i = 0; i < rendelesek.Length; i++)
            //{
            //    sum += rendelesek[i].viragok[i].ViragokAra();
            //}
            return sum;
        }
        #endregion

        public override string ToString()
        {
            //return base.ToString();
            return $"Megnevezes: {megnevezes} - Rendeles osszerteke: {this.RendelesAra()}";
        }
    }
}
