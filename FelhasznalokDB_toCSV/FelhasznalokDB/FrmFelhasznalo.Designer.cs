namespace FelhasznalokDB
{
    partial class FrmFelhasznalo
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
            this.GrbAdatok = new System.Windows.Forms.GroupBox();
            this.DtpRegIdo = new System.Windows.Forms.DateTimePicker();
            this.TxbJelszo = new System.Windows.Forms.TextBox();
            this.TxbFelhasznalonev = new System.Windows.Forms.TextBox();
            this.TxbUid = new System.Windows.Forms.TextBox();
            this.LblRegisztraciosIdo = new System.Windows.Forms.Label();
            this.LblFelhasznaloJelszo = new System.Windows.Forms.Label();
            this.LblFelhasznalonev = new System.Windows.Forms.Label();
            this.LblUid = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.GrbAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbAdatok
            // 
            this.GrbAdatok.Controls.Add(this.BtnMegsem);
            this.GrbAdatok.Controls.Add(this.BtnOk);
            this.GrbAdatok.Controls.Add(this.DtpRegIdo);
            this.GrbAdatok.Controls.Add(this.TxbJelszo);
            this.GrbAdatok.Controls.Add(this.TxbFelhasznalonev);
            this.GrbAdatok.Controls.Add(this.TxbUid);
            this.GrbAdatok.Controls.Add(this.LblRegisztraciosIdo);
            this.GrbAdatok.Controls.Add(this.LblFelhasznaloJelszo);
            this.GrbAdatok.Controls.Add(this.LblFelhasznalonev);
            this.GrbAdatok.Controls.Add(this.LblUid);
            this.GrbAdatok.Location = new System.Drawing.Point(13, 13);
            this.GrbAdatok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrbAdatok.Name = "GrbAdatok";
            this.GrbAdatok.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrbAdatok.Size = new System.Drawing.Size(366, 177);
            this.GrbAdatok.TabIndex = 0;
            this.GrbAdatok.TabStop = false;
            this.GrbAdatok.Text = "Adatok";
            // 
            // DtpRegIdo
            // 
            this.DtpRegIdo.Location = new System.Drawing.Point(139, 109);
            this.DtpRegIdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpRegIdo.Name = "DtpRegIdo";
            this.DtpRegIdo.Size = new System.Drawing.Size(219, 22);
            this.DtpRegIdo.TabIndex = 7;
            // 
            // TxbJelszo
            // 
            this.TxbJelszo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbJelszo.Location = new System.Drawing.Point(139, 79);
            this.TxbJelszo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbJelszo.MaxLength = 20;
            this.TxbJelszo.Name = "TxbJelszo";
            this.TxbJelszo.Size = new System.Drawing.Size(219, 22);
            this.TxbJelszo.TabIndex = 6;
            // 
            // TxbFelhasznalonev
            // 
            this.TxbFelhasznalonev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbFelhasznalonev.Location = new System.Drawing.Point(139, 49);
            this.TxbFelhasznalonev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbFelhasznalonev.MaxLength = 150;
            this.TxbFelhasznalonev.Name = "TxbFelhasznalonev";
            this.TxbFelhasznalonev.Size = new System.Drawing.Size(219, 22);
            this.TxbFelhasznalonev.TabIndex = 5;
            // 
            // TxbUid
            // 
            this.TxbUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbUid.Location = new System.Drawing.Point(139, 19);
            this.TxbUid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxbUid.Name = "TxbUid";
            this.TxbUid.ReadOnly = true;
            this.TxbUid.Size = new System.Drawing.Size(219, 22);
            this.TxbUid.TabIndex = 4;
            // 
            // LblRegisztraciosIdo
            // 
            this.LblRegisztraciosIdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRegisztraciosIdo.Location = new System.Drawing.Point(8, 109);
            this.LblRegisztraciosIdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisztraciosIdo.Name = "LblRegisztraciosIdo";
            this.LblRegisztraciosIdo.Size = new System.Drawing.Size(123, 22);
            this.LblRegisztraciosIdo.TabIndex = 3;
            this.LblRegisztraciosIdo.Text = "Regisztracios Ido";
            this.LblRegisztraciosIdo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFelhasznaloJelszo
            // 
            this.LblFelhasznaloJelszo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFelhasznaloJelszo.Location = new System.Drawing.Point(8, 79);
            this.LblFelhasznaloJelszo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFelhasznaloJelszo.Name = "LblFelhasznaloJelszo";
            this.LblFelhasznaloJelszo.Size = new System.Drawing.Size(123, 22);
            this.LblFelhasznaloJelszo.TabIndex = 2;
            this.LblFelhasznaloJelszo.Text = "Jelszo";
            this.LblFelhasznaloJelszo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFelhasznalonev
            // 
            this.LblFelhasznalonev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFelhasznalonev.Location = new System.Drawing.Point(8, 49);
            this.LblFelhasznalonev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFelhasznalonev.Name = "LblFelhasznalonev";
            this.LblFelhasznalonev.Size = new System.Drawing.Size(123, 22);
            this.LblFelhasznalonev.TabIndex = 1;
            this.LblFelhasznalonev.Text = "Felhasznalonev";
            this.LblFelhasznalonev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblUid
            // 
            this.LblUid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblUid.Location = new System.Drawing.Point(8, 19);
            this.LblUid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(123, 22);
            this.LblUid.TabIndex = 0;
            this.LblUid.Text = "UID";
            this.LblUid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(139, 138);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(106, 32);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(253, 138);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(106, 32);
            this.BtnMegsem.TabIndex = 9;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmFelhasznalo
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(392, 203);
            this.Controls.Add(this.GrbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFelhasznalo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felhasznalo kezelese";
            this.Load += new System.EventHandler(this.FrmFelhasznalo_Load);
            this.GrbAdatok.ResumeLayout(false);
            this.GrbAdatok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbAdatok;
        private System.Windows.Forms.DateTimePicker DtpRegIdo;
        private System.Windows.Forms.TextBox TxbJelszo;
        private System.Windows.Forms.TextBox TxbFelhasznalonev;
        private System.Windows.Forms.TextBox TxbUid;
        private System.Windows.Forms.Label LblRegisztraciosIdo;
        private System.Windows.Forms.Label LblFelhasznaloJelszo;
        private System.Windows.Forms.Label LblFelhasznalonev;
        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.Button BtnOk;
    }
}