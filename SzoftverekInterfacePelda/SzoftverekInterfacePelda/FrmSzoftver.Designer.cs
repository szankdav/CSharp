namespace SzoftverekInterfacePelda
{
    partial class FrmSzoftver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSzoftver));
            this.GrbAdatok = new System.Windows.Forms.GroupBox();
            this.CmbTipus = new System.Windows.Forms.ComboBox();
            this.NudAr = new System.Windows.Forms.NumericUpDown();
            this.TxbMegnevezes = new System.Windows.Forms.TextBox();
            this.TxbGyarto = new System.Windows.Forms.TextBox();
            this.LblTipus = new System.Windows.Forms.Label();
            this.LblAr = new System.Windows.Forms.Label();
            this.LblMegnevezes = new System.Windows.Forms.Label();
            this.LblGyarto = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.ImlIkonok = new System.Windows.Forms.ImageList(this.components);
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.GrbAdatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbAdatok
            // 
            this.GrbAdatok.Controls.Add(this.CmbTipus);
            this.GrbAdatok.Controls.Add(this.NudAr);
            this.GrbAdatok.Controls.Add(this.TxbMegnevezes);
            this.GrbAdatok.Controls.Add(this.TxbGyarto);
            this.GrbAdatok.Controls.Add(this.LblTipus);
            this.GrbAdatok.Controls.Add(this.LblAr);
            this.GrbAdatok.Controls.Add(this.LblMegnevezes);
            this.GrbAdatok.Controls.Add(this.LblGyarto);
            this.GrbAdatok.Location = new System.Drawing.Point(13, 13);
            this.GrbAdatok.Margin = new System.Windows.Forms.Padding(4);
            this.GrbAdatok.Name = "GrbAdatok";
            this.GrbAdatok.Padding = new System.Windows.Forms.Padding(4);
            this.GrbAdatok.Size = new System.Drawing.Size(320, 137);
            this.GrbAdatok.TabIndex = 0;
            this.GrbAdatok.TabStop = false;
            this.GrbAdatok.Text = "Adatok";
            // 
            // CmbTipus
            // 
            this.CmbTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipus.FormattingEnabled = true;
            this.CmbTipus.Location = new System.Drawing.Point(113, 103);
            this.CmbTipus.Name = "CmbTipus";
            this.CmbTipus.Size = new System.Drawing.Size(200, 24);
            this.CmbTipus.TabIndex = 7;
            // 
            // NudAr
            // 
            this.NudAr.Location = new System.Drawing.Point(113, 75);
            this.NudAr.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudAr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAr.Name = "NudAr";
            this.NudAr.Size = new System.Drawing.Size(200, 22);
            this.NudAr.TabIndex = 6;
            this.NudAr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxbMegnevezes
            // 
            this.TxbMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbMegnevezes.Location = new System.Drawing.Point(113, 47);
            this.TxbMegnevezes.Name = "TxbMegnevezes";
            this.TxbMegnevezes.Size = new System.Drawing.Size(200, 22);
            this.TxbMegnevezes.TabIndex = 5;
            // 
            // TxbGyarto
            // 
            this.TxbGyarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbGyarto.Location = new System.Drawing.Point(113, 19);
            this.TxbGyarto.Name = "TxbGyarto";
            this.TxbGyarto.Size = new System.Drawing.Size(200, 22);
            this.TxbGyarto.TabIndex = 4;
            // 
            // LblTipus
            // 
            this.LblTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTipus.Location = new System.Drawing.Point(7, 103);
            this.LblTipus.Name = "LblTipus";
            this.LblTipus.Size = new System.Drawing.Size(100, 24);
            this.LblTipus.TabIndex = 3;
            this.LblTipus.Text = "Tipus";
            this.LblTipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAr
            // 
            this.LblAr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAr.Location = new System.Drawing.Point(7, 74);
            this.LblAr.Name = "LblAr";
            this.LblAr.Size = new System.Drawing.Size(100, 22);
            this.LblAr.TabIndex = 2;
            this.LblAr.Text = "Ar";
            this.LblAr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMegnevezes
            // 
            this.LblMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMegnevezes.Location = new System.Drawing.Point(7, 47);
            this.LblMegnevezes.Name = "LblMegnevezes";
            this.LblMegnevezes.Size = new System.Drawing.Size(100, 22);
            this.LblMegnevezes.TabIndex = 1;
            this.LblMegnevezes.Text = "Megnevezes";
            this.LblMegnevezes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblGyarto
            // 
            this.LblGyarto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblGyarto.Location = new System.Drawing.Point(7, 19);
            this.LblGyarto.Name = "LblGyarto";
            this.LblGyarto.Size = new System.Drawing.Size(100, 22);
            this.LblGyarto.TabIndex = 0;
            this.LblGyarto.Text = "Gyarto";
            this.LblGyarto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOk.ImageKey = "Ok.png";
            this.BtnOk.ImageList = this.ImlIkonok;
            this.BtnOk.Location = new System.Drawing.Point(20, 157);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(150, 40);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "OK";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
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
            this.BtnMegsem.Location = new System.Drawing.Point(176, 157);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(150, 40);
            this.BtnMegsem.TabIndex = 2;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmSzoftver
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(348, 209);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.GrbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSzoftver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSzoftver";
            this.GrbAdatok.ResumeLayout(false);
            this.GrbAdatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbAdatok;
        private System.Windows.Forms.Label LblTipus;
        private System.Windows.Forms.Label LblAr;
        private System.Windows.Forms.Label LblMegnevezes;
        private System.Windows.Forms.Label LblGyarto;
        private System.Windows.Forms.ComboBox CmbTipus;
        private System.Windows.Forms.NumericUpDown NudAr;
        private System.Windows.Forms.TextBox TxbMegnevezes;
        private System.Windows.Forms.TextBox TxbGyarto;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.ImageList ImlIkonok;
    }
}