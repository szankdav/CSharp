using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorKeszletManager
{
    abstract class Butor
    {
		#region PRIVATE 
		string gyartoNeve;
        string azonosito;
        int magassag;
		int hosszusag;
		int szelesseg;
        #endregion

        #region PUBLIC PROPERTIES
        public string GyartoNeve
        {
            get => gyartoNeve;
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                {
                    gyartoNeve = value;
                }
                else
                {
                    throw new ArgumentException("A gyarto neve nem lehet ures!");
                }
            }
        }
        public string Azonosito
        {
            get => azonosito;
            set
            {
                if (!(string.IsNullOrEmpty(value)) && value.Trim().Length == 8)
                {
                    azonosito = value;
                }
                else
                {
                    throw new ArgumentException("Az azonosito nem lehet ures, es pontosan 8 karakternek kell lennie!");
                }
            }
        }
        public int Magassag
        {
            get => magassag;
            set
            {
                if (value > 0)
                {
                    magassag = value;
                }
                else
                {
                    throw new ArgumentException("A magassagnak minimum 1 cm-nek kell lennie!");
                }
            }
        }
        public int Hosszusag
        {
            get => hosszusag;
            set
            {
                if (value > 0)
                {
                    hosszusag = value;
                }
                else
                {
                    throw new ArgumentException("A hosszusagnak minimum 1 cm-nek kell lennie!");
                }
            }
        }
        public int Szelesseg
        {
            get => szelesseg;
            set
            {
                if (value > 0)
                {
                    szelesseg = value;
                }
                else
                {
                    throw new ArgumentException("A szelessegnek minimum 1 cm-nek kell lennie!");
                }
            }
        }
        #endregion

        #region CONSTRUCTORS
        protected Butor(string gyartoNeve, string azonosito, int magassag, int hosszusag, int szelesseg)
        {
            GyartoNeve = gyartoNeve;
            Azonosito = azonosito;
            Magassag = magassag;
            Hosszusag = hosszusag;
            Szelesseg = szelesseg;
        }
        #endregion

        #region METHODS
        public abstract int Kalkulator();
        #endregion

    }
}
