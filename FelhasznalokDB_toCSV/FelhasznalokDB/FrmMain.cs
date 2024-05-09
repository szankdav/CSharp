using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FelhasznalokDB
{
    public partial class FrmMain : Form
    {
        List<Felhasznalo> felhasznalok;
        public FrmMain()
        {
            InitializeComponent();
            felhasznalok = new List<Felhasznalo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                DBkezelo.ConnectionOpen();
                MessageBox.Show("Az adatbazishoz kapcsolodas sikeres!", "Kapcsolodas...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListViewRefresh();
                this.Show();
                this.BringToFront();
            }
            catch (DBKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FormClosing -= FrmMain_FormClosing;
                this.Close();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valoban ki szeretne lepni?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                if (MessageBox.Show("Kilepes elott szeretne elmenteni a listaban talalthato elemeket?", "Mentes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    saveFileDialog1.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
                    saveFileDialog1.DefaultExt = "csv";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string mentesHelye = saveFileDialog1.FileName;
                        foreach (ListViewItem item in LswUserData.Items)
                        {
                            Felhasznalo felhasznalo = new Felhasznalo(item.SubItems[1].Text, item.SubItems[2].Text, DateTime.Parse(item.SubItems[3].Text), int.Parse(item.SubItems[0].Text));
                            CSVMentes.CSVFajlMentes(felhasznalo, mentesHelye);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nem valasztott ki fajlt a menteshez!", "Mentes...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void ListViewRefresh()
        {
            LswUserData.Items.Clear();
            try
            {
                felhasznalok.Clear();
                felhasznalok = DBkezelo.AllUsers();
                foreach (Felhasznalo felhasznalo in felhasznalok)
                {
                    ListViewItem elem = new ListViewItem(felhasznalo.Uid.ToString());
                    elem.SubItems.Add(felhasznalo.Felhasznalonev);
                    elem.SubItems.Add(felhasznalo.Jelszo.ToString());
                    elem.SubItems.Add(felhasznalo.RegisztraciosIdo.ToString());
                    LswUserData.Items.Add(elem);
                }
                for (int i = 0; i < LswUserData.Columns.Count; i++)
                {
                    LswUserData.Columns[i].Width = -2; // A listview teljes tartalmat megnezi, oszloprol oszlopra, es a fejlec, valamint az item alapjan a legszelesebb fejlec, vagy item szelessegehez igazitja az oszlop szelesseget. -1 erteknel nem veszi figyelembe a fejlec szoveget, csak az item szovegszelesseget
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ********** ****************** TESZTEK AZ ADATBAZIS KEZELESEHEZ ***************** ***********
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Felhasznalo uj = new Felhasznalo("Jozsef", "arvizturotukorfuroge", DateTime.Now);
            //    DBkezelo.UserCreate(uj);
            //}
            //catch (DBKivetel ex)
            //{
            //    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Felhasznalo mod = new Felhasznalo("Petra", "oszibarack", DateTime.Now, 3);
            //    DBkezelo.UserModify(mod);
            //}
            //catch (DBKivetel ex)
            //{
            //    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DBkezelo.UserDelete(2);
            //}
            //catch (DBKivetel ex)
            //{
            //    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmFelhasznalo frm = new FrmFelhasznalo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewRefresh();
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (LswUserData.SelectedItems.Count > 0)
            {
                FrmFelhasznalo frm = new FrmFelhasznalo(int.Parse(LswUserData.SelectedItems[0].SubItems[0].Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListViewRefresh();
                }
            }
            else
            {
                MessageBox.Show("Nincs kivalasztott elem a modositashoz!", "Modositas...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (LswUserData.SelectedItems.Count > 0)
            {
                FrmFelhasznalo frm = new FrmFelhasznalo(int.Parse(LswUserData.SelectedItems[0].SubItems[0].Text), true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs kivalasztott elem a megjeleniteshez!", "Megjelenites...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LswUserData.SelectedItems.Count > 0)
            {
                try
                {
                    DBkezelo.UserDelete(int.Parse(LswUserData.SelectedItems[0].SubItems[0].Text));
                    ListViewRefresh();
                }
                catch (DBKivetel ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nincs kivalasztott elem a torleshez!", "Torles...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
