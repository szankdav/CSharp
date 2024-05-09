namespace VizsgaMgr
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
            this.GrbVizsga = new System.Windows.Forms.GroupBox();
            this.NudVizsgaOsszpontszama = new System.Windows.Forms.NumericUpDown();
            this.TxbVizsgaMegnevezese = new System.Windows.Forms.TextBox();
            this.LblVizsgaOsszpontszama = new System.Windows.Forms.Label();
            this.LblVizsgaMegnevezese = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.GrbVizsga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudVizsgaOsszpontszama)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbVizsga
            // 
            this.GrbVizsga.Controls.Add(this.NudVizsgaOsszpontszama);
            this.GrbVizsga.Controls.Add(this.TxbVizsgaMegnevezese);
            this.GrbVizsga.Controls.Add(this.LblVizsgaOsszpontszama);
            this.GrbVizsga.Controls.Add(this.LblVizsgaMegnevezese);
            this.GrbVizsga.Location = new System.Drawing.Point(12, 12);
            this.GrbVizsga.Name = "GrbVizsga";
            this.GrbVizsga.Size = new System.Drawing.Size(368, 77);
            this.GrbVizsga.TabIndex = 0;
            this.GrbVizsga.TabStop = false;
            this.GrbVizsga.Text = "Vizsga";
            // 
            // NudVizsgaOsszpontszama
            // 
            this.NudVizsgaOsszpontszama.Location = new System.Drawing.Point(162, 49);
            this.NudVizsgaOsszpontszama.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudVizsgaOsszpontszama.Name = "NudVizsgaOsszpontszama";
            this.NudVizsgaOsszpontszama.Size = new System.Drawing.Size(200, 22);
            this.NudVizsgaOsszpontszama.TabIndex = 3;
            this.NudVizsgaOsszpontszama.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // TxbVizsgaMegnevezese
            // 
            this.TxbVizsgaMegnevezese.Location = new System.Drawing.Point(162, 21);
            this.TxbVizsgaMegnevezese.MaxLength = 20;
            this.TxbVizsgaMegnevezese.Name = "TxbVizsgaMegnevezese";
            this.TxbVizsgaMegnevezese.Size = new System.Drawing.Size(200, 22);
            this.TxbVizsgaMegnevezese.TabIndex = 2;
            // 
            // LblVizsgaOsszpontszama
            // 
            this.LblVizsgaOsszpontszama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVizsgaOsszpontszama.Location = new System.Drawing.Point(6, 49);
            this.LblVizsgaOsszpontszama.Name = "LblVizsgaOsszpontszama";
            this.LblVizsgaOsszpontszama.Size = new System.Drawing.Size(150, 22);
            this.LblVizsgaOsszpontszama.TabIndex = 1;
            this.LblVizsgaOsszpontszama.Text = "Vizsga összpontszáma";
            this.LblVizsgaOsszpontszama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblVizsgaMegnevezese
            // 
            this.LblVizsgaMegnevezese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVizsgaMegnevezese.Location = new System.Drawing.Point(6, 21);
            this.LblVizsgaMegnevezese.Name = "LblVizsgaMegnevezese";
            this.LblVizsgaMegnevezese.Size = new System.Drawing.Size(150, 22);
            this.LblVizsgaMegnevezese.TabIndex = 0;
            this.LblVizsgaMegnevezese.Text = "Vizsga megnevezése";
            this.LblVizsgaMegnevezese.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(174, 95);
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
            this.BtnMegsem.Location = new System.Drawing.Point(280, 95);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(100, 30);
            this.BtnMegsem.TabIndex = 2;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmVizsga
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(392, 137);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrbVizsga);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVizsga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizsga kezelése";
            this.GrbVizsga.ResumeLayout(false);
            this.GrbVizsga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudVizsgaOsszpontszama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbVizsga;
        private System.Windows.Forms.NumericUpDown NudVizsgaOsszpontszama;
        private System.Windows.Forms.TextBox TxbVizsgaMegnevezese;
        private System.Windows.Forms.Label LblVizsgaOsszpontszama;
        private System.Windows.Forms.Label LblVizsgaMegnevezese;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
    }
}