namespace MintaVizsga
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgwProducts = new System.Windows.Forms.DataGridView();
            this.BtnNewProduct = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwProducts
            // 
            this.DgwProducts.AllowUserToAddRows = false;
            this.DgwProducts.AllowUserToDeleteRows = false;
            this.DgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProducts.Location = new System.Drawing.Point(16, 15);
            this.DgwProducts.Margin = new System.Windows.Forms.Padding(4);
            this.DgwProducts.Name = "DgwProducts";
            this.DgwProducts.ReadOnly = true;
            this.DgwProducts.Size = new System.Drawing.Size(1035, 185);
            this.DgwProducts.TabIndex = 0;
            // 
            // BtnNewProduct
            // 
            this.BtnNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnNewProduct.Location = new System.Drawing.Point(16, 207);
            this.BtnNewProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewProduct.Name = "BtnNewProduct";
            this.BtnNewProduct.Size = new System.Drawing.Size(200, 60);
            this.BtnNewProduct.TabIndex = 1;
            this.BtnNewProduct.Text = "New product";
            this.BtnNewProduct.UseVisualStyleBackColor = true;
            this.BtnNewProduct.Click += new System.EventHandler(this.BtnNewProduct_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnNewProduct);
            this.Controls.Add(this.DgwProducts);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product listing";
            ((System.ComponentModel.ISupportInitialize)(this.DgwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwProducts;
        private System.Windows.Forms.Button BtnNewProduct;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

