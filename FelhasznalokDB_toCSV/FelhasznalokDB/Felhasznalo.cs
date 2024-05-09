using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelhasznalokDB
{
    internal class Felhasznalo
    {
        #region PRIVATE FIELDS
        int uid;
        string felhasznalonev;
        string jelszo;
        DateTime regisztraciosIdo;
        #endregion

        #region PUBLIC PROPERTIES
        public int Uid
        {
            get => uid;
            set
            {
                if (uid == -1) { uid = value; }
                else { throw new ArgumentException("A UID modositasa nem lehetseges, mert mar van erteke!"); }
            }
        }
        public string Felhasznalonev
        {
            get => felhasznalonev;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length <= 150) { felhasznalonev = value; }
                else { throw new ArgumentException("A felhasznalonev nem megfelelo!"); }
            }
        }
        public string Jelszo
        {
            get => jelszo;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length <= 20) { jelszo = value; }
                else { throw new ArgumentException("A jelszo nem megfelelo!"); }
            }
        }
        public DateTime RegisztraciosIdo
        {
            get => regisztraciosIdo;
            set => regisztraciosIdo = value;
        }
        #endregion

        #region CONSTRUCTORS
        public Felhasznalo(string felhasznalonev, string jelszo, DateTime regisztraciosIdo, int uid = -1)
        {
            if (uid != -1)
            {
                this.uid = uid;
            }
            Felhasznalonev = felhasznalonev;
            Jelszo = jelszo;
            RegisztraciosIdo = regisztraciosIdo;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"Uid: {Uid}, felhasznalonev: {Felhasznalonev}, jelszo: {Jelszo}, regisztracios ido: {RegisztraciosIdo}";
        }

        public string felhasznaloToCSV()
        {
            return $"{this.uid};{this.Felhasznalonev};{this.Jelszo};{this.RegisztraciosIdo}";
        }
        #endregion

    }
}
