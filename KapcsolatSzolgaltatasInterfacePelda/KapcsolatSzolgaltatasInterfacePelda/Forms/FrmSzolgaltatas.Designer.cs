using System;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    partial class FrmSzolgaltatas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSzolgaltatas));
            this.ImlIkonok = new System.Windows.Forms.ImageList(this.components);
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.NudSzolgaltatasAra = new System.Windows.Forms.NumericUpDown();
            this.TxbSzolgaltatasNev = new System.Windows.Forms.TextBox();
            this.LblSzolgaltatasAr = new System.Windows.Forms.Label();
            this.LblSzolgaltatasNev = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.GrbAdatok = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudSzolgaltatasAra)).BeginInit();
            this.GrbAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImlIkonok
            // 
            this.ImlIkonok.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlIkonok.ImageStream")));
            this.ImlIkonok.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlIkonok.Images.SetKeyName(0, "Ok.png");
            this.ImlIkonok.Images.SetKeyName(1, "Cancel.png");
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMegsem.ImageKey = "Cancel.png";
            this.BtnMegsem.ImageList = this.ImlIkonok;
            this.BtnMegsem.Location = new System.Drawing.Point(330, 95);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(150, 40);
            this.BtnMegsem.TabIndex = 7;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // NudSzolgaltatasAra
            // 
            this.NudSzolgaltatasAra.Location = new System.Drawing.Point(162, 49);
            this.NudSzolgaltatasAra.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudSzolgaltatasAra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudSzolgaltatasAra.Name = "NudSzolgaltatasAra";
            this.NudSzolgaltatasAra.Size = new System.Drawing.Size(300, 22);
            this.NudSzolgaltatasAra.TabIndex = 8;
            this.NudSzolgaltatasAra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxbSzolgaltatasNev
            // 
            this.TxbSzolgaltatasNev.Location = new System.Drawing.Point(162, 21);
            this.TxbSzolgaltatasNev.MaxLength = 50;
            this.TxbSzolgaltatasNev.Name = "TxbSzolgaltatasNev";
            this.TxbSzolgaltatasNev.Size = new System.Drawing.Size(300, 22);
            this.TxbSzolgaltatasNev.TabIndex = 7;
            // 
            // LblSzolgaltatasAr
            // 
            this.LblSzolgaltatasAr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzolgaltatasAr.Location = new System.Drawing.Point(6, 49);
            this.LblSzolgaltatasAr.Name = "LblSzolgaltatasAr";
            this.LblSzolgaltatasAr.Size = new System.Drawing.Size(150, 22);
            this.LblSzolgaltatasAr.TabIndex = 1;
            this.LblSzolgaltatasAr.Text = "Szolgáltatás ára";
            this.LblSzolgaltatasAr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSzolgaltatasNev
            // 
            this.LblSzolgaltatasNev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzolgaltatasNev.Location = new System.Drawing.Point(6, 21);
            this.LblSzolgaltatasNev.Name = "LblSzolgaltatasNev";
            this.LblSzolgaltatasNev.Size = new System.Drawing.Size(150, 22);
            this.LblSzolgaltatasNev.TabIndex = 0;
            this.LblSzolgaltatasNev.Text = "Szolgáltatás neve";
            this.LblSzolgaltatasNev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.ImageKey = "Ok.png";
            this.BtnOK.ImageList = this.ImlIkonok;
            this.BtnOK.Location = new System.Drawing.Point(174, 95);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(150, 40);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // GrbAdatok
            // 
            this.GrbAdatok.Controls.Add(this.NudSzolgaltatasAra);
            this.GrbAdatok.Controls.Add(this.TxbSzolgaltatasNev);
            this.GrbAdatok.Controls.Add(this.LblSzolgaltatasAr);
            this.GrbAdatok.Controls.Add(this.LblSzolgaltatasNev);
            this.GrbAdatok.Location = new System.Drawing.Point(12, 12);
            this.GrbAdatok.Name = "GrbAdatok";
            this.GrbAdatok.Size = new System.Drawing.Size(468, 77);
            this.GrbAdatok.TabIndex = 5;
            this.GrbAdatok.TabStop = false;
            this.GrbAdatok.Text = "Adatok";
            // 
            // FrmSzolgaltatas
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(492, 147);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSzolgaltatas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szolgáltatás kezelés";
            ((System.ComponentModel.ISupportInitialize)(this.NudSzolgaltatasAra)).EndInit();
            this.GrbAdatok.ResumeLayout(false);
            this.GrbAdatok.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ImageList ImlIkonok;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.NumericUpDown NudSzolgaltatasAra;
        private System.Windows.Forms.TextBox TxbSzolgaltatasNev;
        private System.Windows.Forms.Label LblSzolgaltatasAr;
        private System.Windows.Forms.Label LblSzolgaltatasNev;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.GroupBox GrbAdatok;
    }
}