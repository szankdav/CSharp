namespace ABCRaktarKezelo
{
    partial class FrmTermek
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
            this.GrbAltalanosTermek = new System.Windows.Forms.GroupBox();
            this.NudDarabszam = new System.Windows.Forms.NumericUpDown();
            this.NudAr = new System.Windows.Forms.NumericUpDown();
            this.TxbCikkszam = new System.Windows.Forms.TextBox();
            this.TxbMegnevezes = new System.Windows.Forms.TextBox();
            this.LblDarabszam = new System.Windows.Forms.Label();
            this.LblAr = new System.Windows.Forms.Label();
            this.LblCikkszam = new System.Windows.Forms.Label();
            this.LblMegnevezes = new System.Windows.Forms.Label();
            this.LblValasztas = new System.Windows.Forms.Label();
            this.CmbValasztas = new System.Windows.Forms.ComboBox();
            this.GrbTejtermek = new System.Windows.Forms.GroupBox();
            this.CmbTejtermekTipus = new System.Windows.Forms.ComboBox();
            this.NudZsirtartalom = new System.Windows.Forms.NumericUpDown();
            this.LblTejtermekTipus = new System.Windows.Forms.Label();
            this.LblZsirtartalom = new System.Windows.Forms.Label();
            this.GrbPekaru = new System.Windows.Forms.GroupBox();
            this.ChbTeljesKiorlesu = new System.Windows.Forms.CheckBox();
            this.GrbZoldsegVagyGyumolcs = new System.Windows.Forms.GroupBox();
            this.CmbZoldsegVagyGyumolcs = new System.Windows.Forms.ComboBox();
            this.LblZoldsegVagyGyumolcs = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.GrbAltalanosTermek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDarabszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).BeginInit();
            this.GrbTejtermek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudZsirtartalom)).BeginInit();
            this.GrbPekaru.SuspendLayout();
            this.GrbZoldsegVagyGyumolcs.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbAltalanosTermek
            // 
            this.GrbAltalanosTermek.Controls.Add(this.NudDarabszam);
            this.GrbAltalanosTermek.Controls.Add(this.NudAr);
            this.GrbAltalanosTermek.Controls.Add(this.TxbCikkszam);
            this.GrbAltalanosTermek.Controls.Add(this.TxbMegnevezes);
            this.GrbAltalanosTermek.Controls.Add(this.LblDarabszam);
            this.GrbAltalanosTermek.Controls.Add(this.LblAr);
            this.GrbAltalanosTermek.Controls.Add(this.LblCikkszam);
            this.GrbAltalanosTermek.Controls.Add(this.LblMegnevezes);
            this.GrbAltalanosTermek.Location = new System.Drawing.Point(12, 12);
            this.GrbAltalanosTermek.Name = "GrbAltalanosTermek";
            this.GrbAltalanosTermek.Size = new System.Drawing.Size(370, 135);
            this.GrbAltalanosTermek.TabIndex = 0;
            this.GrbAltalanosTermek.TabStop = false;
            this.GrbAltalanosTermek.Tag = "0";
            this.GrbAltalanosTermek.Text = "Termek altalanos adatai";
            // 
            // NudDarabszam
            // 
            this.NudDarabszam.Location = new System.Drawing.Point(162, 102);
            this.NudDarabszam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDarabszam.Name = "NudDarabszam";
            this.NudDarabszam.Size = new System.Drawing.Size(200, 22);
            this.NudDarabszam.TabIndex = 7;
            this.NudDarabszam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudAr
            // 
            this.NudAr.Location = new System.Drawing.Point(162, 74);
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
            // TxbCikkszam
            // 
            this.TxbCikkszam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbCikkszam.Location = new System.Drawing.Point(162, 46);
            this.TxbCikkszam.Name = "TxbCikkszam";
            this.TxbCikkszam.Size = new System.Drawing.Size(200, 22);
            this.TxbCikkszam.TabIndex = 5;
            // 
            // TxbMegnevezes
            // 
            this.TxbMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbMegnevezes.Location = new System.Drawing.Point(162, 18);
            this.TxbMegnevezes.Name = "TxbMegnevezes";
            this.TxbMegnevezes.Size = new System.Drawing.Size(200, 22);
            this.TxbMegnevezes.TabIndex = 4;
            // 
            // LblDarabszam
            // 
            this.LblDarabszam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDarabszam.Location = new System.Drawing.Point(6, 102);
            this.LblDarabszam.Name = "LblDarabszam";
            this.LblDarabszam.Size = new System.Drawing.Size(150, 22);
            this.LblDarabszam.TabIndex = 3;
            this.LblDarabszam.Text = "Darabszam";
            this.LblDarabszam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAr
            // 
            this.LblAr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAr.Location = new System.Drawing.Point(6, 74);
            this.LblAr.Name = "LblAr";
            this.LblAr.Size = new System.Drawing.Size(150, 22);
            this.LblAr.TabIndex = 2;
            this.LblAr.Text = "Ar";
            this.LblAr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCikkszam
            // 
            this.LblCikkszam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCikkszam.Location = new System.Drawing.Point(6, 46);
            this.LblCikkszam.Name = "LblCikkszam";
            this.LblCikkszam.Size = new System.Drawing.Size(150, 22);
            this.LblCikkszam.TabIndex = 1;
            this.LblCikkszam.Text = "Cikkszam";
            this.LblCikkszam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblMegnevezes
            // 
            this.LblMegnevezes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMegnevezes.Location = new System.Drawing.Point(6, 18);
            this.LblMegnevezes.Name = "LblMegnevezes";
            this.LblMegnevezes.Size = new System.Drawing.Size(150, 22);
            this.LblMegnevezes.TabIndex = 0;
            this.LblMegnevezes.Text = "Megnevezes";
            this.LblMegnevezes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblValasztas
            // 
            this.LblValasztas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblValasztas.Location = new System.Drawing.Point(18, 153);
            this.LblValasztas.Name = "LblValasztas";
            this.LblValasztas.Size = new System.Drawing.Size(150, 24);
            this.LblValasztas.TabIndex = 1;
            this.LblValasztas.Text = "Termek tipusa";
            this.LblValasztas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbValasztas
            // 
            this.CmbValasztas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbValasztas.FormattingEnabled = true;
            this.CmbValasztas.Location = new System.Drawing.Point(174, 153);
            this.CmbValasztas.Name = "CmbValasztas";
            this.CmbValasztas.Size = new System.Drawing.Size(208, 24);
            this.CmbValasztas.TabIndex = 2;
            this.CmbValasztas.SelectedIndexChanged += new System.EventHandler(this.CmbValasztas_SelectedIndexChanged);
            // 
            // GrbTejtermek
            // 
            this.GrbTejtermek.Controls.Add(this.CmbTejtermekTipus);
            this.GrbTejtermek.Controls.Add(this.NudZsirtartalom);
            this.GrbTejtermek.Controls.Add(this.LblTejtermekTipus);
            this.GrbTejtermek.Controls.Add(this.LblZsirtartalom);
            this.GrbTejtermek.Location = new System.Drawing.Point(12, 183);
            this.GrbTejtermek.Name = "GrbTejtermek";
            this.GrbTejtermek.Size = new System.Drawing.Size(370, 79);
            this.GrbTejtermek.TabIndex = 3;
            this.GrbTejtermek.TabStop = false;
            this.GrbTejtermek.Tag = "1";
            this.GrbTejtermek.Text = "Tejtermek adatai";
            // 
            // CmbTejtermekTipus
            // 
            this.CmbTejtermekTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTejtermekTipus.FormattingEnabled = true;
            this.CmbTejtermekTipus.Location = new System.Drawing.Point(162, 47);
            this.CmbTejtermekTipus.Name = "CmbTejtermekTipus";
            this.CmbTejtermekTipus.Size = new System.Drawing.Size(202, 24);
            this.CmbTejtermekTipus.TabIndex = 3;
            // 
            // NudZsirtartalom
            // 
            this.NudZsirtartalom.DecimalPlaces = 2;
            this.NudZsirtartalom.Location = new System.Drawing.Point(162, 21);
            this.NudZsirtartalom.Name = "NudZsirtartalom";
            this.NudZsirtartalom.Size = new System.Drawing.Size(202, 22);
            this.NudZsirtartalom.TabIndex = 2;
            // 
            // LblTejtermekTipus
            // 
            this.LblTejtermekTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTejtermekTipus.Location = new System.Drawing.Point(6, 47);
            this.LblTejtermekTipus.Name = "LblTejtermekTipus";
            this.LblTejtermekTipus.Size = new System.Drawing.Size(150, 24);
            this.LblTejtermekTipus.TabIndex = 1;
            this.LblTejtermekTipus.Text = "Tejtermek tipus";
            this.LblTejtermekTipus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblZsirtartalom
            // 
            this.LblZsirtartalom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblZsirtartalom.Location = new System.Drawing.Point(6, 21);
            this.LblZsirtartalom.Name = "LblZsirtartalom";
            this.LblZsirtartalom.Size = new System.Drawing.Size(150, 22);
            this.LblZsirtartalom.TabIndex = 0;
            this.LblZsirtartalom.Text = "Zsirtartalom";
            // 
            // GrbPekaru
            // 
            this.GrbPekaru.Controls.Add(this.ChbTeljesKiorlesu);
            this.GrbPekaru.Location = new System.Drawing.Point(12, 268);
            this.GrbPekaru.Name = "GrbPekaru";
            this.GrbPekaru.Size = new System.Drawing.Size(370, 49);
            this.GrbPekaru.TabIndex = 4;
            this.GrbPekaru.TabStop = false;
            this.GrbPekaru.Tag = "2";
            this.GrbPekaru.Text = "Pekaru adatai";
            // 
            // ChbTeljesKiorlesu
            // 
            this.ChbTeljesKiorlesu.Location = new System.Drawing.Point(6, 21);
            this.ChbTeljesKiorlesu.Name = "ChbTeljesKiorlesu";
            this.ChbTeljesKiorlesu.Size = new System.Drawing.Size(150, 22);
            this.ChbTeljesKiorlesu.TabIndex = 0;
            this.ChbTeljesKiorlesu.Text = "Teljes kiorlesu-e";
            this.ChbTeljesKiorlesu.UseVisualStyleBackColor = true;
            // 
            // GrbZoldsegVagyGyumolcs
            // 
            this.GrbZoldsegVagyGyumolcs.Controls.Add(this.CmbZoldsegVagyGyumolcs);
            this.GrbZoldsegVagyGyumolcs.Controls.Add(this.LblZoldsegVagyGyumolcs);
            this.GrbZoldsegVagyGyumolcs.Location = new System.Drawing.Point(12, 323);
            this.GrbZoldsegVagyGyumolcs.Name = "GrbZoldsegVagyGyumolcs";
            this.GrbZoldsegVagyGyumolcs.Size = new System.Drawing.Size(370, 53);
            this.GrbZoldsegVagyGyumolcs.TabIndex = 5;
            this.GrbZoldsegVagyGyumolcs.TabStop = false;
            this.GrbZoldsegVagyGyumolcs.Tag = "3";
            this.GrbZoldsegVagyGyumolcs.Text = "Zoldseg vagy gyumolcs adatai";
            // 
            // CmbZoldsegVagyGyumolcs
            // 
            this.CmbZoldsegVagyGyumolcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbZoldsegVagyGyumolcs.FormattingEnabled = true;
            this.CmbZoldsegVagyGyumolcs.Location = new System.Drawing.Point(162, 22);
            this.CmbZoldsegVagyGyumolcs.Name = "CmbZoldsegVagyGyumolcs";
            this.CmbZoldsegVagyGyumolcs.Size = new System.Drawing.Size(202, 24);
            this.CmbZoldsegVagyGyumolcs.TabIndex = 1;
            // 
            // LblZoldsegVagyGyumolcs
            // 
            this.LblZoldsegVagyGyumolcs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblZoldsegVagyGyumolcs.Location = new System.Drawing.Point(6, 22);
            this.LblZoldsegVagyGyumolcs.Name = "LblZoldsegVagyGyumolcs";
            this.LblZoldsegVagyGyumolcs.Size = new System.Drawing.Size(149, 24);
            this.LblZoldsegVagyGyumolcs.TabIndex = 0;
            this.LblZoldsegVagyGyumolcs.Text = "Tipus";
            this.LblZoldsegVagyGyumolcs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(174, 382);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 30);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(282, 382);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(100, 30);
            this.BtnMegsem.TabIndex = 7;
            this.BtnMegsem.Text = "Megsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmTermek
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(394, 424);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrbZoldsegVagyGyumolcs);
            this.Controls.Add(this.GrbPekaru);
            this.Controls.Add(this.GrbTejtermek);
            this.Controls.Add(this.CmbValasztas);
            this.Controls.Add(this.LblValasztas);
            this.Controls.Add(this.GrbAltalanosTermek);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTermek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GrbAltalanosTermek.ResumeLayout(false);
            this.GrbAltalanosTermek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDarabszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAr)).EndInit();
            this.GrbTejtermek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudZsirtartalom)).EndInit();
            this.GrbPekaru.ResumeLayout(false);
            this.GrbZoldsegVagyGyumolcs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbAltalanosTermek;
        private System.Windows.Forms.Label LblDarabszam;
        private System.Windows.Forms.Label LblAr;
        private System.Windows.Forms.Label LblCikkszam;
        private System.Windows.Forms.Label LblMegnevezes;
        private System.Windows.Forms.NumericUpDown NudDarabszam;
        private System.Windows.Forms.NumericUpDown NudAr;
        private System.Windows.Forms.TextBox TxbCikkszam;
        private System.Windows.Forms.TextBox TxbMegnevezes;
        private System.Windows.Forms.Label LblValasztas;
        private System.Windows.Forms.ComboBox CmbValasztas;
        private System.Windows.Forms.GroupBox GrbTejtermek;
        private System.Windows.Forms.ComboBox CmbTejtermekTipus;
        private System.Windows.Forms.NumericUpDown NudZsirtartalom;
        private System.Windows.Forms.Label LblTejtermekTipus;
        private System.Windows.Forms.Label LblZsirtartalom;
        private System.Windows.Forms.GroupBox GrbPekaru;
        private System.Windows.Forms.CheckBox ChbTeljesKiorlesu;
        private System.Windows.Forms.GroupBox GrbZoldsegVagyGyumolcs;
        private System.Windows.Forms.ComboBox CmbZoldsegVagyGyumolcs;
        private System.Windows.Forms.Label LblZoldsegVagyGyumolcs;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
    }
}