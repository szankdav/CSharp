namespace MulticastDelegatePelda
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
            this.BtnUjVizsga = new System.Windows.Forms.Button();
            this.BtnVizsgaTorles = new System.Windows.Forms.Button();
            this.BtnMentes = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // LsbAdatok
            // 
            this.LsbAdatok.FormattingEnabled = true;
            this.LsbAdatok.ItemHeight = 16;
            this.LsbAdatok.Location = new System.Drawing.Point(12, 12);
            this.LsbAdatok.Name = "LsbAdatok";
            this.LsbAdatok.Size = new System.Drawing.Size(300, 292);
            this.LsbAdatok.TabIndex = 0;
            // 
            // BtnUjVizsga
            // 
            this.BtnUjVizsga.Location = new System.Drawing.Point(318, 12);
            this.BtnUjVizsga.Name = "BtnUjVizsga";
            this.BtnUjVizsga.Size = new System.Drawing.Size(100, 30);
            this.BtnUjVizsga.TabIndex = 1;
            this.BtnUjVizsga.Text = "Uj vizsga";
            this.BtnUjVizsga.UseVisualStyleBackColor = true;
            this.BtnUjVizsga.Click += new System.EventHandler(this.BtnUjVizsga_Click);
            // 
            // BtnVizsgaTorles
            // 
            this.BtnVizsgaTorles.Location = new System.Drawing.Point(318, 48);
            this.BtnVizsgaTorles.Name = "BtnVizsgaTorles";
            this.BtnVizsgaTorles.Size = new System.Drawing.Size(100, 30);
            this.BtnVizsgaTorles.TabIndex = 2;
            this.BtnVizsgaTorles.Text = "Vizsga torles";
            this.BtnVizsgaTorles.UseVisualStyleBackColor = true;
            this.BtnVizsgaTorles.Click += new System.EventHandler(this.BtnVizsgaTorles_Click);
            // 
            // BtnMentes
            // 
            this.BtnMentes.Location = new System.Drawing.Point(318, 84);
            this.BtnMentes.Name = "BtnMentes";
            this.BtnMentes.Size = new System.Drawing.Size(100, 30);
            this.BtnMentes.TabIndex = 3;
            this.BtnMentes.Text = "Mentes";
            this.BtnMentes.UseVisualStyleBackColor = true;
            this.BtnMentes.Click += new System.EventHandler(this.BtnMentes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 316);
            this.Controls.Add(this.BtnMentes);
            this.Controls.Add(this.BtnVizsgaTorles);
            this.Controls.Add(this.BtnUjVizsga);
            this.Controls.Add(this.LsbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multicast Deelegate Pelda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAdatok;
        private System.Windows.Forms.Button BtnUjVizsga;
        private System.Windows.Forms.Button BtnVizsgaTorles;
        private System.Windows.Forms.Button BtnMentes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

