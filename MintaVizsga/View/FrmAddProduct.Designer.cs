namespace MintaVizsga.View
{
    partial class FrmAddProduct
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
            this.TxbName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNetPrice = new System.Windows.Forms.Label();
            this.CmbVatValue = new System.Windows.Forms.ComboBox();
            this.NudNetPrice = new System.Windows.Forms.NumericUpDown();
            this.LblVatValue = new System.Windows.Forms.Label();
            this.LblManufacturer = new System.Windows.Forms.Label();
            this.TxbManufacturer = new System.Windows.Forms.TextBox();
            this.TxbModel = new System.Windows.Forms.TextBox();
            this.CmbCategoryId = new System.Windows.Forms.ComboBox();
            this.LblModel = new System.Windows.Forms.Label();
            this.LblCategoryValue = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudNetPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(168, 9);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(199, 22);
            this.TxbName.TabIndex = 0;
            // 
            // LblName
            // 
            this.LblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblName.Location = new System.Drawing.Point(12, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(150, 22);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name";
            // 
            // LblNetPrice
            // 
            this.LblNetPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNetPrice.Location = new System.Drawing.Point(12, 37);
            this.LblNetPrice.Name = "LblNetPrice";
            this.LblNetPrice.Size = new System.Drawing.Size(150, 22);
            this.LblNetPrice.TabIndex = 2;
            this.LblNetPrice.Text = "Net Price";
            // 
            // CmbVatValue
            // 
            this.CmbVatValue.FormattingEnabled = true;
            this.CmbVatValue.Location = new System.Drawing.Point(168, 65);
            this.CmbVatValue.Name = "CmbVatValue";
            this.CmbVatValue.Size = new System.Drawing.Size(199, 24);
            this.CmbVatValue.TabIndex = 3;
            // 
            // NudNetPrice
            // 
            this.NudNetPrice.Location = new System.Drawing.Point(168, 37);
            this.NudNetPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudNetPrice.Name = "NudNetPrice";
            this.NudNetPrice.Size = new System.Drawing.Size(199, 22);
            this.NudNetPrice.TabIndex = 4;
            // 
            // LblVatValue
            // 
            this.LblVatValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVatValue.Location = new System.Drawing.Point(12, 65);
            this.LblVatValue.Name = "LblVatValue";
            this.LblVatValue.Size = new System.Drawing.Size(150, 24);
            this.LblVatValue.TabIndex = 5;
            this.LblVatValue.Text = "Vat amount";
            // 
            // LblManufacturer
            // 
            this.LblManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblManufacturer.Location = new System.Drawing.Point(12, 95);
            this.LblManufacturer.Name = "LblManufacturer";
            this.LblManufacturer.Size = new System.Drawing.Size(150, 22);
            this.LblManufacturer.TabIndex = 6;
            this.LblManufacturer.Text = "Manufacturer";
            // 
            // TxbManufacturer
            // 
            this.TxbManufacturer.Location = new System.Drawing.Point(168, 95);
            this.TxbManufacturer.Name = "TxbManufacturer";
            this.TxbManufacturer.Size = new System.Drawing.Size(199, 22);
            this.TxbManufacturer.TabIndex = 7;
            // 
            // TxbModel
            // 
            this.TxbModel.Location = new System.Drawing.Point(168, 123);
            this.TxbModel.Name = "TxbModel";
            this.TxbModel.Size = new System.Drawing.Size(199, 22);
            this.TxbModel.TabIndex = 8;
            // 
            // CmbCategoryId
            // 
            this.CmbCategoryId.FormattingEnabled = true;
            this.CmbCategoryId.Location = new System.Drawing.Point(168, 151);
            this.CmbCategoryId.Name = "CmbCategoryId";
            this.CmbCategoryId.Size = new System.Drawing.Size(199, 24);
            this.CmbCategoryId.TabIndex = 9;
            // 
            // LblModel
            // 
            this.LblModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblModel.Location = new System.Drawing.Point(12, 123);
            this.LblModel.Name = "LblModel";
            this.LblModel.Size = new System.Drawing.Size(150, 22);
            this.LblModel.TabIndex = 10;
            this.LblModel.Text = "Model";
            // 
            // LblCategoryValue
            // 
            this.LblCategoryValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCategoryValue.Location = new System.Drawing.Point(12, 151);
            this.LblCategoryValue.Name = "LblCategoryValue";
            this.LblCategoryValue.Size = new System.Drawing.Size(150, 24);
            this.LblCategoryValue.TabIndex = 11;
            this.LblCategoryValue.Text = "Category";
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(12, 191);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(150, 25);
            this.BtnOK.TabIndex = 12;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(217, 191);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 25);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAddProduct
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(379, 228);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblCategoryValue);
            this.Controls.Add(this.LblModel);
            this.Controls.Add(this.CmbCategoryId);
            this.Controls.Add(this.TxbModel);
            this.Controls.Add(this.TxbManufacturer);
            this.Controls.Add(this.LblManufacturer);
            this.Controls.Add(this.LblVatValue);
            this.Controls.Add(this.NudNetPrice);
            this.Controls.Add(this.CmbVatValue);
            this.Controls.Add(this.LblNetPrice);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxbName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add product";
            ((System.ComponentModel.ISupportInitialize)(this.NudNetPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNetPrice;
        private System.Windows.Forms.ComboBox CmbVatValue;
        private System.Windows.Forms.NumericUpDown NudNetPrice;
        private System.Windows.Forms.Label LblVatValue;
        private System.Windows.Forms.Label LblManufacturer;
        private System.Windows.Forms.TextBox TxbManufacturer;
        private System.Windows.Forms.TextBox TxbModel;
        private System.Windows.Forms.ComboBox CmbCategoryId;
        private System.Windows.Forms.Label LblModel;
        private System.Windows.Forms.Label LblCategoryValue;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}