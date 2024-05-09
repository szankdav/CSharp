using System;
using System.IO;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class FrmMain : Form
    {
        #region PRIVATE FIELDS
        string initDirectory = Environment.CurrentDirectory;
        #endregion
        #region PUBLIC PROPERTIES

        #endregion
        #region CONSTRUCTORS
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion
        #region METHODS
        #region FORM EVENTS
        private void FrmMain_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = initDirectory;
            saveFileDialog1.InitialDirectory = initDirectory;
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban ki szeretne lépni?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        #endregion
        #region COMPONENT EVENTS
        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in File.ReadAllLines(openFileDialog1.FileName))
                {
                    //textBox1.Text += item + "\r\n";
                    //textBox1.Text += item + Environment.NewLine;
                    textBox1.Text += $"{item}{Environment.NewLine}";
                }
            }
            else
            {
                MessageBox.Show("Nem lett fájl kiválasztva a megnyitásra.", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName != "default")
            {
                File.WriteAllText(openFileDialog1.FileName, textBox1.Text);
                MessageBox.Show($"A fájl mentése sikeresen megtörtént!\n{openFileDialog1.FileName}", "Információ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (openFileDialog1.FileName == "default")
            {
                mentésMáskéntToolStripMenuItem_Click(sender, e);
            }
        }

        private void mentésMáskéntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                MessageBox.Show($"A fájl mentése sikeresen megtörtént!\n{saveFileDialog1.FileName}", "Információ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }
        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
        }

        private void kivágásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            másolásToolStripMenuItem_Click(sender, e);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }

        private void beillesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, Clipboard.GetText());
            }
        }
        #endregion

        #region MY METHODS
        #endregion

        #endregion
    }
}
