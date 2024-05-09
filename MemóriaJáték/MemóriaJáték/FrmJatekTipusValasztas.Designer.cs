namespace MemóriaJáték
{
    partial class FrmJatekTipusValasztas
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
            this.LblJatekTipusValasztas = new System.Windows.Forms.Label();
            this.CmbJatekTipus = new System.Windows.Forms.ComboBox();
            this.LblJatekTipusInfo = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblJatekTipusValasztas
            // 
            this.LblJatekTipusValasztas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblJatekTipusValasztas.Location = new System.Drawing.Point(12, 9);
            this.LblJatekTipusValasztas.Name = "LblJatekTipusValasztas";
            this.LblJatekTipusValasztas.Size = new System.Drawing.Size(425, 21);
            this.LblJatekTipusValasztas.TabIndex = 0;
            this.LblJatekTipusValasztas.Text = "Kérem válasszon játék típust:";
            this.LblJatekTipusValasztas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbJatekTipus
            // 
            this.CmbJatekTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJatekTipus.FormattingEnabled = true;
            this.CmbJatekTipus.Location = new System.Drawing.Point(12, 33);
            this.CmbJatekTipus.Name = "CmbJatekTipus";
            this.CmbJatekTipus.Size = new System.Drawing.Size(425, 24);
            this.CmbJatekTipus.TabIndex = 1;
            this.CmbJatekTipus.SelectedIndexChanged += new System.EventHandler(this.CmbJatekTipus_SelectedIndexChanged);
            // 
            // LblJatekTipusInfo
            // 
            this.LblJatekTipusInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblJatekTipusInfo.Location = new System.Drawing.Point(12, 60);
            this.LblJatekTipusInfo.Name = "LblJatekTipusInfo";
            this.LblJatekTipusInfo.Size = new System.Drawing.Size(425, 21);
            this.LblJatekTipusInfo.TabIndex = 2;
            this.LblJatekTipusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(12, 84);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(209, 40);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(228, 84);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(209, 40);
            this.BtnMegsem.TabIndex = 4;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmJatekTipusValasztas
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(449, 136);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblJatekTipusInfo);
            this.Controls.Add(this.CmbJatekTipus);
            this.Controls.Add(this.LblJatekTipusValasztas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJatekTipusValasztas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Játék típus kiválasztása";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblJatekTipusValasztas;
        private System.Windows.Forms.ComboBox CmbJatekTipus;
        private System.Windows.Forms.Label LblJatekTipusInfo;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
    }
}