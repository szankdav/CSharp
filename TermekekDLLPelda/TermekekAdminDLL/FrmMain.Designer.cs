namespace TermekekAdminDLL
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
            this.BtnBeolvasas = new System.Windows.Forms.Button();
            this.BtnLetrehozas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbAdatok
            // 
            this.LsbAdatok.FormattingEnabled = true;
            this.LsbAdatok.Location = new System.Drawing.Point(12, 12);
            this.LsbAdatok.Name = "LsbAdatok";
            this.LsbAdatok.Size = new System.Drawing.Size(776, 394);
            this.LsbAdatok.TabIndex = 0;
            // 
            // BtnBeolvasas
            // 
            this.BtnBeolvasas.Location = new System.Drawing.Point(12, 408);
            this.BtnBeolvasas.Name = "BtnBeolvasas";
            this.BtnBeolvasas.Size = new System.Drawing.Size(100, 30);
            this.BtnBeolvasas.TabIndex = 1;
            this.BtnBeolvasas.Text = "Beolvasas";
            this.BtnBeolvasas.UseVisualStyleBackColor = true;
            this.BtnBeolvasas.Click += new System.EventHandler(this.BtnBeolvasas_Click);
            // 
            // BtnLetrehozas
            // 
            this.BtnLetrehozas.Location = new System.Drawing.Point(118, 408);
            this.BtnLetrehozas.Name = "BtnLetrehozas";
            this.BtnLetrehozas.Size = new System.Drawing.Size(100, 30);
            this.BtnLetrehozas.TabIndex = 2;
            this.BtnLetrehozas.Text = "Letrehozas";
            this.BtnLetrehozas.UseVisualStyleBackColor = true;
            this.BtnLetrehozas.Click += new System.EventHandler(this.BtnLetrehozas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLetrehozas);
            this.Controls.Add(this.BtnBeolvasas);
            this.Controls.Add(this.LsbAdatok);
            this.Name = "FrmMain";
            this.Text = "Termekek Admin DLL Pelda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAdatok;
        private System.Windows.Forms.Button BtnBeolvasas;
        private System.Windows.Forms.Button BtnLetrehozas;
    }
}

