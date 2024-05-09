namespace MemóriaJáték
{
    partial class FrmIndulasiKepernyo
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
            this.LblProgramNev = new System.Windows.Forms.Label();
            this.BtnUjJatek = new System.Windows.Forms.Button();
            this.BtnEredmenyek = new System.Windows.Forms.Button();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblProgramNev
            // 
            this.LblProgramNev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblProgramNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblProgramNev.Location = new System.Drawing.Point(12, 9);
            this.LblProgramNev.Name = "LblProgramNev";
            this.LblProgramNev.Size = new System.Drawing.Size(450, 36);
            this.LblProgramNev.TabIndex = 0;
            this.LblProgramNev.Text = "Memóriajáték";
            this.LblProgramNev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnUjJatek
            // 
            this.BtnUjJatek.Location = new System.Drawing.Point(12, 48);
            this.BtnUjJatek.Name = "BtnUjJatek";
            this.BtnUjJatek.Size = new System.Drawing.Size(146, 40);
            this.BtnUjJatek.TabIndex = 1;
            this.BtnUjJatek.Text = "Új Játék";
            this.BtnUjJatek.UseVisualStyleBackColor = true;
            this.BtnUjJatek.Click += new System.EventHandler(this.BtnUjJatek_Click);
            // 
            // BtnEredmenyek
            // 
            this.BtnEredmenyek.Location = new System.Drawing.Point(164, 48);
            this.BtnEredmenyek.Name = "BtnEredmenyek";
            this.BtnEredmenyek.Size = new System.Drawing.Size(146, 40);
            this.BtnEredmenyek.TabIndex = 2;
            this.BtnEredmenyek.Text = "Eredmények";
            this.BtnEredmenyek.UseVisualStyleBackColor = true;
            this.BtnEredmenyek.Click += new System.EventHandler(this.BtnEredmenyek_Click);
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.Location = new System.Drawing.Point(316, 48);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(146, 40);
            this.BtnKilepes.TabIndex = 3;
            this.BtnKilepes.Text = "Kilépés";
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // FrmIndulasiKepernyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 100);
            this.Controls.Add(this.BtnKilepes);
            this.Controls.Add(this.BtnEredmenyek);
            this.Controls.Add(this.BtnUjJatek);
            this.Controls.Add(this.LblProgramNev);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIndulasiKepernyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memóriajáték";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIndulasiKepernyo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblProgramNev;
        private System.Windows.Forms.Button BtnUjJatek;
        private System.Windows.Forms.Button BtnEredmenyek;
        private System.Windows.Forms.Button BtnKilepes;
    }
}