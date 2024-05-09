namespace LottoSorsolas
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
            this.BtnSorsolas = new System.Windows.Forms.Button();
            this.BtnUjJatek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSorsolas
            // 
            this.BtnSorsolas.Location = new System.Drawing.Point(12, 12);
            this.BtnSorsolas.Name = "BtnSorsolas";
            this.BtnSorsolas.Size = new System.Drawing.Size(100, 23);
            this.BtnSorsolas.TabIndex = 0;
            this.BtnSorsolas.Text = "Sorsolas";
            this.BtnSorsolas.UseVisualStyleBackColor = true;
            this.BtnSorsolas.Click += new System.EventHandler(this.BtnSorsolas_Click);
            // 
            // BtnUjJatek
            // 
            this.BtnUjJatek.Enabled = false;
            this.BtnUjJatek.Location = new System.Drawing.Point(118, 12);
            this.BtnUjJatek.Name = "BtnUjJatek";
            this.BtnUjJatek.Size = new System.Drawing.Size(100, 23);
            this.BtnUjJatek.TabIndex = 1;
            this.BtnUjJatek.Text = "Uj jatek";
            this.BtnUjJatek.UseVisualStyleBackColor = true;
            this.BtnUjJatek.Click += new System.EventHandler(this.BtnUjJatek_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnUjJatek);
            this.Controls.Add(this.BtnSorsolas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lottosorsolas";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSorsolas;
        private System.Windows.Forms.Button BtnUjJatek;
    }
}

