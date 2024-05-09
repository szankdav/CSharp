using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermekekSharedDLL;

namespace TermekekAdminDLL
{
    public partial class FrmMain : Form
    {
        List<Termek> termekek;
        const char szeparator = ';';
        public FrmMain()
        {
            InitializeComponent();
            termekek = new List<Termek>();
        }

        private void BtnBeolvasas_Click(object sender, EventArgs e)
        {
            try
            {
                termekek = TermekekEntity.TermekFromCSV("termekek.csv", szeparator);
                ListBoxRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLetrehozas_Click(object sender, EventArgs e)
        {
            FrmTermek frm = new FrmTermek();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                termekek.Add(frm.Termek);
                ListBoxRefresh();
            }
        }

        private void ListBoxRefresh()
        {
            LsbAdatok.DataSource = null;
            LsbAdatok.DataSource = termekek;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                TermekekEntity.TermekekToCSV("termekek.csv", termekek, szeparator);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
