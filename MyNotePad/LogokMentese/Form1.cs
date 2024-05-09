using System;
using System.IO;
using System.Windows.Forms;

namespace LogokMentese
{
    public partial class FrmLogokMentese : Form
    {
        string kezdoMappa = Environment.CurrentDirectory;
        int valtozas;
        public FrmLogokMentese()
        {
            InitializeComponent();
        }

        private void FrmLogokMentese_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fajl = new StreamWriter($@"{folderBrowserDialog1.SelectedPath}\tmp.log");
                //StreamWriter fajl = new StreamWriter($"{folderBrowserDialog1.SelectedPath}\\tmp.log");
                fajl.Close();
                valtozas = 0;
                this.Activate();
            }
            else
            {
                this.Close();
            }
        }

        private void FrmLogokMentese_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (folderBrowserDialog1.SelectedPath != String.Empty)
            {
                File.AppendAllText($"{folderBrowserDialog1.SelectedPath}\\main.log{string.Format("[{0}]: ", DateTime.Now)}", TxbTartalom.Text);
                File.Delete($@"{folderBrowserDialog1.SelectedPath}\tmp.log");
            }
        }

        private void TxbTartalom_TextChanged(object sender, EventArgs e)
        {
            valtozas++;
            LblInformacio.Text = valtozas.ToString();
            if (valtozas == 5)
            {
                File.WriteAllText($@"{folderBrowserDialog1.SelectedPath}\tmp.log", TxbTartalom.Text);
                valtozas = 0;
            }
        }
    }
}
