using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetegsegManager
{
    enum BetegsegTipus
    {
        Virusos,
        Bakterialis
    }

    enum BetegsegLefolyas
    {
        Enyhe,
        Heveny,
        Veszelyes
    }
    internal class Betegseg
    {
        #region PRIVATE FIELDS
        string megnevezes;
        BetegsegTipus tipus;
        BetegsegLefolyas lefolyas;
        #endregion

        #region PUBLIC PROPERTIES
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (value.Trim().Length >= 5)
                {
                    megnevezes = value;
                }
                else
                {
                    throw new ArgumentException("A megnevezes minimum 5 karakter kell, hogy legyen!");
                }
            }
        }
        internal BetegsegTipus Tipus
        {
            get => tipus;
            set
            {
                if (Enum.IsDefined(typeof(BetegsegTipus), value))
                {
                    tipus = value;
                }
                else
                {
                    throw new ArgumentException("A betegseg tipusa nem megfelelo");
                }
            }
        }
        internal BetegsegLefolyas Lefolyas
        {
            get => lefolyas;
            set
            {
                if (Enum.IsDefined(typeof(BetegsegLefolyas), value))
                {
                    lefolyas = value;
                }
                else
                {
                    throw new ArgumentException("A betegség lefolyása nem megfelelő!");
                }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Betegseg(string megnevezes, BetegsegTipus tipus, BetegsegLefolyas lefolyas)
        {
            Megnevezes = megnevezes;
            Tipus = tipus;
            Lefolyas = lefolyas;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"Megnevezes: {this.megnevezes} - Betegseg tipusa: {this.tipus} - Betegseg lefolyasa: {this.lefolyas}";
        }
        #endregion
    }
}
