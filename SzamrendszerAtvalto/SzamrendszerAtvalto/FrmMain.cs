using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SzamrendszerAtvalto
{
    public delegate void SzamrendszerBejovoParameterEllenorzo();
    public partial class FrmMain : Form
    {
        public event SzamrendszerBejovoParameterEllenorzo KettesSzamrendszerMegfeleloseg;
        public event SzamrendszerBejovoParameterEllenorzo TizenhatosSzamrendszerMegfeleloseg;
        enum Szamrendszerek
        {
            Tizes,
            Kettes,
            Tizenhatos
        }

        public FrmMain()
        {
            InitializeComponent();
            CmbBejovoSzamSzamrendszere.DataSource = Enum.GetValues(typeof(Szamrendszerek));
            CmbKimenoSzamrendszer.DataSource = Enum.GetValues(typeof(Szamrendszerek));
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretne lépni a programból?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnValtas_Click(object sender, EventArgs e)
        {
            if (CmbBejovoSzamSzamrendszere.SelectedIndex == 0 && CmbKimenoSzamrendszer.SelectedIndex == 1 && (byte.TryParse(TxbBejovoSzam.Text.Trim(), out byte bejovoTizesbolKettesbeEredmeny) == true))
            {
                string eredmeny = KettesbeValtas(TxbBejovoSzam.Text.Trim());
                if (eredmeny[0] == '0')
                {
                    eredmeny = eredmeny.Substring(1);
                }
                LblEredmeny.Text = eredmeny;
            }
            else if (CmbBejovoSzamSzamrendszere.SelectedIndex == 1 && CmbKimenoSzamrendszer.SelectedIndex == 0 && (int.TryParse(TxbBejovoSzam.Text.Trim(), out int bejovoKettesbolTizesbeEredmeny) == true))
            {
                LblEredmeny.Text = TizesbeValtas(TxbBejovoSzam.Text.Trim());
            }
            else if (CmbBejovoSzamSzamrendszere.SelectedIndex == 1 && CmbKimenoSzamrendszer.SelectedIndex == 2 && (int.TryParse(TxbBejovoSzam.Text.Trim(), out int bejovoKettesbolTizenhatosbaEredmeny) == true))
            {
                LblEredmeny.Text = TizenhatosbaValtas(TxbBejovoSzam.Text.Trim());
            }
            else if (CmbBejovoSzamSzamrendszere.SelectedIndex == 2 && CmbKimenoSzamrendszer.SelectedIndex == 1)
            {
                LblEredmeny.Text = TizenhatosbolKettesbeValtas();
            }
            else if (CmbBejovoSzamSzamrendszere.SelectedIndex == 2 && CmbKimenoSzamrendszer.SelectedIndex == 0)
            {
                LblEredmeny.Text = TizesbeValtas(TizenhatosbolKettesbeValtas());
            }
            else if (CmbBejovoSzamSzamrendszere.SelectedIndex == 0 && CmbKimenoSzamrendszer.SelectedIndex == 2)
            {
                LblEredmeny.Text = TizenhatosbaValtas(KettesbeValtas(TxbBejovoSzam.Text.Trim()));
            }
            else
            {
                MessageBox.Show("A 10-es számrendszerből 2-es számrendszerbe való váltás során a maximum megadható szám a 255.", "8 bit-es váltás...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CmbBejovoSzamSzamrendszere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBejovoSzamSzamrendszere.SelectedIndex == 0)
            {
                TxbBejovoSzam.Text = string.Empty;
                TxbBejovoSzam.MaxLength = 3;
            }
            else if (CmbBejovoSzamSzamrendszere.SelectedIndex == 1)
            {
                TxbBejovoSzam.Text = string.Empty;
                TxbBejovoSzam.MaxLength = 8;
                KettesSzamrendszerMegfeleloseg += KettesSzamrendszerEllenorzes;
            }
            else
            {
                TxbBejovoSzam.Text = string.Empty;
                TxbBejovoSzam.MaxLength = 2;
                TizenhatosSzamrendszerMegfeleloseg += TizenhatosSzamrendszerEllenorzes;
            }
        }

        private string KettesbeValtas(string tizesSzamSzovege)
        {
            byte tizesSzam;
            tizesSzam = byte.Parse(tizesSzamSzovege);
            string eredmeny = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    if (tizesSzam - 128 >= 0)
                    {
                        tizesSzam -= 128;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
                else if (i == 1)
                {
                    if (tizesSzam - 64 >= 0)
                    {
                        tizesSzam -= 64;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
                else if (i == 2)
                {
                    if (tizesSzam - 32 >= 0)
                    {
                        tizesSzam -= 32;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
                else if (i == 3)
                {
                    if (tizesSzam - 16 >= 0)
                    {
                        tizesSzam -= 16;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
                else if (i == 4)
                {
                    if (tizesSzam - 8 >= 0)
                    {
                        tizesSzam -= 8;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
                else if (i == 5)
                {
                    if (tizesSzam - 4 >= 0)
                    {
                        tizesSzam -= 4;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
                else if (i == 6)
                {
                    if (tizesSzam - 2 >= 0)
                    {
                        tizesSzam -= 2;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
                else if (i == 7)
                {
                    if (tizesSzam - 1 >= 0)
                    {
                        tizesSzam -= 1;
                        eredmeny += "1";
                    }
                    else
                    {
                        eredmeny += "0";
                    }
                }
            }
            return eredmeny;
        }

        private string TizesbeValtas(string kettesSzam)
        {
            byte eredmeny = 0;
            if (kettesSzam != null)
            {
                eredmeny += byte.Parse(kettesSzam[0].ToString()) == 1 ? (byte)128 : (byte)0;
                eredmeny += byte.Parse(kettesSzam[1].ToString()) == 1 ? (byte)64 : (byte)0;
                eredmeny += byte.Parse(kettesSzam[2].ToString()) == 1 ? (byte)32 : (byte)0;
                eredmeny += byte.Parse(kettesSzam[3].ToString()) == 1 ? (byte)16 : (byte)0;
                eredmeny += byte.Parse(kettesSzam[4].ToString()) == 1 ? (byte)8 : (byte)0;
                eredmeny += byte.Parse(kettesSzam[5].ToString()) == 1 ? (byte)4 : (byte)0;
                eredmeny += byte.Parse(kettesSzam[6].ToString()) == 1 ? (byte)2 : (byte)0;
                eredmeny += byte.Parse(kettesSzam[7].ToString()) == 1 ? (byte)1 : (byte)0;
            }
            return eredmeny.ToString();
        }

        private string TizenhatosbaValtas(string kettesSzam)
        {
            byte eredmenyElsoSzama = 0;
            string eredmeny = string.Empty;
            byte eredmenyMasodikSzama = 0;
            eredmenyElsoSzama += byte.Parse(kettesSzam[0].ToString()) == 1 ? (byte)8 : (byte)0;
            eredmenyElsoSzama += byte.Parse(kettesSzam[1].ToString()) == 1 ? (byte)4 : (byte)0;
            eredmenyElsoSzama += byte.Parse(kettesSzam[2].ToString()) == 1 ? (byte)2 : (byte)0;
            eredmenyElsoSzama += byte.Parse(kettesSzam[3].ToString()) == 1 ? (byte)1 : (byte)0;
            eredmenyMasodikSzama += byte.Parse(kettesSzam[4].ToString()) == 1 ? (byte)8 : (byte)0;
            eredmenyMasodikSzama += byte.Parse(kettesSzam[5].ToString()) == 1 ? (byte)4 : (byte)0;
            eredmenyMasodikSzama += byte.Parse(kettesSzam[6].ToString()) == 1 ? (byte)2 : (byte)0;
            eredmenyMasodikSzama += byte.Parse(kettesSzam[7].ToString()) == 1 ? (byte)1 : (byte)0;

            if (eredmenyElsoSzama >= 10)
            {
                switch (eredmenyElsoSzama)
                {
                    case 10:
                        eredmeny += "A";
                        break;
                    case 11:
                        eredmeny += "B";
                        break;
                    case 12:
                        eredmeny += "C";
                        break;
                    case 13:
                        eredmeny += "D";
                        break;
                    case 14:
                        eredmeny += "E";
                        break;
                    case 15:
                        eredmeny += "F";
                        break;
                }
            }
            else
            {
                eredmeny += eredmenyElsoSzama.ToString();
            }

            if (eredmenyMasodikSzama >= 10)
            {
                switch (eredmenyMasodikSzama)
                {
                    case 10:
                        eredmeny += "A";
                        break;
                    case 11:
                        eredmeny += "B";
                        break;
                    case 12:
                        eredmeny += "C";
                        break;
                    case 13:
                        eredmeny += "D";
                        break;
                    case 14:
                        eredmeny += "E";
                        break;
                    case 15:
                        eredmeny += "F";
                        break;
                }
            }
            else
            {
                eredmeny += eredmenyMasodikSzama.ToString();
            }
            return eredmeny;
        }

        public string TizenhatosbolKettesbeValtas()
        {
            string bejovoTizenhatosSzam = TxbBejovoSzam.Text.Trim();
            string eredmeny = string.Empty;
            string elsoSzam = bejovoTizenhatosSzam[0].ToString();
            string masodikSzam = bejovoTizenhatosSzam[1].ToString();
            string regexPattern = @"^[A-F]";
            Regex regex = new Regex(regexPattern);
            if (regex.IsMatch(elsoSzam))
            {
                switch (elsoSzam)
                {
                    case "A":
                        elsoSzam = "10";
                        break;
                    case "B":
                        elsoSzam = "11";
                        break;
                    case "C":
                        elsoSzam = "12";
                        break;
                    case "D":
                        elsoSzam = "13";
                        break;
                    case "E":
                        elsoSzam = "14";
                        break;
                    case "F":
                        elsoSzam = "15";
                        break;
                }
            }

            if (regex.IsMatch(masodikSzam))
            {
                switch (masodikSzam)
                {
                    case "A":
                        masodikSzam = "10";
                        break;
                    case "B":
                        masodikSzam = "11";
                        break;
                    case "C":
                        masodikSzam = "12";
                        break;
                    case "D":
                        masodikSzam = "13";
                        break;
                    case "E":
                        masodikSzam = "14";
                        break;
                    case "F":
                        masodikSzam = "15";
                        break;
                }
            }
            byte elsoValosSzam = byte.Parse(elsoSzam);
            byte masodikValosSzam = byte.Parse(masodikSzam);
            string kettesreValtottSzam = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    if (elsoValosSzam - 8 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        elsoValosSzam -= 8;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }
                if (i == 1)
                {
                    if (elsoValosSzam - 4 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        elsoValosSzam -= 4;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }
                if (i == 2)
                {
                    if (elsoValosSzam - 2 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        elsoValosSzam -= 2;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }
                if (i == 3)
                {
                    if (elsoValosSzam - 1 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        elsoValosSzam -= 1;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }

                if (i == 4)
                {
                    if (masodikValosSzam - 8 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        masodikValosSzam -= 8;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }
                if (i == 5)
                {
                    if (masodikValosSzam - 4 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        masodikValosSzam -= 4;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }
                if (i == 6)
                {
                    if (masodikValosSzam - 2 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        masodikValosSzam -= 2;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }
                if (i == 7)
                {
                    if (masodikValosSzam - 1 >= 0)
                    {
                        kettesreValtottSzam += "1";
                        masodikValosSzam -= 1;
                    }
                    else
                    {
                        kettesreValtottSzam += "0";
                    }
                }
            }
            return kettesreValtottSzam;
        }

        private void KettesSzamrendszerEllenorzes()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbBejovoSzam.Text, "[^0-1]"))
            {
                MessageBox.Show("Kérem csak 1-eseket és/vagy 0-kat írjon be!");
                TxbBejovoSzam.Text = TxbBejovoSzam.Text.Remove(TxbBejovoSzam.Text.Length - 1);
            }
        }

        private void TizenhatosSzamrendszerEllenorzes()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxbBejovoSzam.Text, "[^0-9A-F]"))
            {
                MessageBox.Show("Kérem csak számokat, és A-F-ig betűket írjon be!");
                TxbBejovoSzam.Text = TxbBejovoSzam.Text.Remove(TxbBejovoSzam.Text.Length - 1);
            }
        }

        private void TxbBejovoSzam_TextChanged(object sender, EventArgs e)
        {
            if (CmbBejovoSzamSzamrendszere.SelectedIndex == 1)
            {
                KettesSzamrendszerMegfeleloseg?.Invoke();
            }
            else if (CmbBejovoSzamSzamrendszere.SelectedIndex == 2)
            {
                TizenhatosSzamrendszerMegfeleloseg?.Invoke();
            }
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
