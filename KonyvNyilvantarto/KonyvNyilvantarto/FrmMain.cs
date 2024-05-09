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
    public partial class FrmMain : Form
    {
        List<Konyv> books;
        public FrmMain()
        {
            InitializeComponent();
            books = new List<Konyv>();
            CmbSzuresMufaj.DataSource = Enum.GetValues(typeof(Kategoriak)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            }).OrderBy(item => item.value).ToList();
            CmbSzuresMufaj.DisplayMember = "Description";
            CmbSzuresMufaj.ValueMember = "value";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                DatabaseManage.ConnectionOpen();
                MessageBox.Show("Sikeres kapcsolódás az adatbázishoz!", "Kapcsolódás...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListViewRefresh();
                this.Show();
                this.BringToFront();
            }
            catch (DatabaseExceptionManage ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.FormClosing -= FrmMain_FormClosing;
                this.Close();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban ki szeretne lépni?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            FrmKonyv frm = new FrmKonyv();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ListViewRefresh();
            }
        }

        private void BtnModifyBook_Click(object sender, EventArgs e)
        {
            if (LswBookList.SelectedItems.Count > 0)
            {
                FrmKonyv frm = new FrmKonyv(int.Parse(LswBookList.SelectedItems[0].SubItems[3].Text));
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListViewRefresh();
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölve könyv a módosításhoz!", "Módosítás...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnViewBook_Click(object sender, EventArgs e)
        {
            if (LswBookList.SelectedItems.Count > 0)
            {
                FrmKonyv frm = new FrmKonyv(int.Parse(LswBookList.SelectedItems[0].SubItems[3].Text), true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs kijelölve könyv a módosításhoz!", "Módosítás...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (LswBookList.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Biztos törölni szeretné a kijelölt könyvet?", "Törlés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DatabaseManage.DeleteBook(int.Parse(LswBookList.SelectedItems[0].SubItems[3].Text));
                    ListViewRefresh();
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölve könyv a törléshez!", "Törlés...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxbSzuresCim.Text) && string.IsNullOrEmpty(TxbSzuresSzerzo.Text) && CmbSzuresMufaj.SelectedIndex == 0)
            {
                MessageBox.Show("Nincs elegendő adat a szűréshez!", "Szűrés nem lehetséges...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LswBookList.Items.Clear();
                try
                {
                    books.Clear();
                    books = DatabaseManage.FilterBooks((Kategoriak)CmbSzuresMufaj.SelectedIndex, TxbSzuresCim.Text.Trim(), TxbSzuresSzerzo.Text.Trim());
                    foreach (Konyv book in books)
                    {
                        ListViewItem newItem = new ListViewItem(book.Cim);
                        newItem.SubItems.Add(book.Szerzo);
                        newItem.SubItems.Add(book.Mufaj.ToString());
                        newItem.SubItems.Add(book.Sorszam.ToString());
                        LswBookList.Items.Add(newItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            ListViewRefresh();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListViewRefresh()
        {
            LswBookList.Items.Clear();
            try
            {
                books.Clear();
                books = DatabaseManage.AllBooks();
                foreach (Konyv book in books)
                {
                    ListViewItem newItem = new ListViewItem(book.Cim);
                    newItem.SubItems.Add(book.Szerzo);
                    newItem.SubItems.Add(book.Mufaj.ToString());
                    newItem.SubItems.Add(book.Sorszam.ToString());
                    LswBookList.Items.Add(newItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LswBookList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = LswBookList.Columns[e.ColumnIndex].Width;
        }
    }
}
