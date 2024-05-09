using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvNyilvantarto
{
    public partial class FrmKonyv : Form
    {
        Konyv book;
        public FrmKonyv()
        {
            InitializeComponent();
            CmbMufaj.DataSource = Enum.GetValues(typeof(Kategoriak)).Cast<Enum>().Select(value => new 
            { 
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value
            }).OrderBy(item => item.value).ToList();
            CmbMufaj.DisplayMember = "Description";
            CmbMufaj.ValueMember = "value";
            this.Text = "Új könyv felvitele";
        }

        public FrmKonyv(int sorszam, bool view = false) : this()
        {
            this.Text = "Könyv módosítása";
            book = DatabaseManage.OneBook(sorszam);
            TxbCim.Text = book.Cim;
            TxbSzerzo.Text = book.Szerzo;
            CmbMufaj.SelectedItem = book.Mufaj;
            TxbSorszam.Text = book.Sorszam.ToString();

            if (view)
            {
                this.Text = "Könyv megtekintése";
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }
                BtnMegsem.Enabled = true;
                this.ActiveControl = BtnMegsem;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (book != null)
            {
                try
                {
                    book.Cim = TxbCim.Text.Trim();
                    book.Szerzo = TxbSzerzo.Text.Trim();
                    book.Mufaj = (Kategoriak)CmbMufaj.SelectedItem;
                    DatabaseManage.ModifyBook(book);
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
                    Konyv book = new Konyv(TxbCim.Text.Trim(), TxbSzerzo.Text.Trim(), (Kategoriak)CmbMufaj.SelectedIndex);
                    DatabaseManage.AddBook(book);
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
