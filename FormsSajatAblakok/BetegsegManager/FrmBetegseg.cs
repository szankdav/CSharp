using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetegsegManager
{
    public partial class FrmBetegseg : Form
    {
        #region PRIVATE FIELDS
        Betegseg betegseg;
        #endregion
        #region PUBLIC PROPERTIES
        internal Betegseg Betegseg { get => betegseg; /*set => betegseg = value;*/ }
        #endregion

        #region CONSTRUCTORS
        public FrmBetegseg()
        {
            InitializeComponent();
            CmbTipus.DataSource = Enum.GetValues(typeof(BetegsegTipus));
            CmbLefolyas.DataSource = Enum.GetValues(typeof(BetegsegLefolyas));
            this.ActiveControl = TxbMegnevezes;
        }
        internal FrmBetegseg(Betegseg _betegseg, bool _megjelenites = false) :this()
        {
            if (_betegseg != null)
            {
                this.betegseg = _betegseg;
                TxbMegnevezes.Text = this.betegseg.Megnevezes;
                CmbTipus.SelectedItem = this.betegseg.Tipus;
                CmbLefolyas.SelectedItem = this.betegseg.Lefolyas;
                if (_megjelenites)
                {
                    foreach (Control item in GrbAdatok.Controls)
                    {
                        if (!(item is Label))
                        {
                            if (item is TextBox)
                            {
                                (item as TextBox).ReadOnly = true;
                            }
                            else
                            {
                                item.Enabled = false;
                            }
                        }
                    }
                    BtnOk.Enabled = false;
                    this.ActiveControl = BtnMegsem;
                }
            }
        }
        #endregion

        #region METHODS
        private void FrmBetegseg_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (this.betegseg == null)
            {
                try
                {
                    this.betegseg = new Betegseg(TxbMegnevezes.Text.Trim(), (BetegsegTipus)CmbTipus.SelectedItem, (BetegsegLefolyas)CmbLefolyas.SelectedItem);
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
                    this.betegseg.Megnevezes = TxbMegnevezes.Text.Trim();
                    this.betegseg.Tipus = (BetegsegTipus)CmbTipus.SelectedItem;
                    this.betegseg.Lefolyas = (BetegsegLefolyas)CmbLefolyas.SelectedItem;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
        }
        #endregion
    }
}
