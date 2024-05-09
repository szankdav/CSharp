namespace LogokMentese
{
    partial class FrmLogokMentese
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
            this.LblInformacio = new System.Windows.Forms.Label();
            this.TxbTartalom = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // LblInformacio
            // 
            this.LblInformacio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblInformacio.Location = new System.Drawing.Point(12, 9);
            this.LblInformacio.Name = "LblInformacio";
            this.LblInformacio.Size = new System.Drawing.Size(150, 22);
            this.LblInformacio.TabIndex = 0;
            this.LblInformacio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbTartalom
            // 
            this.TxbTartalom.Location = new System.Drawing.Point(12, 34);
            this.TxbTartalom.Multiline = true;
            this.TxbTartalom.Name = "TxbTartalom";
            this.TxbTartalom.Size = new System.Drawing.Size(560, 515);
            this.TxbTartalom.TabIndex = 1;
            this.TxbTartalom.TextChanged += new System.EventHandler(this.TxbTartalom_TextChanged);
            // 
            // FrmLogokMentese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.TxbTartalom);
            this.Controls.Add(this.LblInformacio);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogokMentese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logok Mentese";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogokMentese_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogokMentese_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInformacio;
        private System.Windows.Forms.TextBox TxbTartalom;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

