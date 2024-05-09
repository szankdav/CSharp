using MintaVizsga._utils;
using MintaVizsga.Model;
using MintaVizsga.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaVizsga
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadProductList();
        }

        // Database load at startup
        public void LoadProductList()
        {
            ProductDAO productDAO = new ProductDAO();
            DgwProducts.DataSource = null;
            DgwProducts.DataSource = productDAO.GetAllProducts();
        }

        private void BtnNewProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            if (frmAddProduct.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
            }
        }
    }
}
