namespace BetegsegManager
{
    partial class FrmBetegseg
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
            this.LblMegnevezes = new System.Windows.Forms.Label();
            this.LblTipus = new System.Windows.Forms.Label();
            this.LblLefolyas = new System.Windows.Forms.Label();
            this.TxbMegnevezes = new System.Windows.Forms.TextBox();
            this.CmbTipus = new System.Windows.Forms.ComboBox();
            this.CmbLefolyas = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.GrbAdatok = new System.Windows.Forms.GroupBox();
            this.GrbAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMegnevezes
            // 
            this.LblMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMegnevezes.Location = new System.Drawing.Point(6, 18);
            this.LblMegnevezes.Name = "LblMegnevezes";
            this.LblMegnevezes.Size = new System.Drawing.Size(200, 22);
            this.LblMegnevezes.TabIndex = 0;
            this.LblMegnevezes.Text = "Betegseg megnevezese";
            this.LblMegnevezes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTipus
            // 
            this.LblTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTipus.Location = new System.Drawing.Point(6, 46);
            this.LblTipus.Name = "LblTipus";
            this.LblTipus.Size = new System.Drawing.Size(200, 22);
            this.LblTipus.TabIndex = 1;
            this.LblTipus.Text = "Betegseg tipusa";
            this.LblTipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLefolyas
            // 
            this.LblLefolyas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLefolyas.Location = new System.Drawing.Point(6, 78);
            this.LblLefolyas.Name = "LblLefolyas";
            this.LblLefolyas.Size = new System.Drawing.Size(200, 22);
            this.LblLefolyas.TabIndex = 2;
            this.LblLefolyas.Text = "Betegseg lefolyasa";
            this.LblLefolyas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxbMegnevezes
            // 
            this.TxbMegnevezes.Location = new System.Drawing.Point(212, 18);
            this.TxbMegnevezes.Name = "TxbMegnevezes";
            this.TxbMegnevezes.Size = new System.Drawing.Size(200, 22);
            this.TxbMegnevezes.TabIndex = 3;
            // 
            // CmbTipus
            // 
            this.CmbTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipus.FormattingEnabled = true;
            this.CmbTipus.Location = new System.Drawing.Point(212, 46);
            this.CmbTipus.Name = "CmbTipus";
            this.CmbTipus.Size = new System.Drawing.Size(200, 24);
            this.CmbTipus.TabIndex = 4;
            // 
            // CmbLefolyas
            // 
            this.CmbLefolyas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLefolyas.FormattingEnabled = true;
            this.CmbLefolyas.Location = new System.Drawing.Point(212, 76);
            this.CmbLefolyas.Name = "CmbLefolyas";
            this.CmbLefolyas.Size = new System.Drawing.Size(200, 24);
            this.CmbLefolyas.TabIndex = 5;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(212, 106);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(98, 40);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(314, 106);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(98, 40);
            this.BtnMegsem.TabIndex = 7;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // GrbAdatok
            // 
            this.GrbAdatok.Controls.Add(this.LblMegnevezes);
            this.GrbAdatok.Controls.Add(this.BtnMegsem);
            this.GrbAdatok.Controls.Add(this.LblTipus);
            this.GrbAdatok.Controls.Add(this.BtnOk);
            this.GrbAdatok.Controls.Add(this.LblLefolyas);
            this.GrbAdatok.Controls.Add(this.CmbLefolyas);
            this.GrbAdatok.Controls.Add(this.TxbMegnevezes);
            this.GrbAdatok.Controls.Add(this.CmbTipus);
            this.GrbAdatok.Location = new System.Drawing.Point(12, 12);
            this.GrbAdatok.Name = "GrbAdatok";
            this.GrbAdatok.Size = new System.Drawing.Size(418, 153);
            this.GrbAdatok.TabIndex = 8;
            this.GrbAdatok.TabStop = false;
            this.GrbAdatok.Text = "Adatok";
            // 
            // FrmBetegseg
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(445, 180);
            this.Controls.Add(this.GrbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBetegseg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Betegseg kezelese";
            this.Load += new System.EventHandler(this.FrmBetegseg_Load);
            this.GrbAdatok.ResumeLayout(false);
            this.GrbAdatok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMegnevezes;
        private System.Windows.Forms.Label LblTipus;
        private System.Windows.Forms.Label LblLefolyas;
        private System.Windows.Forms.TextBox TxbMegnevezes;
        private System.Windows.Forms.ComboBox CmbTipus;
        private System.Windows.Forms.ComboBox CmbLefolyas;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.GroupBox GrbAdatok;
    }
}