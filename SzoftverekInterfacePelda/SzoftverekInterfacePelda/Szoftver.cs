using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzoftverekInterfacePelda
{
    enum Szoftvertipus
    {
        DesktopApp,
        MobileApp,
        OS
    }
    internal class Szoftver : IComparable, ICloneable
    {
        #region PRIVATE FIELDS
        string gyarto;
        string megnevezes;
        int ar;
        Szoftvertipus tipus;
        #endregion

        #region PUBLIC PROPERTIES
        public string Gyarto
        {
            get => gyarto;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 20) { gyarto = value; }
                else { throw new ArgumentException("A gyarto nem megfelelo!"); }
            }
        }
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 20) { megnevezes = value; }
                else { throw new ArgumentException("A megnevezes nem megfelelo!"); }
            }
        }
        public int Ar
        {
            get => ar;
            set
            {
                if (value > 0) { ar = value; }
                else { throw new ArgumentException("Az ar nem megfelelo!"); }
            }
        }
        internal Szoftvertipus Tipus
        {
            get => tipus;
            set
            {
                if (Enum.IsDefined(typeof(Szoftvertipus), value)) { tipus = value; }
                else { throw new ArgumentException("A szoftvertipus nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Szoftver(string gyarto, string megnevezes, int ar, Szoftvertipus tipus)
        {
            Gyarto = gyarto;
            Megnevezes = megnevezes;
            Ar = ar;
            Tipus = tipus;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"{Gyarto} - {Megnevezes} - {Ar} - {Tipus}";
        }
        public int CompareTo(object obj)
        {
            //throw new NotImplementedException();
            // A cél, hogy ABC sorrend szerint lehessen az objektumokat kezelni
            /*
             Itt a this objektumot hasonlítom össze az obj objektummal
             Ha a this sorrend szerint előrébb van a sorban a megállapításunk szerint mint az obj --> -1
             Ha a this sorrend szerint hátrébb van a sorban a megállapításunk szerint mint az obj --> 1
             Ha a this sorrend szerint ugyan ott van a sorban a megállapításunk szerint mint az obj --> 0
             */

            if (obj is Szoftver masik)
            {
                //if (this.gyarto[0] < masik.gyarto[0])
                //{
                //    return -1;
                //}
                //else if(this.gyarto[0] > masik.gyarto[0])
                //{
                //    return 1;
                //}
                //else
                //{
                //    return 0;
                //}
                return (this.gyarto + this.megnevezes).CompareTo(masik.gyarto + masik.megnevezes);
            }
            else
            {
                throw new ArgumentException("A bejovo obj nem Szoftver tipusu!");
            }
        }

        public object Clone()
        {
            //throw new NotImplementedException();
            // Alapvetően egy sekély (shallow) klónt előidéző alprogram, de természetesen implmenetáció függő, hogy hogyan írjuk meg.
            // Azért kell az osztályban lennie a klón előállító alprogramnak, mert a private tagokat csak itt látom és egy klón azokat az adatokat is viszi magával ami kívülről nem látható.
            return new Szoftver(gyarto, megnevezes, ar, tipus);

        }
        #endregion
    }
}
