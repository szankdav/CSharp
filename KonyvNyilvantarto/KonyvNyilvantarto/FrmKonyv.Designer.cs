namespace KonyvNyilvantarto
{
    partial class FrmKonyv
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.GrbKonyvAdatok = new System.Windows.Forms.GroupBox();
            this.TxbSorszam = new System.Windows.Forms.TextBox();
            this.CmbMufaj = new System.Windows.Forms.ComboBox();
            this.TxbSzerzo = new System.Windows.Forms.TextBox();
            this.TxbCim = new System.Windows.Forms.TextBox();
            this.LblSorszam = new System.Windows.Forms.Label();
            this.LblMufaj = new System.Windows.Forms.Label();
            this.LblSzerzo = new System.Windows.Forms.Label();
            this.LblCim = new System.Windows.Forms.Label();
            this.GrbKonyvAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(13, 165);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(170, 30);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(202, 165);
            this.BtnMegsem.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(170, 30);
            this.BtnMegsem.TabIndex = 1;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // GrbKonyvAdatok
            // 
            this.GrbKonyvAdatok.Controls.Add(this.TxbSorszam);
            this.GrbKonyvAdatok.Controls.Add(this.CmbMufaj);
            this.GrbKonyvAdatok.Controls.Add(this.TxbSzerzo);
            this.GrbKonyvAdatok.Controls.Add(this.TxbCim);
            this.GrbKonyvAdatok.Controls.Add(this.LblSorszam);
            this.GrbKonyvAdatok.Controls.Add(this.LblMufaj);
            this.GrbKonyvAdatok.Controls.Add(this.LblSzerzo);
            this.GrbKonyvAdatok.Controls.Add(this.LblCim);
            this.GrbKonyvAdatok.Location = new System.Drawing.Point(13, 13);
            this.GrbKonyvAdatok.Margin = new System.Windows.Forms.Padding(4);
            this.GrbKonyvAdatok.Name = "GrbKonyvAdatok";
            this.GrbKonyvAdatok.Padding = new System.Windows.Forms.Padding(4);
            this.GrbKonyvAdatok.Size = new System.Drawing.Size(359, 144);
            this.GrbKonyvAdatok.TabIndex = 2;
            this.GrbKonyvAdatok.TabStop = false;
            this.GrbKonyvAdatok.Text = "Könyv adatai";
            // 
            // TxbSorszam
            // 
            this.TxbSorszam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSorszam.Location = new System.Drawing.Point(149, 111);
            this.TxbSorszam.Margin = new System.Windows.Forms.Padding(4);
            this.TxbSorszam.Name = "TxbSorszam";
            this.TxbSorszam.ReadOnly = true;
            this.TxbSorszam.Size = new System.Drawing.Size(200, 22);
            this.TxbSorszam.TabIndex = 7;
            // 
            // CmbMufaj
            // 
            this.CmbMufaj.FormattingEnabled = true;
            this.CmbMufaj.Location = new System.Drawing.Point(149, 79);
            this.CmbMufaj.Margin = new System.Windows.Forms.Padding(4);
            this.CmbMufaj.Name = "CmbMufaj";
            this.CmbMufaj.Size = new System.Drawing.Size(200, 24);
            this.CmbMufaj.TabIndex = 6;
            // 
            // TxbSzerzo
            // 
            this.TxbSzerzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSzerzo.Location = new System.Drawing.Point(149, 49);
            this.TxbSzerzo.Margin = new System.Windows.Forms.Padding(4);
            this.TxbSzerzo.Name = "TxbSzerzo";
            this.TxbSzerzo.Size = new System.Drawing.Size(200, 22);
            this.TxbSzerzo.TabIndex = 5;
            // 
            // TxbCim
            // 
            this.TxbCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbCim.Location = new System.Drawing.Point(149, 19);
            this.TxbCim.Margin = new System.Windows.Forms.Padding(4);
            this.TxbCim.Name = "TxbCim";
            this.TxbCim.Size = new System.Drawing.Size(200, 22);
            this.TxbCim.TabIndex = 4;
            // 
            // LblSorszam
            // 
            this.LblSorszam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSorszam.Location = new System.Drawing.Point(8, 111);
            this.LblSorszam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSorszam.Name = "LblSorszam";
            this.LblSorszam.Size = new System.Drawing.Size(133, 22);
            this.LblSorszam.TabIndex = 3;
            this.LblSorszam.Text = "Sorszám";
            this.LblSorszam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMufaj
            // 
            this.LblMufaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMufaj.Location = new System.Drawing.Point(8, 79);
            this.LblMufaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMufaj.Name = "LblMufaj";
            this.LblMufaj.Size = new System.Drawing.Size(133, 24);
            this.LblMufaj.TabIndex = 2;
            this.LblMufaj.Text = "Műfaj";
            this.LblMufaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSzerzo
            // 
            this.LblSzerzo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzerzo.Location = new System.Drawing.Point(8, 49);
            this.LblSzerzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSzerzo.Name = "LblSzerzo";
            this.LblSzerzo.Size = new System.Drawing.Size(133, 22);
            this.LblSzerzo.TabIndex = 1;
            this.LblSzerzo.Text = "Szerző";
            this.LblSzerzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCim
            // 
            this.LblCim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCim.Location = new System.Drawing.Point(8, 19);
            this.LblCim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCim.Name = "LblCim";
            this.LblCim.Size = new System.Drawing.Size(133, 22);
            this.LblCim.TabIndex = 0;
            this.LblCim.Text = "Cím";
            this.LblCim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmKonyv
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(385, 208);
            this.Controls.Add(this.GrbKonyvAdatok);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKonyv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GrbKonyvAdatok.ResumeLayout(false);
            this.GrbKonyvAdatok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.GroupBox GrbKonyvAdatok;
        private System.Windows.Forms.Label LblSorszam;
        private System.Windows.Forms.Label LblMufaj;
        private System.Windows.Forms.Label LblSzerzo;
        private System.Windows.Forms.Label LblCim;
        private System.Windows.Forms.TextBox TxbSorszam;
        private System.Windows.Forms.ComboBox CmbMufaj;
        private System.Windows.Forms.TextBox TxbSzerzo;
        private System.Windows.Forms.TextBox TxbCim;
    }
}