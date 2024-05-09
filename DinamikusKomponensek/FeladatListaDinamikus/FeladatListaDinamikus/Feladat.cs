using System;
using System.Windows.Forms;
using System.Drawing;

namespace FeladatListaDinamikus
{
    enum FeladatPrioritas
    {
        Alacsony,
        Normál,
        Magas
    }
    internal class Feladat
    {
        #region PRIVATE FIELDS
        string cim;
        string leiras;
        DateTime datum;
        FeladatPrioritas prioritas;
        #endregion

        #region PUBLIC PROPERTIES
        public string Cim
        {
            get => cim;
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()) && value.Trim().Length >= 5 && value.Trim().Length <= 30) { cim = value; }
                else { throw new ArgumentException("A cím értéke minimum 5 és maximum 30 karakter lehet!"); }
            }
        }
        public string Leiras
        {
            get => leiras;
            set
            {
                if (!string.IsNullOrEmpty(value.Trim()) && value.Trim().Length >= 5 && value.Trim().Length <= 250) { leiras = value; }
                else { throw new ArgumentException("A leírás értéke minimum 5 és maximum 250 karakter lehet!"); }
            }
        }
        public DateTime Datum
        {
            get => datum;
            set
            {
                if (value >= DateTime.MinValue) { datum = value; }
                else { throw new ArgumentException("A dátum értéke nem megfelelő!"); }
            }
        }
        internal FeladatPrioritas Prioritas
        {
            get => prioritas;
            set
            {
                if (Enum.IsDefined(typeof(FeladatPrioritas), value)) { prioritas = value; }
                else { throw new ArgumentException("A prioritás értéke nem megfelelő!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Feladat(string cim, string leiras, DateTime datum, FeladatPrioritas prioritas)
        {
            Cim = cim;
            Leiras = leiras;
            Datum = datum;
            Prioritas = prioritas;
        }

        public Feladat(string sor)
        {
            string[] adatok = sor.Split(';');
            if (adatok.Length == 4)
            {
                Cim = adatok[0].Trim();
                Leiras = adatok[1].Trim();
                Datum = DateTime.Parse(adatok[2].Trim());
                Prioritas = (FeladatPrioritas)int.Parse(adatok[3].Trim());
            }
            else
            {
                throw new ArgumentException("A csv nem tartalmaz megfelelő adatot!");
            }
        }
        #endregion

        #region METHODS
        public string CSVFormatum()
        {
            return $"{this.cim};{this.leiras};{this.datum.ToString("yyyy-MM-dd")};{(int)prioritas}";
        }

        public static Feladat ParseCSV(string sor)
        {
            string[] adatok = sor.Split(';');
            if (adatok.Length == 4)
            {
                return new Feladat(adatok[0].Trim(), adatok[1].Trim(), DateTime.Parse(adatok[2].Trim()), (FeladatPrioritas)int.Parse(adatok[3].Trim()));
            }
            else
            {
                throw new ArgumentException("A csv nem tartalmaz megfelelő adatot!");
            }
        }

        public static GroupBox FealadatKomponens(Feladat alap, int grbWidth, int grbHeight)
        {
            GroupBox grb = new GroupBox()
            {
                Name = "Feladat",
                Text = alap.cim,
                Width = grbWidth,
                Height = grbHeight,
                Tag = alap

            };
            Label LblFeladatCime = new Label()
            {
                Top = 21,
                Left = 6,
                Width = 200,
                Height = 22,
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "Feladat címe",
                Parent = grb
            };
            TextBox TxbFeladatCime = new TextBox()
            {
                Top = 21,
                Left = 212,
                Width = 542,
                Height = 22,
                Text = alap.cim,
                ReadOnly = true,
                Parent = grb
            };
            Label LblFeladatLeirasa = new Label()
            {
                Top = 49,
                Left = 6,
                Width = 200,
                Height = 22,
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "Feladat leírása",
                Parent = grb
            };
            TextBox TxbFeladatLeirasa = new TextBox()
            {
                Top = 49,
                Left = 212,
                Width = 542,
                Height = 88,
                Text = alap.leiras,
                ReadOnly = true,
                Multiline = true,
                Parent = grb
            };
            Label LblFeladatDatuma = new Label()
            {
                Top = 143,
                Left = 6,
                Width = 200,
                Height = 22,
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "Feladat dátuma",
                Parent = grb
            };
            DateTimePicker DtpFeladatDatuma = new DateTimePicker()
            {
                Top = 143,
                Left = 212,
                Width = 542,
                Height = 22,
                CustomFormat = "yyyy-MM-dd",
                Format = DateTimePickerFormat.Custom,
                Value = alap.datum,
                Enabled = false,
                Parent = grb

            };
            Label LblFeladatPrioritasa = new Label()
            {
                Top = 171,
                Left = 6,
                Width = 200,
                Height = 24,
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "Feladat prioritása",
                Parent = grb
            };
            ComboBox CmbFeladatPrioritasa = new ComboBox()
            {
                Top = 171,
                Left = 212,
                Width = 542,
                Height = 24,
                Enabled = false,
                Parent = grb
            };
            foreach (var item in Enum.GetNames(typeof(FeladatPrioritas)))
            {
                CmbFeladatPrioritasa.Items.Add(item);
            }
            CmbFeladatPrioritasa.SelectedIndex = (int)alap.prioritas;
            return grb;
        }
        #endregion
    }
}
