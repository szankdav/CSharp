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

namespace MintaVizsga.View
{
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
            FillComboBoxVatCategories();
            FillCategoryComboBox();
        }

        public void BtnOK_Click(object sender, EventArgs e)
        {
            SaveProductToDatabase(ProductDataFromFormFields());
            MessageBox.Show("Sikeres termék mentés!");
            ResetFormFields();
        }

        public void FillCategoryComboBox()
        {
            ProductCategoryDAO categoryDAO = new ProductCategoryDAO();
            CmbCategoryId.DataSource = categoryDAO.GetCategoryDataFromDatabase();
            CmbCategoryId.ValueMember = "id";
            CmbCategoryId.DisplayMember = "name";
        }

        public void FillComboBoxVatCategories()
        {
            VatCategoryDAO vatCatgoryDaoObj = new VatCategoryDAO();
            CmbVatValue.ValueMember = "id";
            CmbVatValue.DisplayMember = "name";
            CmbVatValue.DataSource = vatCatgoryDaoObj.GetAllVatCategories();
        }

        public void SaveProductToDatabase(Product product)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.CreateNewProduct(product);
        }

        public Product ProductDataFromFormFields()
        {
            Product product = new Product(TxbName.Text.Trim(), (int)NudNetPrice.Value, (int)CmbVatValue.SelectedValue, TxbManufacturer.Text.Trim(), TxbModel.Text.Trim(), (int)CmbCategoryId.SelectedValue, DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"));
            return product;
        }

        public void ResetFormFields()
        {
            TxbName.Text = string.Empty;
            TxbManufacturer.Text = string.Empty;
            TxbModel.Text = string.Empty;
            NudNetPrice.Value = 0;
            CmbCategoryId.SelectedIndex = 0;
            CmbVatValue.SelectedIndex = 0;
        }
    }
}
