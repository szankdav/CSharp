namespace Felhasznalo
{
    partial class FrmBejelentkezes
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
            this.TxbFelhasznaloBelepesiJelszo = new System.Windows.Forms.TextBox();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.LblFelhasznaloBelepesiJelszo = new System.Windows.Forms.Label();
            this.LblFehlasznaloFelhasznalonev = new System.Windows.Forms.Label();
            this.CmbFelhasznaloFelhasznaloLista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxbFelhasznaloBelepesiJelszo
            // 
            this.TxbFelhasznaloBelepesiJelszo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbFelhasznaloBelepesiJelszo.Location = new System.Drawing.Point(138, 37);
            this.TxbFelhasznaloBelepesiJelszo.MaxLength = 4;
            this.TxbFelhasznaloBelepesiJelszo.Name = "TxbFelhasznaloBelepesiJelszo";
            this.TxbFelhasznaloBelepesiJelszo.PasswordChar = '•';
            this.TxbFelhasznaloBelepesiJelszo.Size = new System.Drawing.Size(100, 22);
            this.TxbFelhasznaloBelepesiJelszo.TabIndex = 12;
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(133, 62);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(105, 30);
            this.BtnMegsem.TabIndex = 11;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(12, 62);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(105, 30);
            this.BtnOK.TabIndex = 10;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblFelhasznaloBelepesiJelszo
            // 
            this.LblFelhasznaloBelepesiJelszo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFelhasznaloBelepesiJelszo.Location = new System.Drawing.Point(12, 37);
            this.LblFelhasznaloBelepesiJelszo.Name = "LblFelhasznaloBelepesiJelszo";
            this.LblFelhasznaloBelepesiJelszo.Size = new System.Drawing.Size(120, 22);
            this.LblFelhasznaloBelepesiJelszo.TabIndex = 8;
            this.LblFelhasznaloBelepesiJelszo.Text = "Jelszó";
            this.LblFelhasznaloBelepesiJelszo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFehlasznaloFelhasznalonev
            // 
            this.LblFehlasznaloFelhasznalonev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFehlasznaloFelhasznalonev.Location = new System.Drawing.Point(12, 9);
            this.LblFehlasznaloFelhasznalonev.Name = "LblFehlasznaloFelhasznalonev";
            this.LblFehlasznaloFelhasznalonev.Size = new System.Drawing.Size(120, 22);
            this.LblFehlasznaloFelhasznalonev.TabIndex = 7;
            this.LblFehlasznaloFelhasznalonev.Text = "Felhasználónév";
            this.LblFehlasznaloFelhasznalonev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbFelhasznaloFelhasznaloLista
            // 
            this.CmbFelhasznaloFelhasznaloLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFelhasznaloFelhasznaloLista.FormattingEnabled = true;
            this.CmbFelhasznaloFelhasznaloLista.Location = new System.Drawing.Point(138, 9);
            this.CmbFelhasznaloFelhasznaloLista.Name = "CmbFelhasznaloFelhasznaloLista";
            this.CmbFelhasznaloFelhasznaloLista.Size = new System.Drawing.Size(100, 24);
            this.CmbFelhasznaloFelhasznaloLista.TabIndex = 13;
            // 
            // FrmBejelentkezes
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(252, 100);
            this.Controls.Add(this.CmbFelhasznaloFelhasznaloLista);
            this.Controls.Add(this.TxbFelhasznaloBelepesiJelszo);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblFelhasznaloBelepesiJelszo);
            this.Controls.Add(this.LblFehlasznaloFelhasznalonev);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezes";
            this.Load += new System.EventHandler(this.FrmBejelentkezes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbFelhasznaloBelepesiJelszo;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LblFelhasznaloBelepesiJelszo;
        private System.Windows.Forms.Label LblFehlasznaloFelhasznalonev;
        private System.Windows.Forms.ComboBox CmbFelhasznaloFelhasznaloLista;
    }
}