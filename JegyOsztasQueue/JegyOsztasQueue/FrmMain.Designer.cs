namespace JegyOsztasQueue
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
            this.LsbAdatok = new System.Windows.Forms.ListBox();
            this.GrbFeladat = new System.Windows.Forms.GroupBox();
            this.BtnElvegezve = new System.Windows.Forms.Button();
            this.DtpHatarido = new System.Windows.Forms.DateTimePicker();
            this.TxbLeiras = new System.Windows.Forms.TextBox();
            this.TxbCim = new System.Windows.Forms.TextBox();
            this.LblHatarido = new System.Windows.Forms.Label();
            this.LblLeiras = new System.Windows.Forms.Label();
            this.LblCim = new System.Windows.Forms.Label();
            this.BtnUjFeladat = new System.Windows.Forms.Button();
            this.BtnKovetkezoFeladat = new System.Windows.Forms.Button();
            this.GrbFeladat.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsbAdatok
            // 
            this.LsbAdatok.FormattingEnabled = true;
            this.LsbAdatok.ItemHeight = 16;
            this.LsbAdatok.Location = new System.Drawing.Point(12, 12);
            this.LsbAdatok.Name = "LsbAdatok";
            this.LsbAdatok.Size = new System.Drawing.Size(277, 500);
            this.LsbAdatok.TabIndex = 0;
            // 
            // GrbFeladat
            // 
            this.GrbFeladat.Controls.Add(this.BtnElvegezve);
            this.GrbFeladat.Controls.Add(this.DtpHatarido);
            this.GrbFeladat.Controls.Add(this.TxbLeiras);
            this.GrbFeladat.Controls.Add(this.TxbCim);
            this.GrbFeladat.Controls.Add(this.LblHatarido);
            this.GrbFeladat.Controls.Add(this.LblLeiras);
            this.GrbFeladat.Controls.Add(this.LblCim);
            this.GrbFeladat.Location = new System.Drawing.Point(295, 12);
            this.GrbFeladat.Name = "GrbFeladat";
            this.GrbFeladat.Size = new System.Drawing.Size(277, 501);
            this.GrbFeladat.TabIndex = 1;
            this.GrbFeladat.TabStop = false;
            this.GrbFeladat.Text = "Feladat reszletei";
            // 
            // BtnElvegezve
            // 
            this.BtnElvegezve.Location = new System.Drawing.Point(6, 165);
            this.BtnElvegezve.Name = "BtnElvegezve";
            this.BtnElvegezve.Size = new System.Drawing.Size(265, 30);
            this.BtnElvegezve.TabIndex = 6;
            this.BtnElvegezve.Text = "Elvegezve";
            this.BtnElvegezve.UseVisualStyleBackColor = true;
            this.BtnElvegezve.Click += new System.EventHandler(this.BtnElvegezve_Click);
            // 
            // DtpHatarido
            // 
            this.DtpHatarido.Enabled = false;
            this.DtpHatarido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHatarido.Location = new System.Drawing.Point(87, 140);
            this.DtpHatarido.Name = "DtpHatarido";
            this.DtpHatarido.Size = new System.Drawing.Size(184, 22);
            this.DtpHatarido.TabIndex = 5;
            // 
            // TxbLeiras
            // 
            this.TxbLeiras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbLeiras.Location = new System.Drawing.Point(87, 46);
            this.TxbLeiras.Multiline = true;
            this.TxbLeiras.Name = "TxbLeiras";
            this.TxbLeiras.ReadOnly = true;
            this.TxbLeiras.Size = new System.Drawing.Size(184, 88);
            this.TxbLeiras.TabIndex = 4;
            // 
            // TxbCim
            // 
            this.TxbCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbCim.Location = new System.Drawing.Point(87, 18);
            this.TxbCim.Name = "TxbCim";
            this.TxbCim.ReadOnly = true;
            this.TxbCim.Size = new System.Drawing.Size(184, 22);
            this.TxbCim.TabIndex = 3;
            // 
            // LblHatarido
            // 
            this.LblHatarido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHatarido.Location = new System.Drawing.Point(6, 140);
            this.LblHatarido.Name = "LblHatarido";
            this.LblHatarido.Size = new System.Drawing.Size(75, 22);
            this.LblHatarido.TabIndex = 2;
            this.LblHatarido.Text = "Hatarido";
            this.LblHatarido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLeiras
            // 
            this.LblLeiras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLeiras.Location = new System.Drawing.Point(6, 46);
            this.LblLeiras.Name = "LblLeiras";
            this.LblLeiras.Size = new System.Drawing.Size(75, 88);
            this.LblLeiras.TabIndex = 1;
            this.LblLeiras.Text = "Leiras";
            // 
            // LblCim
            // 
            this.LblCim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCim.Location = new System.Drawing.Point(6, 18);
            this.LblCim.Name = "LblCim";
            this.LblCim.Size = new System.Drawing.Size(75, 22);
            this.LblCim.TabIndex = 0;
            this.LblCim.Text = "Cim";
            this.LblCim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnUjFeladat
            // 
            this.BtnUjFeladat.Location = new System.Drawing.Point(12, 519);
            this.BtnUjFeladat.Name = "BtnUjFeladat";
            this.BtnUjFeladat.Size = new System.Drawing.Size(277, 30);
            this.BtnUjFeladat.TabIndex = 2;
            this.BtnUjFeladat.Text = "Uj feladat";
            this.BtnUjFeladat.UseVisualStyleBackColor = true;
            this.BtnUjFeladat.Click += new System.EventHandler(this.BtnUjFeladat_Click);
            // 
            // BtnKovetkezoFeladat
            // 
            this.BtnKovetkezoFeladat.Location = new System.Drawing.Point(295, 519);
            this.BtnKovetkezoFeladat.Name = "BtnKovetkezoFeladat";
            this.BtnKovetkezoFeladat.Size = new System.Drawing.Size(277, 30);
            this.BtnKovetkezoFeladat.TabIndex = 3;
            this.BtnKovetkezoFeladat.Text = "Kovetkezo feladat betoltese";
            this.BtnKovetkezoFeladat.UseVisualStyleBackColor = true;
            this.BtnKovetkezoFeladat.Click += new System.EventHandler(this.BtnKovetkezoFeladat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.BtnKovetkezoFeladat);
            this.Controls.Add(this.BtnUjFeladat);
            this.Controls.Add(this.GrbFeladat);
            this.Controls.Add(this.LsbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jegyosztas Queue pelda";
            this.GrbFeladat.ResumeLayout(false);
            this.GrbFeladat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAdatok;
        private System.Windows.Forms.GroupBox GrbFeladat;
        private System.Windows.Forms.Button BtnUjFeladat;
        private System.Windows.Forms.Button BtnKovetkezoFeladat;
        private System.Windows.Forms.TextBox TxbCim;
        private System.Windows.Forms.Label LblHatarido;
        private System.Windows.Forms.Label LblLeiras;
        private System.Windows.Forms.Label LblCim;
        private System.Windows.Forms.DateTimePicker DtpHatarido;
        private System.Windows.Forms.TextBox TxbLeiras;
        private System.Windows.Forms.Button BtnElvegezve;
    }
}

