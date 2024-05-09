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

namespace TermekekKliensDLL
{
    public partial class FrmMain : Form
    {
        // C:\Users\TUF Gaming\source\repos\TermekekDLLPelda\TermekekAdminDLL\bin\Debug\termekek.csv
        const char szeparator = ';';
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnBeolvasas_Click(object sender, EventArgs e)
        {
            LsbAdatok.DataSource = null;
            LsbAdatok.DataSource = TermekekEntity.TermekFromCSV("C:\\Users\\TUF Gaming\\source\\repos\\TermekekDLLPelda\\TermekekAdminDLL\\bin\\Debug\\termekek.csv", ';');
        }
    }
}
