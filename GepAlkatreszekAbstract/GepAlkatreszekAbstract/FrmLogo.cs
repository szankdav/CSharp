using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepAlkatreszekAbstract
{
    public partial class FrmLogo : Form
    {
        int count = 0, buffer = 0;

        public FrmLogo()
        {
            InitializeComponent();
        }

        private void FrmLogo_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                timer1.Stop();
                timer2.Start();
            }
            else
            {
                count++;
                this.Opacity = count * 0.01;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (buffer == 10)
            {
                timer2.Stop();
                timer3.Start();
            }
            else
            {
                buffer++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                timer3.Stop();
                DialogResult = DialogResult.OK;
            }
            else
            {
                count--;
                this.Opacity = count * 0.01;
            }
        }
    }
}
