namespace MulticastDelegatePelda
{
    partial class FrmVizsga
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
            this.LblCim = new System.Windows.Forms.Label();
            this.LblFeladat = new System.Windows.Forms.Label();
            this.LblKep = new System.Windows.Forms.Label();
            this.TxbCim = new System.Windows.Forms.TextBox();
            this.TxbFeladat = new System.Windows.Forms.TextBox();
            this.TxbKep = new System.Windows.Forms.TextBox();
            this.BtnTallozas = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LblCim
            // 
            this.LblCim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCim.Location = new System.Drawing.Point(12, 12);
            this.LblCim.Name = "LblCim";
            this.LblCim.Size = new System.Drawing.Size(100, 22);
            this.LblCim.TabIndex = 0;
            this.LblCim.Text = "Cim";
            this.LblCim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFeladat
            // 
            this.LblFeladat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladat.Location = new System.Drawing.Point(12, 40);
            this.LblFeladat.Name = "LblFeladat";
            this.LblFeladat.Size = new System.Drawing.Size(100, 22);
            this.LblFeladat.TabIndex = 1;
            this.LblFeladat.Text = "Feladat";
            this.LblFeladat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblKep
            // 
            this.LblKep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblKep.Location = new System.Drawing.Point(12, 134);
            this.LblKep.Name = "LblKep";
            this.LblKep.Size = new System.Drawing.Size(100, 22);
            this.LblKep.TabIndex = 2;
            this.LblKep.Text = "Kep";
            this.LblKep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbCim
            // 
            this.TxbCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbCim.Location = new System.Drawing.Point(118, 12);
            this.TxbCim.Name = "TxbCim";
            this.TxbCim.Size = new System.Drawing.Size(281, 22);
            this.TxbCim.TabIndex = 3;
            // 
            // TxbFeladat
            // 
            this.TxbFeladat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbFeladat.Location = new System.Drawing.Point(118, 40);
            this.TxbFeladat.Multiline = true;
            this.TxbFeladat.Name = "TxbFeladat";
            this.TxbFeladat.Size = new System.Drawing.Size(281, 88);
            this.TxbFeladat.TabIndex = 4;
            // 
            // TxbKep
            // 
            this.TxbKep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbKep.Location = new System.Drawing.Point(118, 134);
            this.TxbKep.Name = "TxbKep";
            this.TxbKep.ReadOnly = true;
            this.TxbKep.Size = new System.Drawing.Size(200, 22);
            this.TxbKep.TabIndex = 5;
            // 
            // BtnTallozas
            // 
            this.BtnTallozas.Location = new System.Drawing.Point(324, 133);
            this.BtnTallozas.Name = "BtnTallozas";
            this.BtnTallozas.Size = new System.Drawing.Size(75, 23);
            this.BtnTallozas.TabIndex = 6;
            this.BtnTallozas.Text = "Tallozas";
            this.BtnTallozas.UseVisualStyleBackColor = true;
            this.BtnTallozas.Click += new System.EventHandler(this.BtnTallozas_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(193, 162);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 30);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(299, 162);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(100, 30);
            this.BtnMegsem.TabIndex = 8;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmVizsga
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(411, 204);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnTallozas);
            this.Controls.Add(this.TxbKep);
            this.Controls.Add(this.TxbFeladat);
            this.Controls.Add(this.TxbCim);
            this.Controls.Add(this.LblKep);
            this.Controls.Add(this.LblFeladat);
            this.Controls.Add(this.LblCim);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVizsga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizsga letrehozasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCim;
        private System.Windows.Forms.Label LblFeladat;
        private System.Windows.Forms.Label LblKep;
        private System.Windows.Forms.TextBox TxbCim;
        private System.Windows.Forms.TextBox TxbFeladat;
        private System.Windows.Forms.TextBox TxbKep;
        private System.Windows.Forms.Button BtnTallozas;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}