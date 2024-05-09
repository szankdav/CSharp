namespace SzamitogepekDictionary
{
    partial class FrmFelvitel
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
            this.LblIPCim = new System.Windows.Forms.Label();
            this.LblMACCim = new System.Windows.Forms.Label();
            this.LblOperaciosRendszer = new System.Windows.Forms.Label();
            this.LblTulajdonos = new System.Windows.Forms.Label();
            this.TxbIPCim = new System.Windows.Forms.TextBox();
            this.TxbMACCim = new System.Windows.Forms.TextBox();
            this.TxbOperaciosRendszer = new System.Windows.Forms.TextBox();
            this.TxbTulajdonos = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIPCim
            // 
            this.LblIPCim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIPCim.Location = new System.Drawing.Point(12, 9);
            this.LblIPCim.Name = "LblIPCim";
            this.LblIPCim.Size = new System.Drawing.Size(125, 22);
            this.LblIPCim.TabIndex = 0;
            this.LblIPCim.Text = "IP cim";
            this.LblIPCim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMACCim
            // 
            this.LblMACCim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMACCim.Location = new System.Drawing.Point(12, 37);
            this.LblMACCim.Name = "LblMACCim";
            this.LblMACCim.Size = new System.Drawing.Size(125, 22);
            this.LblMACCim.TabIndex = 1;
            this.LblMACCim.Text = "MAC cim";
            this.LblMACCim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblOperaciosRendszer
            // 
            this.LblOperaciosRendszer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOperaciosRendszer.Location = new System.Drawing.Point(12, 65);
            this.LblOperaciosRendszer.Name = "LblOperaciosRendszer";
            this.LblOperaciosRendszer.Size = new System.Drawing.Size(125, 22);
            this.LblOperaciosRendszer.TabIndex = 2;
            this.LblOperaciosRendszer.Text = "Operacios rendsz.";
            this.LblOperaciosRendszer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTulajdonos
            // 
            this.LblTulajdonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTulajdonos.Location = new System.Drawing.Point(12, 93);
            this.LblTulajdonos.Name = "LblTulajdonos";
            this.LblTulajdonos.Size = new System.Drawing.Size(125, 22);
            this.LblTulajdonos.TabIndex = 3;
            this.LblTulajdonos.Text = "Tulajdonos";
            this.LblTulajdonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbIPCim
            // 
            this.TxbIPCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbIPCim.Location = new System.Drawing.Point(143, 9);
            this.TxbIPCim.Name = "TxbIPCim";
            this.TxbIPCim.Size = new System.Drawing.Size(229, 22);
            this.TxbIPCim.TabIndex = 4;
            this.TxbIPCim.Leave += new System.EventHandler(this.TxbIPCim_Leave);
            // 
            // TxbMACCim
            // 
            this.TxbMACCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbMACCim.Location = new System.Drawing.Point(143, 37);
            this.TxbMACCim.Name = "TxbMACCim";
            this.TxbMACCim.Size = new System.Drawing.Size(229, 22);
            this.TxbMACCim.TabIndex = 5;
            this.TxbMACCim.Leave += new System.EventHandler(this.TxbMACCim_Leave);
            // 
            // TxbOperaciosRendszer
            // 
            this.TxbOperaciosRendszer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbOperaciosRendszer.Location = new System.Drawing.Point(143, 65);
            this.TxbOperaciosRendszer.Name = "TxbOperaciosRendszer";
            this.TxbOperaciosRendszer.Size = new System.Drawing.Size(229, 22);
            this.TxbOperaciosRendszer.TabIndex = 6;
            // 
            // TxbTulajdonos
            // 
            this.TxbTulajdonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbTulajdonos.Location = new System.Drawing.Point(143, 93);
            this.TxbTulajdonos.Name = "TxbTulajdonos";
            this.TxbTulajdonos.Size = new System.Drawing.Size(229, 22);
            this.TxbTulajdonos.TabIndex = 7;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(216, 121);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 30);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(297, 121);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(75, 30);
            this.BtnMegsem.TabIndex = 9;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmFelvitel
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxbTulajdonos);
            this.Controls.Add(this.TxbOperaciosRendszer);
            this.Controls.Add(this.TxbMACCim);
            this.Controls.Add(this.TxbIPCim);
            this.Controls.Add(this.LblTulajdonos);
            this.Controls.Add(this.LblOperaciosRendszer);
            this.Controls.Add(this.LblMACCim);
            this.Controls.Add(this.LblIPCim);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFelvitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFelvitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIPCim;
        private System.Windows.Forms.Label LblMACCim;
        private System.Windows.Forms.Label LblOperaciosRendszer;
        private System.Windows.Forms.Label LblTulajdonos;
        private System.Windows.Forms.TextBox TxbIPCim;
        private System.Windows.Forms.TextBox TxbMACCim;
        private System.Windows.Forms.TextBox TxbOperaciosRendszer;
        private System.Windows.Forms.TextBox TxbTulajdonos;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
    }
}