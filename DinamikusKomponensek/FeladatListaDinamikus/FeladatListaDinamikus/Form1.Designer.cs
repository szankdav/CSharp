namespace FeladatListaDinamikus
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
            this.GrbUjFeladat = new System.Windows.Forms.GroupBox();
            this.CmbFeladatPrioritasa = new System.Windows.Forms.ComboBox();
            this.DtpFeladatDatuma = new System.Windows.Forms.DateTimePicker();
            this.TxbFeladatLeirasa = new System.Windows.Forms.TextBox();
            this.TxbFeladatCime = new System.Windows.Forms.TextBox();
            this.LblFeladatPrioritasa = new System.Windows.Forms.Label();
            this.LblFeladatDatuma = new System.Windows.Forms.Label();
            this.LblFeladatLeirasa = new System.Windows.Forms.Label();
            this.LblFeladatCime = new System.Windows.Forms.Label();
            this.BtnFeladatLetrehozasa = new System.Windows.Forms.Button();
            this.GrbUjFeladat.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbUjFeladat
            // 
            this.GrbUjFeladat.Controls.Add(this.CmbFeladatPrioritasa);
            this.GrbUjFeladat.Controls.Add(this.DtpFeladatDatuma);
            this.GrbUjFeladat.Controls.Add(this.TxbFeladatLeirasa);
            this.GrbUjFeladat.Controls.Add(this.TxbFeladatCime);
            this.GrbUjFeladat.Controls.Add(this.LblFeladatPrioritasa);
            this.GrbUjFeladat.Controls.Add(this.LblFeladatDatuma);
            this.GrbUjFeladat.Controls.Add(this.LblFeladatLeirasa);
            this.GrbUjFeladat.Controls.Add(this.LblFeladatCime);
            this.GrbUjFeladat.Location = new System.Drawing.Point(12, 12);
            this.GrbUjFeladat.Name = "GrbUjFeladat";
            this.GrbUjFeladat.Size = new System.Drawing.Size(760, 201);
            this.GrbUjFeladat.TabIndex = 0;
            this.GrbUjFeladat.TabStop = false;
            this.GrbUjFeladat.Text = "Új feladat felvitele";
            // 
            // CmbFeladatPrioritasa
            // 
            this.CmbFeladatPrioritasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFeladatPrioritasa.FormattingEnabled = true;
            this.CmbFeladatPrioritasa.Location = new System.Drawing.Point(212, 171);
            this.CmbFeladatPrioritasa.Name = "CmbFeladatPrioritasa";
            this.CmbFeladatPrioritasa.Size = new System.Drawing.Size(542, 24);
            this.CmbFeladatPrioritasa.TabIndex = 7;
            // 
            // DtpFeladatDatuma
            // 
            this.DtpFeladatDatuma.CustomFormat = "yyyy-MM-dd";
            this.DtpFeladatDatuma.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFeladatDatuma.Location = new System.Drawing.Point(212, 143);
            this.DtpFeladatDatuma.Name = "DtpFeladatDatuma";
            this.DtpFeladatDatuma.Size = new System.Drawing.Size(542, 22);
            this.DtpFeladatDatuma.TabIndex = 6;
            // 
            // TxbFeladatLeirasa
            // 
            this.TxbFeladatLeirasa.Location = new System.Drawing.Point(212, 49);
            this.TxbFeladatLeirasa.MaxLength = 250;
            this.TxbFeladatLeirasa.Multiline = true;
            this.TxbFeladatLeirasa.Name = "TxbFeladatLeirasa";
            this.TxbFeladatLeirasa.Size = new System.Drawing.Size(542, 88);
            this.TxbFeladatLeirasa.TabIndex = 5;
            // 
            // TxbFeladatCime
            // 
            this.TxbFeladatCime.Location = new System.Drawing.Point(212, 21);
            this.TxbFeladatCime.MaxLength = 30;
            this.TxbFeladatCime.Name = "TxbFeladatCime";
            this.TxbFeladatCime.Size = new System.Drawing.Size(542, 22);
            this.TxbFeladatCime.TabIndex = 4;
            // 
            // LblFeladatPrioritasa
            // 
            this.LblFeladatPrioritasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladatPrioritasa.Location = new System.Drawing.Point(6, 171);
            this.LblFeladatPrioritasa.Name = "LblFeladatPrioritasa";
            this.LblFeladatPrioritasa.Size = new System.Drawing.Size(200, 24);
            this.LblFeladatPrioritasa.TabIndex = 3;
            this.LblFeladatPrioritasa.Text = "Feladat prioritása";
            this.LblFeladatPrioritasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFeladatDatuma
            // 
            this.LblFeladatDatuma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladatDatuma.Location = new System.Drawing.Point(6, 143);
            this.LblFeladatDatuma.Name = "LblFeladatDatuma";
            this.LblFeladatDatuma.Size = new System.Drawing.Size(200, 22);
            this.LblFeladatDatuma.TabIndex = 2;
            this.LblFeladatDatuma.Text = "Feladat dátuma";
            this.LblFeladatDatuma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFeladatLeirasa
            // 
            this.LblFeladatLeirasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladatLeirasa.Location = new System.Drawing.Point(6, 49);
            this.LblFeladatLeirasa.Name = "LblFeladatLeirasa";
            this.LblFeladatLeirasa.Size = new System.Drawing.Size(200, 22);
            this.LblFeladatLeirasa.TabIndex = 1;
            this.LblFeladatLeirasa.Text = "Feladat leírása";
            this.LblFeladatLeirasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFeladatCime
            // 
            this.LblFeladatCime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladatCime.Location = new System.Drawing.Point(6, 21);
            this.LblFeladatCime.Name = "LblFeladatCime";
            this.LblFeladatCime.Size = new System.Drawing.Size(200, 22);
            this.LblFeladatCime.TabIndex = 0;
            this.LblFeladatCime.Text = "Feladat címe";
            this.LblFeladatCime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnFeladatLetrehozasa
            // 
            this.BtnFeladatLetrehozasa.Location = new System.Drawing.Point(12, 219);
            this.BtnFeladatLetrehozasa.Name = "BtnFeladatLetrehozasa";
            this.BtnFeladatLetrehozasa.Size = new System.Drawing.Size(760, 30);
            this.BtnFeladatLetrehozasa.TabIndex = 1;
            this.BtnFeladatLetrehozasa.Text = "Feladat létrehozása";
            this.BtnFeladatLetrehozasa.UseVisualStyleBackColor = true;
            this.BtnFeladatLetrehozasa.Click += new System.EventHandler(this.BtnFeladatLetrehozasa_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnFeladatLetrehozasa);
            this.Controls.Add(this.GrbUjFeladat);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinamikus feladatlista példa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GrbUjFeladat.ResumeLayout(false);
            this.GrbUjFeladat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbUjFeladat;
        private System.Windows.Forms.Label LblFeladatPrioritasa;
        private System.Windows.Forms.Label LblFeladatDatuma;
        private System.Windows.Forms.Label LblFeladatLeirasa;
        private System.Windows.Forms.Label LblFeladatCime;
        private System.Windows.Forms.ComboBox CmbFeladatPrioritasa;
        private System.Windows.Forms.DateTimePicker DtpFeladatDatuma;
        private System.Windows.Forms.TextBox TxbFeladatLeirasa;
        private System.Windows.Forms.TextBox TxbFeladatCime;
        private System.Windows.Forms.Button BtnFeladatLetrehozasa;
    }
}

