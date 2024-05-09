namespace GepAlkatreszekAbstract
{
    partial class FrmGepAlkatreszKezeles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGepAlkatreszKezeles));
            this.GrbGepAlkatresz = new System.Windows.Forms.GroupBox();
            this.NudMagassag = new System.Windows.Forms.NumericUpDown();
            this.NudSzelesseg = new System.Windows.Forms.NumericUpDown();
            this.NudAr = new System.Windows.Forms.NumericUpDown();
            this.TxbSzeriaSzam = new System.Windows.Forms.TextBox();
            this.TxbMegnevezes = new System.Windows.Forms.TextBox();
            this.LblMagassag = new System.Windows.Forms.Label();
            this.LblSzelesseg = new System.Windows.Forms.Label();
            this.LblAr = new System.Windows.Forms.Label();
            this.LblSzeriaSzam = new System.Windows.Forms.Label();
            this.LblMegnevezes = new System.Windows.Forms.Label();
            this.TbcReszletek = new System.Windows.Forms.TabControl();
            this.TbpAlaplap = new System.Windows.Forms.TabPage();
            this.CmbMemoria = new System.Windows.Forms.ComboBox();
            this.TxbChipset = new System.Windows.Forms.TextBox();
            this.LblMemoria = new System.Windows.Forms.Label();
            this.LblChipset = new System.Windows.Forms.Label();
            this.TbpMemoria = new System.Windows.Forms.TabPage();
            this.CmbTipus = new System.Windows.Forms.ComboBox();
            this.NudFrekvencia = new System.Windows.Forms.NumericUpDown();
            this.TxbArchitektura = new System.Windows.Forms.TextBox();
            this.LblFrekvencia = new System.Windows.Forms.Label();
            this.LblArchitektura = new System.Windows.Forms.Label();
            this.LblTipus = new System.Windows.Forms.Label();
            this.TbpProcesszor = new System.Windows.Forms.TabPage();
            this.TxbTokozas = new System.Windows.Forms.TextBox();
            this.NudKesleltetes = new System.Windows.Forms.NumericUpDown();
            this.NudFrekvencia2 = new System.Windows.Forms.NumericUpDown();
            this.LblKesleltetes = new System.Windows.Forms.Label();
            this.LblTokozas = new System.Windows.Forms.Label();
            this.LblFrekvencia2 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.ImlIkonok = new System.Windows.Forms.ImageList(this.components);
            this.GrbGepAlkatresz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMagassag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSzelesseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).BeginInit();
            this.TbcReszletek.SuspendLayout();
            this.TbpAlaplap.SuspendLayout();
            this.TbpMemoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFrekvencia)).BeginInit();
            this.TbpProcesszor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudKesleltetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFrekvencia2)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbGepAlkatresz
            // 
            this.GrbGepAlkatresz.Controls.Add(this.NudMagassag);
            this.GrbGepAlkatresz.Controls.Add(this.NudSzelesseg);
            this.GrbGepAlkatresz.Controls.Add(this.NudAr);
            this.GrbGepAlkatresz.Controls.Add(this.TxbSzeriaSzam);
            this.GrbGepAlkatresz.Controls.Add(this.TxbMegnevezes);
            this.GrbGepAlkatresz.Controls.Add(this.LblMagassag);
            this.GrbGepAlkatresz.Controls.Add(this.LblSzelesseg);
            this.GrbGepAlkatresz.Controls.Add(this.LblAr);
            this.GrbGepAlkatresz.Controls.Add(this.LblSzeriaSzam);
            this.GrbGepAlkatresz.Controls.Add(this.LblMegnevezes);
            this.GrbGepAlkatresz.Location = new System.Drawing.Point(24, 22);
            this.GrbGepAlkatresz.Name = "GrbGepAlkatresz";
            this.GrbGepAlkatresz.Size = new System.Drawing.Size(418, 161);
            this.GrbGepAlkatresz.TabIndex = 0;
            this.GrbGepAlkatresz.TabStop = false;
            this.GrbGepAlkatresz.Text = "Gépalkatrész általános adatai";
            // 
            // NudMagassag
            // 
            this.NudMagassag.Location = new System.Drawing.Point(212, 133);
            this.NudMagassag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMagassag.Name = "NudMagassag";
            this.NudMagassag.Size = new System.Drawing.Size(200, 22);
            this.NudMagassag.TabIndex = 9;
            this.NudMagassag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudSzelesseg
            // 
            this.NudSzelesseg.Location = new System.Drawing.Point(212, 105);
            this.NudSzelesseg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudSzelesseg.Name = "NudSzelesseg";
            this.NudSzelesseg.Size = new System.Drawing.Size(200, 22);
            this.NudSzelesseg.TabIndex = 8;
            this.NudSzelesseg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudAr
            // 
            this.NudAr.Location = new System.Drawing.Point(212, 77);
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
            this.NudAr.TabIndex = 7;
            this.NudAr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxbSzeriaSzam
            // 
            this.TxbSzeriaSzam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSzeriaSzam.Location = new System.Drawing.Point(212, 49);
            this.TxbSzeriaSzam.MaxLength = 10;
            this.TxbSzeriaSzam.Name = "TxbSzeriaSzam";
            this.TxbSzeriaSzam.Size = new System.Drawing.Size(200, 22);
            this.TxbSzeriaSzam.TabIndex = 6;
            // 
            // TxbMegnevezes
            // 
            this.TxbMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbMegnevezes.Location = new System.Drawing.Point(212, 21);
            this.TxbMegnevezes.MaxLength = 30;
            this.TxbMegnevezes.Name = "TxbMegnevezes";
            this.TxbMegnevezes.Size = new System.Drawing.Size(200, 22);
            this.TxbMegnevezes.TabIndex = 5;
            // 
            // LblMagassag
            // 
            this.LblMagassag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMagassag.Location = new System.Drawing.Point(6, 134);
            this.LblMagassag.Name = "LblMagassag";
            this.LblMagassag.Size = new System.Drawing.Size(200, 22);
            this.LblMagassag.TabIndex = 4;
            this.LblMagassag.Text = "Magasság (cm)";
            this.LblMagassag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSzelesseg
            // 
            this.LblSzelesseg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzelesseg.Location = new System.Drawing.Point(6, 106);
            this.LblSzelesseg.Name = "LblSzelesseg";
            this.LblSzelesseg.Size = new System.Drawing.Size(200, 22);
            this.LblSzelesseg.TabIndex = 3;
            this.LblSzelesseg.Text = "Szélesség (cm)";
            this.LblSzelesseg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAr
            // 
            this.LblAr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAr.Location = new System.Drawing.Point(6, 77);
            this.LblAr.Name = "LblAr";
            this.LblAr.Size = new System.Drawing.Size(200, 22);
            this.LblAr.TabIndex = 2;
            this.LblAr.Text = "Ár";
            this.LblAr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSzeriaSzam
            // 
            this.LblSzeriaSzam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzeriaSzam.Location = new System.Drawing.Point(6, 51);
            this.LblSzeriaSzam.Name = "LblSzeriaSzam";
            this.LblSzeriaSzam.Size = new System.Drawing.Size(200, 22);
            this.LblSzeriaSzam.TabIndex = 1;
            this.LblSzeriaSzam.Text = "Szeriaszám";
            this.LblSzeriaSzam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMegnevezes
            // 
            this.LblMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMegnevezes.Location = new System.Drawing.Point(6, 23);
            this.LblMegnevezes.Name = "LblMegnevezes";
            this.LblMegnevezes.Size = new System.Drawing.Size(200, 22);
            this.LblMegnevezes.TabIndex = 0;
            this.LblMegnevezes.Text = "Megnevezés";
            this.LblMegnevezes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbcReszletek
            // 
            this.TbcReszletek.Controls.Add(this.TbpAlaplap);
            this.TbcReszletek.Controls.Add(this.TbpMemoria);
            this.TbcReszletek.Controls.Add(this.TbpProcesszor);
            this.TbcReszletek.Location = new System.Drawing.Point(24, 195);
            this.TbcReszletek.Name = "TbcReszletek";
            this.TbcReszletek.SelectedIndex = 0;
            this.TbcReszletek.Size = new System.Drawing.Size(425, 119);
            this.TbcReszletek.TabIndex = 1;
            // 
            // TbpAlaplap
            // 
            this.TbpAlaplap.Controls.Add(this.CmbMemoria);
            this.TbpAlaplap.Controls.Add(this.TxbChipset);
            this.TbpAlaplap.Controls.Add(this.LblMemoria);
            this.TbpAlaplap.Controls.Add(this.LblChipset);
            this.TbpAlaplap.Location = new System.Drawing.Point(4, 25);
            this.TbpAlaplap.Name = "TbpAlaplap";
            this.TbpAlaplap.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAlaplap.Size = new System.Drawing.Size(417, 90);
            this.TbpAlaplap.TabIndex = 0;
            this.TbpAlaplap.Text = "Alaplap";
            this.TbpAlaplap.UseVisualStyleBackColor = true;
            // 
            // CmbMemoria
            // 
            this.CmbMemoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMemoria.FormattingEnabled = true;
            this.CmbMemoria.Location = new System.Drawing.Point(208, 34);
            this.CmbMemoria.Name = "CmbMemoria";
            this.CmbMemoria.Size = new System.Drawing.Size(203, 24);
            this.CmbMemoria.TabIndex = 3;
            // 
            // TxbChipset
            // 
            this.TxbChipset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbChipset.Location = new System.Drawing.Point(208, 6);
            this.TxbChipset.MaxLength = 20;
            this.TxbChipset.Name = "TxbChipset";
            this.TxbChipset.Size = new System.Drawing.Size(203, 22);
            this.TxbChipset.TabIndex = 2;
            // 
            // LblMemoria
            // 
            this.LblMemoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMemoria.Location = new System.Drawing.Point(6, 34);
            this.LblMemoria.Name = "LblMemoria";
            this.LblMemoria.Size = new System.Drawing.Size(196, 24);
            this.LblMemoria.TabIndex = 1;
            this.LblMemoria.Text = "Támogatott memória";
            this.LblMemoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblChipset
            // 
            this.LblChipset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblChipset.Location = new System.Drawing.Point(6, 6);
            this.LblChipset.Name = "LblChipset";
            this.LblChipset.Size = new System.Drawing.Size(196, 22);
            this.LblChipset.TabIndex = 0;
            this.LblChipset.Text = "Chipset";
            this.LblChipset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbpMemoria
            // 
            this.TbpMemoria.Controls.Add(this.CmbTipus);
            this.TbpMemoria.Controls.Add(this.NudFrekvencia);
            this.TbpMemoria.Controls.Add(this.TxbArchitektura);
            this.TbpMemoria.Controls.Add(this.LblFrekvencia);
            this.TbpMemoria.Controls.Add(this.LblArchitektura);
            this.TbpMemoria.Controls.Add(this.LblTipus);
            this.TbpMemoria.Location = new System.Drawing.Point(4, 25);
            this.TbpMemoria.Name = "TbpMemoria";
            this.TbpMemoria.Padding = new System.Windows.Forms.Padding(3);
            this.TbpMemoria.Size = new System.Drawing.Size(417, 90);
            this.TbpMemoria.TabIndex = 1;
            this.TbpMemoria.Text = "Memória";
            this.TbpMemoria.UseVisualStyleBackColor = true;
            // 
            // CmbTipus
            // 
            this.CmbTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipus.FormattingEnabled = true;
            this.CmbTipus.Location = new System.Drawing.Point(208, 6);
            this.CmbTipus.Name = "CmbTipus";
            this.CmbTipus.Size = new System.Drawing.Size(206, 24);
            this.CmbTipus.TabIndex = 7;
            // 
            // NudFrekvencia
            // 
            this.NudFrekvencia.DecimalPlaces = 2;
            this.NudFrekvencia.Location = new System.Drawing.Point(208, 62);
            this.NudFrekvencia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudFrekvencia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudFrekvencia.Name = "NudFrekvencia";
            this.NudFrekvencia.Size = new System.Drawing.Size(206, 22);
            this.NudFrekvencia.TabIndex = 5;
            this.NudFrekvencia.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TxbArchitektura
            // 
            this.TxbArchitektura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbArchitektura.Location = new System.Drawing.Point(208, 34);
            this.TxbArchitektura.MaxLength = 20;
            this.TxbArchitektura.Name = "TxbArchitektura";
            this.TxbArchitektura.Size = new System.Drawing.Size(206, 22);
            this.TxbArchitektura.TabIndex = 4;
            // 
            // LblFrekvencia
            // 
            this.LblFrekvencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFrekvencia.Location = new System.Drawing.Point(6, 62);
            this.LblFrekvencia.Name = "LblFrekvencia";
            this.LblFrekvencia.Size = new System.Drawing.Size(196, 22);
            this.LblFrekvencia.TabIndex = 2;
            this.LblFrekvencia.Text = "Frekvencia";
            this.LblFrekvencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblArchitektura
            // 
            this.LblArchitektura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblArchitektura.Location = new System.Drawing.Point(6, 34);
            this.LblArchitektura.Name = "LblArchitektura";
            this.LblArchitektura.Size = new System.Drawing.Size(196, 22);
            this.LblArchitektura.TabIndex = 1;
            this.LblArchitektura.Text = "Architektúra";
            this.LblArchitektura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTipus
            // 
            this.LblTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTipus.Location = new System.Drawing.Point(6, 6);
            this.LblTipus.Name = "LblTipus";
            this.LblTipus.Size = new System.Drawing.Size(196, 22);
            this.LblTipus.TabIndex = 0;
            this.LblTipus.Text = "Tipus";
            this.LblTipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbpProcesszor
            // 
            this.TbpProcesszor.Controls.Add(this.TxbTokozas);
            this.TbpProcesszor.Controls.Add(this.NudKesleltetes);
            this.TbpProcesszor.Controls.Add(this.NudFrekvencia2);
            this.TbpProcesszor.Controls.Add(this.LblKesleltetes);
            this.TbpProcesszor.Controls.Add(this.LblTokozas);
            this.TbpProcesszor.Controls.Add(this.LblFrekvencia2);
            this.TbpProcesszor.Location = new System.Drawing.Point(4, 25);
            this.TbpProcesszor.Name = "TbpProcesszor";
            this.TbpProcesszor.Size = new System.Drawing.Size(417, 90);
            this.TbpProcesszor.TabIndex = 2;
            this.TbpProcesszor.Text = "Processzor";
            this.TbpProcesszor.UseVisualStyleBackColor = true;
            // 
            // TxbTokozas
            // 
            this.TxbTokozas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbTokozas.Location = new System.Drawing.Point(208, 5);
            this.TxbTokozas.MaxLength = 20;
            this.TxbTokozas.Name = "TxbTokozas";
            this.TxbTokozas.Size = new System.Drawing.Size(206, 22);
            this.TxbTokozas.TabIndex = 8;
            // 
            // NudKesleltetes
            // 
            this.NudKesleltetes.Location = new System.Drawing.Point(208, 61);
            this.NudKesleltetes.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NudKesleltetes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudKesleltetes.Name = "NudKesleltetes";
            this.NudKesleltetes.Size = new System.Drawing.Size(206, 22);
            this.NudKesleltetes.TabIndex = 8;
            this.NudKesleltetes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudFrekvencia2
            // 
            this.NudFrekvencia2.DecimalPlaces = 2;
            this.NudFrekvencia2.Location = new System.Drawing.Point(208, 33);
            this.NudFrekvencia2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudFrekvencia2.Minimum = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.NudFrekvencia2.Name = "NudFrekvencia2";
            this.NudFrekvencia2.Size = new System.Drawing.Size(206, 22);
            this.NudFrekvencia2.TabIndex = 7;
            this.NudFrekvencia2.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            // 
            // LblKesleltetes
            // 
            this.LblKesleltetes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblKesleltetes.Location = new System.Drawing.Point(3, 61);
            this.LblKesleltetes.Name = "LblKesleltetes";
            this.LblKesleltetes.Size = new System.Drawing.Size(199, 22);
            this.LblKesleltetes.TabIndex = 5;
            this.LblKesleltetes.Text = "Késleltetés";
            this.LblKesleltetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTokozas
            // 
            this.LblTokozas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTokozas.Location = new System.Drawing.Point(3, 3);
            this.LblTokozas.Name = "LblTokozas";
            this.LblTokozas.Size = new System.Drawing.Size(199, 24);
            this.LblTokozas.TabIndex = 3;
            this.LblTokozas.Text = "Tokozas";
            this.LblTokozas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblFrekvencia2
            // 
            this.LblFrekvencia2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFrekvencia2.Location = new System.Drawing.Point(3, 33);
            this.LblFrekvencia2.Name = "LblFrekvencia2";
            this.LblFrekvencia2.Size = new System.Drawing.Size(199, 22);
            this.LblFrekvencia2.TabIndex = 4;
            this.LblFrekvencia2.Text = "Frekvencia";
            this.LblFrekvencia2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOK.ImageKey = "Ok.png";
            this.BtnOK.ImageList = this.ImlIkonok;
            this.BtnOK.Location = new System.Drawing.Point(43, 320);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(200, 40);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMegsem.ImageKey = "Cancel.png";
            this.BtnMegsem.ImageList = this.ImlIkonok;
            this.BtnMegsem.Location = new System.Drawing.Point(249, 320);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(200, 40);
            this.BtnMegsem.TabIndex = 3;
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
            // FrmGepAlkatreszKezeles
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(461, 372);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TbcReszletek);
            this.Controls.Add(this.GrbGepAlkatresz);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGepAlkatreszKezeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gépalkatrész kezelés";
            this.GrbGepAlkatresz.ResumeLayout(false);
            this.GrbGepAlkatresz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMagassag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSzelesseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).EndInit();
            this.TbcReszletek.ResumeLayout(false);
            this.TbpAlaplap.ResumeLayout(false);
            this.TbpAlaplap.PerformLayout();
            this.TbpMemoria.ResumeLayout(false);
            this.TbpMemoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFrekvencia)).EndInit();
            this.TbpProcesszor.ResumeLayout(false);
            this.TbpProcesszor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudKesleltetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFrekvencia2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbGepAlkatresz;
        private System.Windows.Forms.Label LblMagassag;
        private System.Windows.Forms.Label LblSzelesseg;
        private System.Windows.Forms.Label LblAr;
        private System.Windows.Forms.Label LblSzeriaSzam;
        private System.Windows.Forms.Label LblMegnevezes;
        private System.Windows.Forms.NumericUpDown NudMagassag;
        private System.Windows.Forms.NumericUpDown NudSzelesseg;
        private System.Windows.Forms.NumericUpDown NudAr;
        private System.Windows.Forms.TextBox TxbSzeriaSzam;
        private System.Windows.Forms.TextBox TxbMegnevezes;
        private System.Windows.Forms.TabControl TbcReszletek;
        private System.Windows.Forms.TabPage TbpAlaplap;
        private System.Windows.Forms.TabPage TbpMemoria;
        private System.Windows.Forms.TabPage TbpProcesszor;
        private System.Windows.Forms.ComboBox CmbMemoria;
        private System.Windows.Forms.TextBox TxbChipset;
        private System.Windows.Forms.Label LblMemoria;
        private System.Windows.Forms.Label LblChipset;
        private System.Windows.Forms.NumericUpDown NudFrekvencia;
        private System.Windows.Forms.TextBox TxbArchitektura;
        private System.Windows.Forms.Label LblFrekvencia;
        private System.Windows.Forms.Label LblArchitektura;
        private System.Windows.Forms.Label LblTipus;
        private System.Windows.Forms.NumericUpDown NudKesleltetes;
        private System.Windows.Forms.NumericUpDown NudFrekvencia2;
        private System.Windows.Forms.Label LblKesleltetes;
        private System.Windows.Forms.Label LblTokozas;
        private System.Windows.Forms.Label LblFrekvencia2;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
        private System.Windows.Forms.ComboBox CmbTipus;
        private System.Windows.Forms.TextBox TxbTokozas;
        private System.Windows.Forms.ImageList ImlIkonok;
    }
}