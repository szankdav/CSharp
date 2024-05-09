namespace Admin
{
    partial class FrmUjFelhasznalo
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
            this.LblAdminUjFelhasznalonev = new System.Windows.Forms.Label();
            this.LblAdminUjFelhasznaloJelszo = new System.Windows.Forms.Label();
            this.TxbAdminUjFelhasznalonev = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.TxbAdminUjFelhasznaloJelszo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblAdminUjFelhasznalonev
            // 
            this.LblAdminUjFelhasznalonev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAdminUjFelhasznalonev.Location = new System.Drawing.Point(12, 9);
            this.LblAdminUjFelhasznalonev.Name = "LblAdminUjFelhasznalonev";
            this.LblAdminUjFelhasznalonev.Size = new System.Drawing.Size(120, 22);
            this.LblAdminUjFelhasznalonev.TabIndex = 0;
            this.LblAdminUjFelhasznalonev.Text = "Felhasználónév";
            this.LblAdminUjFelhasznalonev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAdminUjFelhasznaloJelszo
            // 
            this.LblAdminUjFelhasznaloJelszo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAdminUjFelhasznaloJelszo.Location = new System.Drawing.Point(12, 37);
            this.LblAdminUjFelhasznaloJelszo.Name = "LblAdminUjFelhasznaloJelszo";
            this.LblAdminUjFelhasznaloJelszo.Size = new System.Drawing.Size(120, 22);
            this.LblAdminUjFelhasznaloJelszo.TabIndex = 1;
            this.LblAdminUjFelhasznaloJelszo.Text = "Jelszó";
            this.LblAdminUjFelhasznaloJelszo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbAdminUjFelhasznalonev
            // 
            this.TxbAdminUjFelhasznalonev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbAdminUjFelhasznalonev.Location = new System.Drawing.Point(138, 9);
            this.TxbAdminUjFelhasznalonev.Name = "TxbAdminUjFelhasznalonev";
            this.TxbAdminUjFelhasznalonev.Size = new System.Drawing.Size(100, 22);
            this.TxbAdminUjFelhasznalonev.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(12, 62);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(105, 30);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(133, 62);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(105, 30);
            this.BtnMegsem.TabIndex = 5;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // TxbAdminUjFelhasznaloJelszo
            // 
            this.TxbAdminUjFelhasznaloJelszo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbAdminUjFelhasznaloJelszo.Location = new System.Drawing.Point(138, 37);
            this.TxbAdminUjFelhasznaloJelszo.MaxLength = 4;
            this.TxbAdminUjFelhasznaloJelszo.Name = "TxbAdminUjFelhasznaloJelszo";
            this.TxbAdminUjFelhasznaloJelszo.Size = new System.Drawing.Size(100, 22);
            this.TxbAdminUjFelhasznaloJelszo.TabIndex = 6;
            // 
            // FrmUjFelhasznalo
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(250, 100);
            this.Controls.Add(this.TxbAdminUjFelhasznaloJelszo);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxbAdminUjFelhasznalonev);
            this.Controls.Add(this.LblAdminUjFelhasznaloJelszo);
            this.Controls.Add(this.LblAdminUjFelhasznalonev);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUjFelhasznalo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új felhasználó létrehozása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdminUjFelhasznalonev;
        private System.Windows.Forms.Label LblAdminUjFelhasznaloJelszo;
        private System.Windows.Forms.TextBox TxbAdminUjFelhasznalonev;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.TextBox TxbAdminUjFelhasznaloJelszo;
    }
}