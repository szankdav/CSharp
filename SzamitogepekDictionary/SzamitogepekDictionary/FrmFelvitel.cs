using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamitogepekDictionary
{
    public partial class FrmFelvitel : Form
    {
        IPAddress ip;
        string mac;
        Szamitogep szamitogep;
        public IPAddress Ip { get => ip; /*set => ip = value;*/ }
        public string Mac { get => mac; /*set => mac = value;*/ }
        internal Szamitogep Szamitogep { get => szamitogep; /*set => szamitogep = value;*/ }
        public FrmFelvitel()
        {
            InitializeComponent();
        }
        // TODO: A ket leave metodus megoldasa ugy, hogy hiba eseten addig a mezorol ne lehessen arrebb menni, amig a hibat ki nem javitjak!
        private void TxbIPCim_Leave(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(TxbIPCim.Text.Trim(), out ip))
            {
                TxbIPCim.ForeColor = Color.White;
                TxbIPCim.BackColor = Color.Green;
            }
            else
            {
                TxbIPCim.ForeColor = Color.Yellow;
                TxbIPCim.BackColor= Color.Red;
                this.ActiveControl = TxbIPCim;
            }
        }

        private void TxbMACCim_Leave(object sender, EventArgs e)
        {
            //-Minta illesztéses kifejezési forma – egy szabványos mintafelírást lehetővé tévő leírónyelv, melynek segítségével képesek lehetünk egy szöveges formai mintát általánosan leírni – majd keresni és feldolgozni a szövegben.
            //-A minta felírási logikája:
            //o Enclosing – minta határvonalai – ezt nem minden értelmező kéri, de ez adja meg, hogy mettől - meddig tart a minta - /…/
            //o ?  a jelölt helyen 0 vagy 1 karakter található
            //o *  a jelölt helyen 0 vagy több karakter található
            //o +  a jelölt helyen 1 vagy több karakter található
            //o[…]  az adott helyen mi lehet – pl.: [abc]  a jelölt helye lehet a vagy b vagy c, [a-z] -a jelölt helyen kis a-tól kis z-ig bármi lehet
            //o escape karakter - \ -a mögötte lévő karakternek a speciális jelentését hozza elő, vagy veszi el.
            //	[\[\]]

            if (Regex.IsMatch(TxbMACCim.Text.Trim(), "[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}"))
            {
                TxbMACCim.ForeColor = Color.White;
                TxbMACCim.BackColor = Color.Green;
            }
            else
            {
                TxbMACCim.ForeColor = Color.Yellow;
                TxbMACCim.BackColor= Color.Red;
                this.ActiveControl = TxbMACCim;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(TxbIPCim.Text.Trim(), out ip) && Regex.IsMatch(TxbMACCim.Text.Trim(), "[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}[:-]{1}[0-9A-F]{2}"))
            {
                try
                {
                    mac = TxbMACCim.Text;
                    szamitogep = new Szamitogep(TxbOperaciosRendszer.Text.Trim(), TxbTulajdonos.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("Kerem, ellenorizze az adatok helyesseget!", "Figyelmeztetes...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
