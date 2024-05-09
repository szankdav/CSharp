using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznalokDB
{
    public partial class FrmFelhasznalo : Form
    {
        int userID;
        Felhasznalo felhasznalo;
        public FrmFelhasznalo()
        {
            InitializeComponent();
        }

        public FrmFelhasznalo(int uId, bool preView = false) : this()
        {
            userID = uId;
            if (preView)
            {
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
                BtnMegsem.Enabled = true;
            }
        }

        private void FrmFelhasznalo_Load(object sender, EventArgs e)
        {
            if (userID > 0)
            {
                felhasznalo = DBkezelo.OneUser(userID);
                TxbUid.Text = felhasznalo.Uid.ToString();
                TxbFelhasznalonev.Text = felhasznalo.Felhasznalonev;
                TxbJelszo.Text = felhasznalo.Jelszo;
                DtpRegIdo.Value = felhasznalo.RegisztraciosIdo;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (felhasznalo != null)
            {
                try
                {
                    //Felhasznalo mod = new Felhasznalo(TxbFelhasznalonev.Text.Trim(), TxbJelszo.Text.Trim(), DtpRegIdo.Value, userID);????
                    felhasznalo.Felhasznalonev = TxbFelhasznalonev.Text.Trim();
                    felhasznalo.Jelszo = TxbJelszo.Text.Trim();
                    felhasznalo.RegisztraciosIdo = DtpRegIdo.Value;
                    DBkezelo.UserModify(felhasznalo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                try
                {
                    Felhasznalo ujFelhasznalo = new Felhasznalo(TxbFelhasznalonev.Text.Trim(), TxbJelszo.Text.Trim(), DtpRegIdo.Value);
                    DBkezelo.UserCreate(ujFelhasznalo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
        }
    }
}
