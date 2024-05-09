namespace JegyOsztasQueue
{
    partial class FrmFeladat
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
            this.DtpHatarido = new System.Windows.Forms.DateTimePicker();
            this.TxbLeiras = new System.Windows.Forms.TextBox();
            this.TxbCim = new System.Windows.Forms.TextBox();
            this.LblHatarido = new System.Windows.Forms.Label();
            this.LblLeiras = new System.Windows.Forms.Label();
            this.LblCim = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DtpHatarido
            // 
            this.DtpHatarido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpHatarido.Location = new System.Drawing.Point(93, 131);
            this.DtpHatarido.Name = "DtpHatarido";
            this.DtpHatarido.Size = new System.Drawing.Size(279, 22);
            this.DtpHatarido.TabIndex = 11;
            // 
            // TxbLeiras
            // 
            this.TxbLeiras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbLeiras.Location = new System.Drawing.Point(93, 37);
            this.TxbLeiras.MaxLength = 200;
            this.TxbLeiras.Multiline = true;
            this.TxbLeiras.Name = "TxbLeiras";
            this.TxbLeiras.Size = new System.Drawing.Size(279, 88);
            this.TxbLeiras.TabIndex = 10;
            // 
            // TxbCim
            // 
            this.TxbCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbCim.Location = new System.Drawing.Point(93, 9);
            this.TxbCim.MaxLength = 30;
            this.TxbCim.Name = "TxbCim";
            this.TxbCim.Size = new System.Drawing.Size(279, 22);
            this.TxbCim.TabIndex = 9;
            // 
            // LblHatarido
            // 
            this.LblHatarido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHatarido.Location = new System.Drawing.Point(12, 131);
            this.LblHatarido.Name = "LblHatarido";
            this.LblHatarido.Size = new System.Drawing.Size(75, 22);
            this.LblHatarido.TabIndex = 8;
            this.LblHatarido.Text = "Hatarido";
            this.LblHatarido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLeiras
            // 
            this.LblLeiras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLeiras.Location = new System.Drawing.Point(12, 37);
            this.LblLeiras.Name = "LblLeiras";
            this.LblLeiras.Size = new System.Drawing.Size(75, 88);
            this.LblLeiras.TabIndex = 7;
            this.LblLeiras.Text = "Leiras";
            // 
            // LblCim
            // 
            this.LblCim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCim.Location = new System.Drawing.Point(12, 9);
            this.LblCim.Name = "LblCim";
            this.LblCim.Size = new System.Drawing.Size(75, 22);
            this.LblCim.TabIndex = 6;
            this.LblCim.Text = "Cim";
            this.LblCim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(216, 159);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 30);
            this.BtnOk.TabIndex = 12;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(297, 159);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(75, 30);
            this.BtnMegsem.TabIndex = 13;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmFeladat
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.DtpHatarido);
            this.Controls.Add(this.TxbLeiras);
            this.Controls.Add(this.TxbCim);
            this.Controls.Add(this.LblHatarido);
            this.Controls.Add(this.LblLeiras);
            this.Controls.Add(this.LblCim);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFeladat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFeladat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpHatarido;
        private System.Windows.Forms.TextBox TxbLeiras;
        private System.Windows.Forms.TextBox TxbCim;
        private System.Windows.Forms.Label LblHatarido;
        private System.Windows.Forms.Label LblLeiras;
        private System.Windows.Forms.Label LblCim;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnMegsem;
    }
}