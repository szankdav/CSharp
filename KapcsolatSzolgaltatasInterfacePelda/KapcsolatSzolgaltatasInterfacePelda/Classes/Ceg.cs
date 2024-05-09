using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    enum TelefonTipus
    {
        [Description("Budapesti vezetekes telefonszam")]
        bp,
        [Description("Videki vezetekes telefonszam")]
        videk,
        [Description("Mobil telefonszam")]
        mobil
    }

    internal class Ceg : ICSVMentes
    {
        #region PRIVATE FIELDS
        string cegNev;
        Cim cegCim;
        string email;
        string telefon;
        TelefonTipus tipus;
        List<Szolgaltatas> szolgaltatasLista;
        #endregion

        #region PUBLIC PROPERTIES
        public string CegNev
        {
            get => cegNev;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 50) { cegNev = value; }
                else { throw new ArgumentException("A cegnev nem megfelelo!"); }
            }
        }
        internal Cim CegCim { get => cegCim; set => cegCim = value; }
        public string Email
        {
            get => email;
            set
            {
                if (EmailEllenorzes(value.Trim())) { email = value; }
                else { throw new ArgumentException("Az email cim nem valid!"); }
            }
        }
        public string Telefon
        {
            get => telefon;
            set
            {
                if (TelefonSzamEllenorzes(value)) { telefon = value; }
                else { throw new ArgumentException("Az email cim nem valid!"); }
            }
        }

        internal TelefonTipus Tipus
        {
            get => tipus; set
            {
                if (Enum.IsDefined(typeof(TelefonTipus), value))
                {
                    tipus = value;
                }
                else { throw new ArgumentException("A telefonszam tipusa nem megfelelo!");}
            }
        }

        internal List<Szolgaltatas> SzolgaltatasLista
        {
            get
            {
                List<Szolgaltatas> masolat = new List<Szolgaltatas>();
                foreach (Szolgaltatas item in szolgaltatasLista)
                {
                    masolat.Add(item);
                }
                return masolat;
            }

        }
        #endregion

        #region CONSTRUCTORS
        public Ceg(string cegNev, Cim cegCim, string email, string telefon, TelefonTipus tipus)
        {
            CegNev = cegNev;
            CegCim = cegCim;
            Email = email;
            Telefon = telefon;
            Tipus = tipus;
            szolgaltatasLista = new List<Szolgaltatas>();
        }
        #endregion

        #region METHODS
        public void SzolgaltatasHozzaadas(Szolgaltatas szolgaltatas)
        {
            if (szolgaltatas != null)
            {
                szolgaltatasLista.Add(szolgaltatas);
            }
            else
            {
                throw new ArgumentException("A szolgaltatas nem lehet null!");
            }
        }

        public void SzolgaltatasTorles(int index)
        {
            szolgaltatasLista.RemoveAt(index);
        }

        public void SzolgaltatasModositas(Szolgaltatas szolgaltatas, int index)
        {
            szolgaltatasLista.RemoveAt(index);
            szolgaltatasLista.Insert(index, szolgaltatas); // ??????????
        }

        public bool EmailEllenorzes(string email)
        {

            return true;
        }

        private bool TelefonSzamEllenorzes(string telefon)
        {
            //Csak szamokat tartalmazhat a string
            return true;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Ceg neve: {cegNev}, cime: {cegCim.ToString()}, e-mail cim: {email} - telefonszam: {telefon}";
        }

        public string CSVFormatum(string szeparator = ";", string sorveg = "\n")
        {
            string csv = $"{CegNev}{szeparator}{CegCim.CSVFormatum()}{szeparator}{Email}{szeparator}{Telefon}{(int)tipus}{sorveg}";
            foreach (Szolgaltatas item in szolgaltatasLista)
            {
                csv += $"Szolgaltatas{szeparator}{item.CSVFormatum()}";
            }
            return csv;
        }
        #endregion
    }
}
