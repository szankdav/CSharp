namespace VizsgaMgr
{
    partial class FrmFeladat
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
            this.GrbFeladat = new System.Windows.Forms.GroupBox();
            this.LblFeladatPontszama = new System.Windows.Forms.Label();
            this.LblFeladatLeirasa = new System.Windows.Forms.Label();
            this.NudFeladatPontszama = new System.Windows.Forms.NumericUpDown();
            this.TxbFeladatLeirasa = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.LblHatralevoKarakterekSzama = new System.Windows.Forms.Label();
            this.GrbFeladat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFeladatPontszama)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbFeladat
            // 
            this.GrbFeladat.Controls.Add(this.LblHatralevoKarakterekSzama);
            this.GrbFeladat.Controls.Add(this.LblFeladatPontszama);
            this.GrbFeladat.Controls.Add(this.LblFeladatLeirasa);
            this.GrbFeladat.Controls.Add(this.NudFeladatPontszama);
            this.GrbFeladat.Controls.Add(this.TxbFeladatLeirasa);
            this.GrbFeladat.Location = new System.Drawing.Point(12, 12);
            this.GrbFeladat.Name = "GrbFeladat";
            this.GrbFeladat.Size = new System.Drawing.Size(368, 165);
            this.GrbFeladat.TabIndex = 0;
            this.GrbFeladat.TabStop = false;
            this.GrbFeladat.Text = "Feladat";
            // 
            // LblFeladatPontszama
            // 
            this.LblFeladatPontszama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladatPontszama.Location = new System.Drawing.Point(6, 137);
            this.LblFeladatPontszama.Name = "LblFeladatPontszama";
            this.LblFeladatPontszama.Size = new System.Drawing.Size(150, 22);
            this.LblFeladatPontszama.TabIndex = 3;
            this.LblFeladatPontszama.Text = "Feladat pontszáma";
            this.LblFeladatPontszama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFeladatLeirasa
            // 
            this.LblFeladatLeirasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladatLeirasa.Location = new System.Drawing.Point(6, 21);
            this.LblFeladatLeirasa.Name = "LblFeladatLeirasa";
            this.LblFeladatLeirasa.Size = new System.Drawing.Size(150, 22);
            this.LblFeladatLeirasa.TabIndex = 2;
            this.LblFeladatLeirasa.Text = "Feladat leírása";
            this.LblFeladatLeirasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NudFeladatPontszama
            // 
            this.NudFeladatPontszama.Location = new System.Drawing.Point(162, 137);
            this.NudFeladatPontszama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudFeladatPontszama.Name = "NudFeladatPontszama";
            this.NudFeladatPontszama.Size = new System.Drawing.Size(200, 22);
            this.NudFeladatPontszama.TabIndex = 1;
            this.NudFeladatPontszama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxbFeladatLeirasa
            // 
            this.TxbFeladatLeirasa.Location = new System.Drawing.Point(162, 21);
            this.TxbFeladatLeirasa.MaxLength = 200;
            this.TxbFeladatLeirasa.Multiline = true;
            this.TxbFeladatLeirasa.Name = "TxbFeladatLeirasa";
            this.TxbFeladatLeirasa.Size = new System.Drawing.Size(200, 110);
            this.TxbFeladatLeirasa.TabIndex = 0;
            this.TxbFeladatLeirasa.TextChanged += new System.EventHandler(this.TxbFeladatLeirasa_TextChanged);
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(174, 183);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 30);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(280, 183);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(100, 30);
            this.BtnMegsem.TabIndex = 2;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // LblHatralevoKarakterekSzama
            // 
            this.LblHatralevoKarakterekSzama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHatralevoKarakterekSzama.Location = new System.Drawing.Point(7, 47);
            this.LblHatralevoKarakterekSzama.Name = "LblHatralevoKarakterekSzama";
            this.LblHatralevoKarakterekSzama.Size = new System.Drawing.Size(150, 35);
            this.LblHatralevoKarakterekSzama.TabIndex = 4;
            // 
            // FrmFeladat
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(392, 225);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrbFeladat);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFeladat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feladat kezelése";
            this.GrbFeladat.ResumeLayout(false);
            this.GrbFeladat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFeladatPontszama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbFeladat;
        private System.Windows.Forms.Label LblFeladatPontszama;
        private System.Windows.Forms.Label LblFeladatLeirasa;
        private System.Windows.Forms.NumericUpDown NudFeladatPontszama;
        private System.Windows.Forms.TextBox TxbFeladatLeirasa;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.Label LblHatralevoKarakterekSzama;
    }
}