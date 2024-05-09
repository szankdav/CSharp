namespace KonyvesBoltSajatEsemenyPelda
{
    partial class FrmKonyvMoly
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
            this.LblNev = new System.Windows.Forms.Label();
            this.LblVagyon = new System.Windows.Forms.Label();
            this.LblKedvencTipus = new System.Windows.Forms.Label();
            this.TxbNev = new System.Windows.Forms.TextBox();
            this.NudVagyon = new System.Windows.Forms.NumericUpDown();
            this.CmbKedvencTipus = new System.Windows.Forms.ComboBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudVagyon)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNev
            // 
            this.LblNev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNev.Location = new System.Drawing.Point(12, 9);
            this.LblNev.Name = "LblNev";
            this.LblNev.Size = new System.Drawing.Size(200, 22);
            this.LblNev.TabIndex = 0;
            this.LblNev.Text = "Nev";
            this.LblNev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblVagyon
            // 
            this.LblVagyon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVagyon.Location = new System.Drawing.Point(12, 37);
            this.LblVagyon.Name = "LblVagyon";
            this.LblVagyon.Size = new System.Drawing.Size(200, 22);
            this.LblVagyon.TabIndex = 1;
            this.LblVagyon.Text = "Vagyon";
            this.LblVagyon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblKedvencTipus
            // 
            this.LblKedvencTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblKedvencTipus.Location = new System.Drawing.Point(12, 65);
            this.LblKedvencTipus.Name = "LblKedvencTipus";
            this.LblKedvencTipus.Size = new System.Drawing.Size(200, 24);
            this.LblKedvencTipus.TabIndex = 2;
            this.LblKedvencTipus.Text = "Kedvenc tipus";
            this.LblKedvencTipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbNev
            // 
            this.TxbNev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbNev.Location = new System.Drawing.Point(218, 9);
            this.TxbNev.Name = "TxbNev";
            this.TxbNev.Size = new System.Drawing.Size(200, 22);
            this.TxbNev.TabIndex = 3;
            // 
            // NudVagyon
            // 
            this.NudVagyon.Location = new System.Drawing.Point(218, 37);
            this.NudVagyon.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NudVagyon.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NudVagyon.Name = "NudVagyon";
            this.NudVagyon.Size = new System.Drawing.Size(200, 22);
            this.NudVagyon.TabIndex = 4;
            this.NudVagyon.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // CmbKedvencTipus
            // 
            this.CmbKedvencTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKedvencTipus.FormattingEnabled = true;
            this.CmbKedvencTipus.Location = new System.Drawing.Point(218, 65);
            this.CmbKedvencTipus.Name = "CmbKedvencTipus";
            this.CmbKedvencTipus.Size = new System.Drawing.Size(200, 24);
            this.CmbKedvencTipus.TabIndex = 5;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(212, 95);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 30);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(318, 95);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(100, 30);
            this.BtnMegsem.TabIndex = 7;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmKonyvMoly
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(430, 140);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.CmbKedvencTipus);
            this.Controls.Add(this.NudVagyon);
            this.Controls.Add(this.TxbNev);
            this.Controls.Add(this.LblKedvencTipus);
            this.Controls.Add(this.LblVagyon);
            this.Controls.Add(this.LblNev);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKonyvMoly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konvymoly Letrehozasa";
            ((System.ComponentModel.ISupportInitialize)(this.NudVagyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNev;
        private System.Windows.Forms.Label LblVagyon;
        private System.Windows.Forms.Label LblKedvencTipus;
        private System.Windows.Forms.TextBox TxbNev;
        private System.Windows.Forms.NumericUpDown NudVagyon;
        private System.Windows.Forms.ComboBox CmbKedvencTipus;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
    }
}