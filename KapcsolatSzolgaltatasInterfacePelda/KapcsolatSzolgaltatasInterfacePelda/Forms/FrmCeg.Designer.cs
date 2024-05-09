namespace KapcsolatSzolgaltatasInterfacePelda
{
    partial class FrmCeg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCeg));
            this.GrbAdatok = new System.Windows.Forms.GroupBox();
            this.CmbTelefonSzamTipus = new System.Windows.Forms.ComboBox();
            this.LblTelefonSzamTipus = new System.Windows.Forms.Label();
            this.MtbTelefonSzam = new System.Windows.Forms.MaskedTextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.NudHazSzam = new System.Windows.Forms.NumericUpDown();
            this.TxbUtca = new System.Windows.Forms.TextBox();
            this.TxbHelyseg = new System.Windows.Forms.TextBox();
            this.NudIranyitoSzam = new System.Windows.Forms.NumericUpDown();
            this.TxbCegNev = new System.Windows.Forms.TextBox();
            this.LblTelefonSzam = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblHazSzam = new System.Windows.Forms.Label();
            this.LblUtca = new System.Windows.Forms.Label();
            this.LblHelyseg = new System.Windows.Forms.Label();
            this.LblIranyitoSzam = new System.Windows.Forms.Label();
            this.LblCegNev = new System.Windows.Forms.Label();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.ImlIkonok = new System.Windows.Forms.ImageList(this.components);
            this.BtnOK = new System.Windows.Forms.Button();
            this.GrbAdatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHazSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIranyitoSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbAdatok
            // 
            this.GrbAdatok.Controls.Add(this.CmbTelefonSzamTipus);
            this.GrbAdatok.Controls.Add(this.LblTelefonSzamTipus);
            this.GrbAdatok.Controls.Add(this.MtbTelefonSzam);
            this.GrbAdatok.Controls.Add(this.TxbEmail);
            this.GrbAdatok.Controls.Add(this.NudHazSzam);
            this.GrbAdatok.Controls.Add(this.TxbUtca);
            this.GrbAdatok.Controls.Add(this.TxbHelyseg);
            this.GrbAdatok.Controls.Add(this.NudIranyitoSzam);
            this.GrbAdatok.Controls.Add(this.TxbCegNev);
            this.GrbAdatok.Controls.Add(this.LblTelefonSzam);
            this.GrbAdatok.Controls.Add(this.LblEmail);
            this.GrbAdatok.Controls.Add(this.LblHazSzam);
            this.GrbAdatok.Controls.Add(this.LblUtca);
            this.GrbAdatok.Controls.Add(this.LblHelyseg);
            this.GrbAdatok.Controls.Add(this.LblIranyitoSzam);
            this.GrbAdatok.Controls.Add(this.LblCegNev);
            this.GrbAdatok.Location = new System.Drawing.Point(26, 12);
            this.GrbAdatok.Name = "GrbAdatok";
            this.GrbAdatok.Size = new System.Drawing.Size(468, 247);
            this.GrbAdatok.TabIndex = 0;
            this.GrbAdatok.TabStop = false;
            this.GrbAdatok.Text = "Adatok";
            // 
            // CmbTelefonSzamTipus
            // 
            this.CmbTelefonSzamTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTelefonSzamTipus.FormattingEnabled = true;
            this.CmbTelefonSzamTipus.Location = new System.Drawing.Point(162, 217);
            this.CmbTelefonSzamTipus.Name = "CmbTelefonSzamTipus";
            this.CmbTelefonSzamTipus.Size = new System.Drawing.Size(300, 24);
            this.CmbTelefonSzamTipus.TabIndex = 15;
            // 
            // LblTelefonSzamTipus
            // 
            this.LblTelefonSzamTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTelefonSzamTipus.Location = new System.Drawing.Point(6, 219);
            this.LblTelefonSzamTipus.Name = "LblTelefonSzamTipus";
            this.LblTelefonSzamTipus.Size = new System.Drawing.Size(150, 22);
            this.LblTelefonSzamTipus.TabIndex = 14;
            this.LblTelefonSzamTipus.Text = "Telefonszám típus";
            this.LblTelefonSzamTipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MtbTelefonSzam
            // 
            this.MtbTelefonSzam.Location = new System.Drawing.Point(162, 189);
            this.MtbTelefonSzam.Name = "MtbTelefonSzam";
            this.MtbTelefonSzam.Size = new System.Drawing.Size(300, 22);
            this.MtbTelefonSzam.TabIndex = 13;
            // 
            // TxbEmail
            // 
            this.TxbEmail.Location = new System.Drawing.Point(162, 161);
            this.TxbEmail.MaxLength = 50;
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(300, 22);
            this.TxbEmail.TabIndex = 12;
            // 
            // NudHazSzam
            // 
            this.NudHazSzam.Location = new System.Drawing.Point(162, 133);
            this.NudHazSzam.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NudHazSzam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudHazSzam.Name = "NudHazSzam";
            this.NudHazSzam.Size = new System.Drawing.Size(120, 22);
            this.NudHazSzam.TabIndex = 11;
            this.NudHazSzam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxbUtca
            // 
            this.TxbUtca.Location = new System.Drawing.Point(162, 105);
            this.TxbUtca.MaxLength = 50;
            this.TxbUtca.Name = "TxbUtca";
            this.TxbUtca.Size = new System.Drawing.Size(300, 22);
            this.TxbUtca.TabIndex = 10;
            // 
            // TxbHelyseg
            // 
            this.TxbHelyseg.Location = new System.Drawing.Point(162, 77);
            this.TxbHelyseg.MaxLength = 50;
            this.TxbHelyseg.Name = "TxbHelyseg";
            this.TxbHelyseg.Size = new System.Drawing.Size(300, 22);
            this.TxbHelyseg.TabIndex = 9;
            // 
            // NudIranyitoSzam
            // 
            this.NudIranyitoSzam.Location = new System.Drawing.Point(162, 49);
            this.NudIranyitoSzam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NudIranyitoSzam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudIranyitoSzam.Name = "NudIranyitoSzam";
            this.NudIranyitoSzam.Size = new System.Drawing.Size(120, 22);
            this.NudIranyitoSzam.TabIndex = 8;
            this.NudIranyitoSzam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // TxbCegNev
            // 
            this.TxbCegNev.Location = new System.Drawing.Point(162, 21);
            this.TxbCegNev.MaxLength = 50;
            this.TxbCegNev.Name = "TxbCegNev";
            this.TxbCegNev.Size = new System.Drawing.Size(300, 22);
            this.TxbCegNev.TabIndex = 7;
            // 
            // LblTelefonSzam
            // 
            this.LblTelefonSzam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTelefonSzam.Location = new System.Drawing.Point(6, 189);
            this.LblTelefonSzam.Name = "LblTelefonSzam";
            this.LblTelefonSzam.Size = new System.Drawing.Size(150, 22);
            this.LblTelefonSzam.TabIndex = 6;
            this.LblTelefonSzam.Text = "Telefonszám";
            this.LblTelefonSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEmail
            // 
            this.LblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEmail.Location = new System.Drawing.Point(6, 161);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(150, 22);
            this.LblEmail.TabIndex = 5;
            this.LblEmail.Text = "E-mail cím";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHazSzam
            // 
            this.LblHazSzam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHazSzam.Location = new System.Drawing.Point(56, 133);
            this.LblHazSzam.Name = "LblHazSzam";
            this.LblHazSzam.Size = new System.Drawing.Size(100, 22);
            this.LblHazSzam.TabIndex = 4;
            this.LblHazSzam.Text = "Házszám";
            this.LblHazSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblUtca
            // 
            this.LblUtca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblUtca.Location = new System.Drawing.Point(56, 105);
            this.LblUtca.Name = "LblUtca";
            this.LblUtca.Size = new System.Drawing.Size(100, 22);
            this.LblUtca.TabIndex = 3;
            this.LblUtca.Text = "Utca";
            this.LblUtca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHelyseg
            // 
            this.LblHelyseg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHelyseg.Location = new System.Drawing.Point(56, 77);
            this.LblHelyseg.Name = "LblHelyseg";
            this.LblHelyseg.Size = new System.Drawing.Size(100, 22);
            this.LblHelyseg.TabIndex = 2;
            this.LblHelyseg.Text = "Helység";
            this.LblHelyseg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblIranyitoSzam
            // 
            this.LblIranyitoSzam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIranyitoSzam.Location = new System.Drawing.Point(56, 49);
            this.LblIranyitoSzam.Name = "LblIranyitoSzam";
            this.LblIranyitoSzam.Size = new System.Drawing.Size(100, 22);
            this.LblIranyitoSzam.TabIndex = 1;
            this.LblIranyitoSzam.Text = "Irányítószám";
            this.LblIranyitoSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCegNev
            // 
            this.LblCegNev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCegNev.Location = new System.Drawing.Point(6, 21);
            this.LblCegNev.Name = "LblCegNev";
            this.LblCegNev.Size = new System.Drawing.Size(150, 22);
            this.LblCegNev.TabIndex = 0;
            this.LblCegNev.Text = "Cég neve";
            this.LblCegNev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMegsem.ImageKey = "Cancel.png";
            this.BtnMegsem.ImageList = this.ImlIkonok;
            this.BtnMegsem.Location = new System.Drawing.Point(344, 265);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(150, 40);
            this.BtnMegsem.TabIndex = 4;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // ImlIkonok
            // 
            this.ImlIkonok.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlIkonok.ImageStream")));
            this.ImlIkonok.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlIkonok.Images.SetKeyName(0, "Ok.png");
            this.ImlIkonok.Images.SetKeyName(1, "Cancel.png");
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.ImageKey = "Ok.png";
            this.BtnOK.ImageList = this.ImlIkonok;
            this.BtnOK.Location = new System.Drawing.Point(188, 265);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(150, 40);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // FrmCeg
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(506, 317);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCeg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cég kezelése";
            this.GrbAdatok.ResumeLayout(false);
            this.GrbAdatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudHazSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIranyitoSzam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbAdatok;
        private System.Windows.Forms.Label LblUtca;
        private System.Windows.Forms.Label LblHelyseg;
        private System.Windows.Forms.Label LblIranyitoSzam;
        private System.Windows.Forms.Label LblCegNev;
        private System.Windows.Forms.Label LblTelefonSzam;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblHazSzam;
        private System.Windows.Forms.TextBox TxbCegNev;
        private System.Windows.Forms.NumericUpDown NudHazSzam;
        private System.Windows.Forms.TextBox TxbUtca;
        private System.Windows.Forms.TextBox TxbHelyseg;
        private System.Windows.Forms.NumericUpDown NudIranyitoSzam;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.MaskedTextBox MtbTelefonSzam;
        private System.Windows.Forms.ComboBox CmbTelefonSzamTipus;
        private System.Windows.Forms.Label LblTelefonSzamTipus;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.ImageList ImlIkonok;
        private System.Windows.Forms.Button BtnOK;
    }
}