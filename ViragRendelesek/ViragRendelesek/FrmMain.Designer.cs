namespace ViragRendelesek
{
    partial class FrmMain
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
            this.LsbRendelesek = new System.Windows.Forms.ListBox();
            this.LsbViragok = new System.Windows.Forms.ListBox();
            this.BtnRendelesLeadasa = new System.Windows.Forms.Button();
            this.GrbUjVirag = new System.Windows.Forms.GroupBox();
            this.TxbViragNeve = new System.Windows.Forms.TextBox();
            this.CmbViragTipus = new System.Windows.Forms.ComboBox();
            this.NudViragDarabszama = new System.Windows.Forms.NumericUpDown();
            this.NudViragAra = new System.Windows.Forms.NumericUpDown();
            this.LblViragTipusa = new System.Windows.Forms.Label();
            this.LblViragDarabszama = new System.Windows.Forms.Label();
            this.LblViragAra = new System.Windows.Forms.Label();
            this.LblViragNeve = new System.Windows.Forms.Label();
            this.BtnViragFelvitele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrbUjVirag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudViragDarabszama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudViragAra)).BeginInit();
            this.SuspendLayout();
            // 
            // LsbRendelesek
            // 
            this.LsbRendelesek.FormattingEnabled = true;
            this.LsbRendelesek.ItemHeight = 16;
            this.LsbRendelesek.Location = new System.Drawing.Point(12, 9);
            this.LsbRendelesek.Name = "LsbRendelesek";
            this.LsbRendelesek.Size = new System.Drawing.Size(491, 708);
            this.LsbRendelesek.TabIndex = 0;
            // 
            // LsbViragok
            // 
            this.LsbViragok.FormattingEnabled = true;
            this.LsbViragok.ItemHeight = 16;
            this.LsbViragok.Location = new System.Drawing.Point(509, 9);
            this.LsbViragok.Name = "LsbViragok";
            this.LsbViragok.Size = new System.Drawing.Size(487, 324);
            this.LsbViragok.TabIndex = 1;
            this.LsbViragok.SelectedIndexChanged += new System.EventHandler(this.LsbViragok_SelectedIndexChanged);
            // 
            // BtnRendelesLeadasa
            // 
            this.BtnRendelesLeadasa.Location = new System.Drawing.Point(509, 342);
            this.BtnRendelesLeadasa.Name = "BtnRendelesLeadasa";
            this.BtnRendelesLeadasa.Size = new System.Drawing.Size(487, 40);
            this.BtnRendelesLeadasa.TabIndex = 2;
            this.BtnRendelesLeadasa.Text = "Rendeles Leadasa";
            this.BtnRendelesLeadasa.UseVisualStyleBackColor = true;
            this.BtnRendelesLeadasa.Click += new System.EventHandler(this.BtnRendelesLeadasa_Click);
            // 
            // GrbUjVirag
            // 
            this.GrbUjVirag.Controls.Add(this.TxbViragNeve);
            this.GrbUjVirag.Controls.Add(this.CmbViragTipus);
            this.GrbUjVirag.Controls.Add(this.NudViragDarabszama);
            this.GrbUjVirag.Controls.Add(this.NudViragAra);
            this.GrbUjVirag.Controls.Add(this.LblViragTipusa);
            this.GrbUjVirag.Controls.Add(this.LblViragDarabszama);
            this.GrbUjVirag.Controls.Add(this.LblViragAra);
            this.GrbUjVirag.Controls.Add(this.LblViragNeve);
            this.GrbUjVirag.Location = new System.Drawing.Point(509, 388);
            this.GrbUjVirag.Name = "GrbUjVirag";
            this.GrbUjVirag.Size = new System.Drawing.Size(487, 135);
            this.GrbUjVirag.TabIndex = 3;
            this.GrbUjVirag.TabStop = false;
            this.GrbUjVirag.Text = "Uj Virag";
            // 
            // TxbViragNeve
            // 
            this.TxbViragNeve.Location = new System.Drawing.Point(162, 18);
            this.TxbViragNeve.MaxLength = 30;
            this.TxbViragNeve.Name = "TxbViragNeve";
            this.TxbViragNeve.Size = new System.Drawing.Size(319, 22);
            this.TxbViragNeve.TabIndex = 7;
            // 
            // CmbViragTipus
            // 
            this.CmbViragTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbViragTipus.FormattingEnabled = true;
            this.CmbViragTipus.Location = new System.Drawing.Point(162, 102);
            this.CmbViragTipus.Name = "CmbViragTipus";
            this.CmbViragTipus.Size = new System.Drawing.Size(319, 24);
            this.CmbViragTipus.TabIndex = 6;
            // 
            // NudViragDarabszama
            // 
            this.NudViragDarabszama.Location = new System.Drawing.Point(162, 74);
            this.NudViragDarabszama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudViragDarabszama.Name = "NudViragDarabszama";
            this.NudViragDarabszama.Size = new System.Drawing.Size(319, 22);
            this.NudViragDarabszama.TabIndex = 5;
            this.NudViragDarabszama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudViragAra
            // 
            this.NudViragAra.Location = new System.Drawing.Point(162, 46);
            this.NudViragAra.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudViragAra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudViragAra.Name = "NudViragAra";
            this.NudViragAra.Size = new System.Drawing.Size(319, 22);
            this.NudViragAra.TabIndex = 4;
            this.NudViragAra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblViragTipusa
            // 
            this.LblViragTipusa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblViragTipusa.Location = new System.Drawing.Point(6, 102);
            this.LblViragTipusa.Name = "LblViragTipusa";
            this.LblViragTipusa.Size = new System.Drawing.Size(150, 24);
            this.LblViragTipusa.TabIndex = 3;
            this.LblViragTipusa.Text = "Virag Tipusa";
            this.LblViragTipusa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblViragDarabszama
            // 
            this.LblViragDarabszama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblViragDarabszama.Location = new System.Drawing.Point(6, 75);
            this.LblViragDarabszama.Name = "LblViragDarabszama";
            this.LblViragDarabszama.Size = new System.Drawing.Size(150, 22);
            this.LblViragDarabszama.TabIndex = 2;
            this.LblViragDarabszama.Text = "Virag Darabszama";
            this.LblViragDarabszama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblViragAra
            // 
            this.LblViragAra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblViragAra.Location = new System.Drawing.Point(6, 46);
            this.LblViragAra.Name = "LblViragAra";
            this.LblViragAra.Size = new System.Drawing.Size(150, 22);
            this.LblViragAra.TabIndex = 1;
            this.LblViragAra.Text = "Virag Ara";
            this.LblViragAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblViragNeve
            // 
            this.LblViragNeve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblViragNeve.Location = new System.Drawing.Point(6, 18);
            this.LblViragNeve.Name = "LblViragNeve";
            this.LblViragNeve.Size = new System.Drawing.Size(150, 22);
            this.LblViragNeve.TabIndex = 0;
            this.LblViragNeve.Text = "Virag Neve";
            this.LblViragNeve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnViragFelvitele
            // 
            this.BtnViragFelvitele.Location = new System.Drawing.Point(509, 529);
            this.BtnViragFelvitele.Name = "BtnViragFelvitele";
            this.BtnViragFelvitele.Size = new System.Drawing.Size(481, 40);
            this.BtnViragFelvitele.TabIndex = 8;
            this.BtnViragFelvitele.Text = "Virag Felvitele";
            this.BtnViragFelvitele.UseVisualStyleBackColor = true;
            this.BtnViragFelvitele.Click += new System.EventHandler(this.BtnViragFelvitele_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(512, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 66);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(512, 658);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 59);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnViragFelvitele);
            this.Controls.Add(this.GrbUjVirag);
            this.Controls.Add(this.BtnRendelesLeadasa);
            this.Controls.Add(this.LsbViragok);
            this.Controls.Add(this.LsbRendelesek);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viragrendelesek Kezelese";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GrbUjVirag.ResumeLayout(false);
            this.GrbUjVirag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudViragDarabszama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudViragAra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbRendelesek;
        private System.Windows.Forms.ListBox LsbViragok;
        private System.Windows.Forms.Button BtnRendelesLeadasa;
        private System.Windows.Forms.GroupBox GrbUjVirag;
        private System.Windows.Forms.Button BtnViragFelvitele;
        private System.Windows.Forms.TextBox TxbViragNeve;
        private System.Windows.Forms.ComboBox CmbViragTipus;
        private System.Windows.Forms.NumericUpDown NudViragDarabszama;
        private System.Windows.Forms.NumericUpDown NudViragAra;
        private System.Windows.Forms.Label LblViragTipusa;
        private System.Windows.Forms.Label LblViragDarabszama;
        private System.Windows.Forms.Label LblViragAra;
        private System.Windows.Forms.Label LblViragNeve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

