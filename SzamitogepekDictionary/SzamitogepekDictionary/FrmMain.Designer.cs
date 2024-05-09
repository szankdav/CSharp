namespace SzamitogepekDictionary
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
            this.LblIPCimek = new System.Windows.Forms.Label();
            this.LblMACCimek = new System.Windows.Forms.Label();
            this.LsbIPCimek = new System.Windows.Forms.ListBox();
            this.LsbMACCimek = new System.Windows.Forms.ListBox();
            this.GrbAdatok = new System.Windows.Forms.GroupBox();
            this.LblTulajdonos = new System.Windows.Forms.Label();
            this.LblOperaciosRendszer = new System.Windows.Forms.Label();
            this.BtnUjSzamitogep = new System.Windows.Forms.Button();
            this.GrbAdatok.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblIPCimek
            // 
            this.LblIPCimek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIPCimek.Location = new System.Drawing.Point(12, 9);
            this.LblIPCimek.Name = "LblIPCimek";
            this.LblIPCimek.Size = new System.Drawing.Size(100, 22);
            this.LblIPCimek.TabIndex = 0;
            this.LblIPCimek.Text = "IP cimek";
            this.LblIPCimek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMACCimek
            // 
            this.LblMACCimek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMACCimek.Location = new System.Drawing.Point(218, 9);
            this.LblMACCimek.Name = "LblMACCimek";
            this.LblMACCimek.Size = new System.Drawing.Size(100, 22);
            this.LblMACCimek.TabIndex = 1;
            this.LblMACCimek.Text = "MAC cimek";
            this.LblMACCimek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LsbIPCimek
            // 
            this.LsbIPCimek.FormattingEnabled = true;
            this.LsbIPCimek.ItemHeight = 16;
            this.LsbIPCimek.Location = new System.Drawing.Point(12, 34);
            this.LsbIPCimek.Name = "LsbIPCimek";
            this.LsbIPCimek.Size = new System.Drawing.Size(200, 372);
            this.LsbIPCimek.TabIndex = 2;
            this.LsbIPCimek.SelectedIndexChanged += new System.EventHandler(this.LsbIPCimek_SelectedIndexChanged);
            // 
            // LsbMACCimek
            // 
            this.LsbMACCimek.FormattingEnabled = true;
            this.LsbMACCimek.ItemHeight = 16;
            this.LsbMACCimek.Location = new System.Drawing.Point(218, 34);
            this.LsbMACCimek.Name = "LsbMACCimek";
            this.LsbMACCimek.Size = new System.Drawing.Size(200, 372);
            this.LsbMACCimek.TabIndex = 3;
            this.LsbMACCimek.SelectedIndexChanged += new System.EventHandler(this.LsbMACCimek_SelectedIndexChanged);
            // 
            // GrbAdatok
            // 
            this.GrbAdatok.Controls.Add(this.LblTulajdonos);
            this.GrbAdatok.Controls.Add(this.LblOperaciosRendszer);
            this.GrbAdatok.Location = new System.Drawing.Point(424, 9);
            this.GrbAdatok.Name = "GrbAdatok";
            this.GrbAdatok.Size = new System.Drawing.Size(348, 397);
            this.GrbAdatok.TabIndex = 4;
            this.GrbAdatok.TabStop = false;
            this.GrbAdatok.Text = "Szamitogep adatai";
            // 
            // LblTulajdonos
            // 
            this.LblTulajdonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTulajdonos.Location = new System.Drawing.Point(6, 47);
            this.LblTulajdonos.Name = "LblTulajdonos";
            this.LblTulajdonos.Size = new System.Drawing.Size(336, 22);
            this.LblTulajdonos.TabIndex = 1;
            // 
            // LblOperaciosRendszer
            // 
            this.LblOperaciosRendszer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblOperaciosRendszer.Location = new System.Drawing.Point(6, 25);
            this.LblOperaciosRendszer.Name = "LblOperaciosRendszer";
            this.LblOperaciosRendszer.Size = new System.Drawing.Size(336, 22);
            this.LblOperaciosRendszer.TabIndex = 0;
            // 
            // BtnUjSzamitogep
            // 
            this.BtnUjSzamitogep.Location = new System.Drawing.Point(12, 419);
            this.BtnUjSzamitogep.Name = "BtnUjSzamitogep";
            this.BtnUjSzamitogep.Size = new System.Drawing.Size(760, 30);
            this.BtnUjSzamitogep.TabIndex = 5;
            this.BtnUjSzamitogep.Text = "Uj szamitogep";
            this.BtnUjSzamitogep.UseVisualStyleBackColor = true;
            this.BtnUjSzamitogep.Click += new System.EventHandler(this.BtnUjSzamitogep_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BtnUjSzamitogep);
            this.Controls.Add(this.GrbAdatok);
            this.Controls.Add(this.LsbMACCimek);
            this.Controls.Add(this.LsbIPCimek);
            this.Controls.Add(this.LblMACCimek);
            this.Controls.Add(this.LblIPCimek);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szamitogepek Dictionary pelda";
            this.GrbAdatok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblIPCimek;
        private System.Windows.Forms.Label LblMACCimek;
        private System.Windows.Forms.ListBox LsbIPCimek;
        private System.Windows.Forms.ListBox LsbMACCimek;
        private System.Windows.Forms.GroupBox GrbAdatok;
        private System.Windows.Forms.Button BtnUjSzamitogep;
        private System.Windows.Forms.Label LblTulajdonos;
        private System.Windows.Forms.Label LblOperaciosRendszer;
    }
}

