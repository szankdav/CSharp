namespace TermekekAdminDLL
{
    partial class FrmTermek
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
            this.LblGyarto = new System.Windows.Forms.Label();
            this.LblMegnevezes = new System.Windows.Forms.Label();
            this.LblAr = new System.Windows.Forms.Label();
            this.LblDarabSzam = new System.Windows.Forms.Label();
            this.LblTipus = new System.Windows.Forms.Label();
            this.TxbGyarto = new System.Windows.Forms.TextBox();
            this.TxbMegnevezes = new System.Windows.Forms.TextBox();
            this.NudAr = new System.Windows.Forms.NumericUpDown();
            this.NudDarabSzam = new System.Windows.Forms.NumericUpDown();
            this.CmbTipus = new System.Windows.Forms.ComboBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDarabSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGyarto
            // 
            this.LblGyarto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblGyarto.Location = new System.Drawing.Point(12, 9);
            this.LblGyarto.Name = "LblGyarto";
            this.LblGyarto.Size = new System.Drawing.Size(100, 20);
            this.LblGyarto.TabIndex = 0;
            this.LblGyarto.Text = "Gyarto";
            this.LblGyarto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMegnevezes
            // 
            this.LblMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMegnevezes.Location = new System.Drawing.Point(12, 35);
            this.LblMegnevezes.Name = "LblMegnevezes";
            this.LblMegnevezes.Size = new System.Drawing.Size(100, 20);
            this.LblMegnevezes.TabIndex = 1;
            this.LblMegnevezes.Text = "Megnevezes";
            this.LblMegnevezes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAr
            // 
            this.LblAr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAr.Location = new System.Drawing.Point(12, 61);
            this.LblAr.Name = "LblAr";
            this.LblAr.Size = new System.Drawing.Size(100, 20);
            this.LblAr.TabIndex = 2;
            this.LblAr.Text = "Ar";
            this.LblAr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDarabSzam
            // 
            this.LblDarabSzam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDarabSzam.Location = new System.Drawing.Point(12, 87);
            this.LblDarabSzam.Name = "LblDarabSzam";
            this.LblDarabSzam.Size = new System.Drawing.Size(100, 20);
            this.LblDarabSzam.TabIndex = 3;
            this.LblDarabSzam.Text = "Darabszam";
            this.LblDarabSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTipus
            // 
            this.LblTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTipus.Location = new System.Drawing.Point(12, 113);
            this.LblTipus.Name = "LblTipus";
            this.LblTipus.Size = new System.Drawing.Size(100, 21);
            this.LblTipus.TabIndex = 4;
            this.LblTipus.Text = "Tipus";
            this.LblTipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbGyarto
            // 
            this.TxbGyarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbGyarto.Location = new System.Drawing.Point(118, 9);
            this.TxbGyarto.MaxLength = 50;
            this.TxbGyarto.Name = "TxbGyarto";
            this.TxbGyarto.Size = new System.Drawing.Size(200, 20);
            this.TxbGyarto.TabIndex = 5;
            // 
            // TxbMegnevezes
            // 
            this.TxbMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbMegnevezes.Location = new System.Drawing.Point(118, 35);
            this.TxbMegnevezes.MaxLength = 50;
            this.TxbMegnevezes.Name = "TxbMegnevezes";
            this.TxbMegnevezes.Size = new System.Drawing.Size(200, 20);
            this.TxbMegnevezes.TabIndex = 6;
            // 
            // NudAr
            // 
            this.NudAr.Location = new System.Drawing.Point(118, 61);
            this.NudAr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAr.Name = "NudAr";
            this.NudAr.Size = new System.Drawing.Size(200, 20);
            this.NudAr.TabIndex = 7;
            this.NudAr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudDarabSzam
            // 
            this.NudDarabSzam.Location = new System.Drawing.Point(118, 87);
            this.NudDarabSzam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDarabSzam.Name = "NudDarabSzam";
            this.NudDarabSzam.Size = new System.Drawing.Size(200, 20);
            this.NudDarabSzam.TabIndex = 8;
            this.NudDarabSzam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbTipus
            // 
            this.CmbTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipus.FormattingEnabled = true;
            this.CmbTipus.Location = new System.Drawing.Point(118, 113);
            this.CmbTipus.Name = "CmbTipus";
            this.CmbTipus.Size = new System.Drawing.Size(200, 21);
            this.CmbTipus.TabIndex = 9;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(112, 140);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 30);
            this.BtnOK.TabIndex = 10;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(218, 140);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(100, 30);
            this.BtnMegsem.TabIndex = 11;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmTermek
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(330, 179);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.CmbTipus);
            this.Controls.Add(this.NudDarabSzam);
            this.Controls.Add(this.NudAr);
            this.Controls.Add(this.TxbMegnevezes);
            this.Controls.Add(this.TxbGyarto);
            this.Controls.Add(this.LblTipus);
            this.Controls.Add(this.LblDarabSzam);
            this.Controls.Add(this.LblAr);
            this.Controls.Add(this.LblMegnevezes);
            this.Controls.Add(this.LblGyarto);
            this.Name = "FrmTermek";
            this.Text = "Termek letrehozasa";
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDarabSzam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGyarto;
        private System.Windows.Forms.Label LblMegnevezes;
        private System.Windows.Forms.Label LblAr;
        private System.Windows.Forms.Label LblDarabSzam;
        private System.Windows.Forms.Label LblTipus;
        private System.Windows.Forms.TextBox TxbGyarto;
        private System.Windows.Forms.TextBox TxbMegnevezes;
        private System.Windows.Forms.NumericUpDown NudAr;
        private System.Windows.Forms.NumericUpDown NudDarabSzam;
        private System.Windows.Forms.ComboBox CmbTipus;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
    }
}