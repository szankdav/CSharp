namespace SzamrendszerAtvalto
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
            this.LblBejovoSzam = new System.Windows.Forms.Label();
            this.TxbBejovoSzam = new System.Windows.Forms.TextBox();
            this.CmbBejovoSzamSzamrendszere = new System.Windows.Forms.ComboBox();
            this.LblEredmenySzoveg = new System.Windows.Forms.Label();
            this.LblEredmeny = new System.Windows.Forms.Label();
            this.CmbKimenoSzamrendszer = new System.Windows.Forms.ComboBox();
            this.BtnValtas = new System.Windows.Forms.Button();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblBejovoSzam
            // 
            this.LblBejovoSzam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblBejovoSzam.Location = new System.Drawing.Point(13, 9);
            this.LblBejovoSzam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBejovoSzam.Name = "LblBejovoSzam";
            this.LblBejovoSzam.Size = new System.Drawing.Size(111, 24);
            this.LblBejovoSzam.TabIndex = 0;
            this.LblBejovoSzam.Text = "Átváltandó szám:";
            this.LblBejovoSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbBejovoSzam
            // 
            this.TxbBejovoSzam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbBejovoSzam.Location = new System.Drawing.Point(132, 9);
            this.TxbBejovoSzam.Margin = new System.Windows.Forms.Padding(4);
            this.TxbBejovoSzam.Name = "TxbBejovoSzam";
            this.TxbBejovoSzam.Size = new System.Drawing.Size(132, 22);
            this.TxbBejovoSzam.TabIndex = 1;
            this.TxbBejovoSzam.TextChanged += new System.EventHandler(this.TxbBejovoSzam_TextChanged);
            // 
            // CmbBejovoSzamSzamrendszere
            // 
            this.CmbBejovoSzamSzamrendszere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBejovoSzamSzamrendszere.FormattingEnabled = true;
            this.CmbBejovoSzamSzamrendszere.Location = new System.Drawing.Point(271, 9);
            this.CmbBejovoSzamSzamrendszere.Name = "CmbBejovoSzamSzamrendszere";
            this.CmbBejovoSzamSzamrendszere.Size = new System.Drawing.Size(121, 24);
            this.CmbBejovoSzamSzamrendszere.TabIndex = 2;
            this.CmbBejovoSzamSzamrendszere.SelectedIndexChanged += new System.EventHandler(this.CmbBejovoSzamSzamrendszere_SelectedIndexChanged);
            // 
            // LblEredmenySzoveg
            // 
            this.LblEredmenySzoveg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEredmenySzoveg.Location = new System.Drawing.Point(13, 35);
            this.LblEredmenySzoveg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEredmenySzoveg.Name = "LblEredmenySzoveg";
            this.LblEredmenySzoveg.Size = new System.Drawing.Size(111, 24);
            this.LblEredmenySzoveg.TabIndex = 3;
            this.LblEredmenySzoveg.Text = "Eredmény:";
            this.LblEredmenySzoveg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEredmeny
            // 
            this.LblEredmeny.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEredmeny.Location = new System.Drawing.Point(132, 35);
            this.LblEredmeny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEredmeny.Name = "LblEredmeny";
            this.LblEredmeny.Size = new System.Drawing.Size(132, 24);
            this.LblEredmeny.TabIndex = 4;
            this.LblEredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbKimenoSzamrendszer
            // 
            this.CmbKimenoSzamrendszer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKimenoSzamrendszer.FormattingEnabled = true;
            this.CmbKimenoSzamrendszer.Location = new System.Drawing.Point(271, 35);
            this.CmbKimenoSzamrendszer.Name = "CmbKimenoSzamrendszer";
            this.CmbKimenoSzamrendszer.Size = new System.Drawing.Size(121, 24);
            this.CmbKimenoSzamrendszer.TabIndex = 5;
            // 
            // BtnValtas
            // 
            this.BtnValtas.Location = new System.Drawing.Point(132, 62);
            this.BtnValtas.Name = "BtnValtas";
            this.BtnValtas.Size = new System.Drawing.Size(132, 30);
            this.BtnValtas.TabIndex = 6;
            this.BtnValtas.Text = "Váltás";
            this.BtnValtas.UseVisualStyleBackColor = true;
            this.BtnValtas.Click += new System.EventHandler(this.BtnValtas_Click);
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.Location = new System.Drawing.Point(317, 69);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(75, 23);
            this.BtnKilepes.TabIndex = 7;
            this.BtnKilepes.Text = "Kilépés";
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 98);
            this.Controls.Add(this.BtnKilepes);
            this.Controls.Add(this.BtnValtas);
            this.Controls.Add(this.CmbKimenoSzamrendszer);
            this.Controls.Add(this.LblEredmeny);
            this.Controls.Add(this.LblEredmenySzoveg);
            this.Controls.Add(this.CmbBejovoSzamSzamrendszere);
            this.Controls.Add(this.TxbBejovoSzam);
            this.Controls.Add(this.LblBejovoSzam);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Számrendszer átváltó";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBejovoSzam;
        private System.Windows.Forms.TextBox TxbBejovoSzam;
        private System.Windows.Forms.ComboBox CmbBejovoSzamSzamrendszere;
        private System.Windows.Forms.Label LblEredmenySzoveg;
        private System.Windows.Forms.Label LblEredmeny;
        private System.Windows.Forms.ComboBox CmbKimenoSzamrendszer;
        private System.Windows.Forms.Button BtnValtas;
        private System.Windows.Forms.Button BtnKilepes;
    }
}

