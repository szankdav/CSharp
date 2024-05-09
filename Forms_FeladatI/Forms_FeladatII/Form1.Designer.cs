namespace Forms_FeladatII
{
    partial class Szamkitalalo
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
            this.TxtbTipp = new System.Windows.Forms.TextBox();
            this.LblInformacio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBTippek = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTipp = new System.Windows.Forms.Button();
            this.BtnUjJatek = new System.Windows.Forms.Button();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtbTipp
            // 
            this.TxtbTipp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtbTipp.Location = new System.Drawing.Point(225, 59);
            this.TxtbTipp.Name = "TxtbTipp";
            this.TxtbTipp.Size = new System.Drawing.Size(121, 20);
            this.TxtbTipp.TabIndex = 0;
            this.TxtbTipp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // LblInformacio
            // 
            this.LblInformacio.AutoSize = true;
            this.LblInformacio.Location = new System.Drawing.Point(149, 9);
            this.LblInformacio.Name = "LblInformacio";
            this.LblInformacio.Size = new System.Drawing.Size(0, 13);
            this.LblInformacio.TabIndex = 1;
            this.LblInformacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Felhasznalo tippje:";
            // 
            // LBTippek
            // 
            this.LBTippek.FormattingEnabled = true;
            this.LBTippek.Location = new System.Drawing.Point(39, 127);
            this.LBTippek.Name = "LBTippek";
            this.LBTippek.Size = new System.Drawing.Size(507, 199);
            this.LBTippek.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eddigi tippek:";
            // 
            // BtnTipp
            // 
            this.BtnTipp.Location = new System.Drawing.Point(225, 85);
            this.BtnTipp.Name = "BtnTipp";
            this.BtnTipp.Size = new System.Drawing.Size(121, 23);
            this.BtnTipp.TabIndex = 5;
            this.BtnTipp.Text = "TIPP!";
            this.BtnTipp.UseVisualStyleBackColor = true;
            this.BtnTipp.Click += new System.EventHandler(this.BtnTipp_Click);
            // 
            // BtnUjJatek
            // 
            this.BtnUjJatek.Location = new System.Drawing.Point(225, 335);
            this.BtnUjJatek.Name = "BtnUjJatek";
            this.BtnUjJatek.Size = new System.Drawing.Size(121, 23);
            this.BtnUjJatek.TabIndex = 6;
            this.BtnUjJatek.Text = "Uj jatek";
            this.BtnUjJatek.UseVisualStyleBackColor = true;
            this.BtnUjJatek.Click += new System.EventHandler(this.BtnUjJatek_Click);
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKilepes.Location = new System.Drawing.Point(244, 364);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(76, 23);
            this.BtnKilepes.TabIndex = 7;
            this.BtnKilepes.Text = "Kilepes";
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Location = new System.Drawing.Point(363, 59);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(114, 20);
            this.label.TabIndex = 8;
            // 
            // Szamkitalalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnKilepes;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.label);
            this.Controls.Add(this.BtnKilepes);
            this.Controls.Add(this.BtnUjJatek);
            this.Controls.Add(this.BtnTipp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBTippek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblInformacio);
            this.Controls.Add(this.TxtbTipp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Szamkitalalo";
            this.Text = "Szamkitalalo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbTipp;
        private System.Windows.Forms.Label LblInformacio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBTippek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTipp;
        private System.Windows.Forms.Button BtnUjJatek;
        private System.Windows.Forms.Button BtnKilepes;
        private System.Windows.Forms.Label label;
    }
}

