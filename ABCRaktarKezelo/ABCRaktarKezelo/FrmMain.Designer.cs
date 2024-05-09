namespace ABCRaktarKezelo
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
            this.LsbAdatok = new System.Windows.Forms.ListBox();
            this.BtnLetrehozas = new System.Windows.Forms.Button();
            this.BtnModositas = new System.Windows.Forms.Button();
            this.BtnMegjelenites = new System.Windows.Forms.Button();
            this.BtnTorles = new System.Windows.Forms.Button();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbAdatok
            // 
            this.LsbAdatok.FormattingEnabled = true;
            this.LsbAdatok.ItemHeight = 16;
            this.LsbAdatok.Location = new System.Drawing.Point(12, 12);
            this.LsbAdatok.Name = "LsbAdatok";
            this.LsbAdatok.Size = new System.Drawing.Size(560, 196);
            this.LsbAdatok.TabIndex = 0;
            // 
            // BtnLetrehozas
            // 
            this.BtnLetrehozas.Location = new System.Drawing.Point(12, 214);
            this.BtnLetrehozas.Name = "BtnLetrehozas";
            this.BtnLetrehozas.Size = new System.Drawing.Size(560, 30);
            this.BtnLetrehozas.TabIndex = 1;
            this.BtnLetrehozas.Text = "Termek letrehozasa";
            this.BtnLetrehozas.UseVisualStyleBackColor = true;
            this.BtnLetrehozas.Click += new System.EventHandler(this.BtnLetrehozas_Click);
            // 
            // BtnModositas
            // 
            this.BtnModositas.Location = new System.Drawing.Point(12, 250);
            this.BtnModositas.Name = "BtnModositas";
            this.BtnModositas.Size = new System.Drawing.Size(560, 30);
            this.BtnModositas.TabIndex = 2;
            this.BtnModositas.Text = "Termek modositasa";
            this.BtnModositas.UseVisualStyleBackColor = true;
            this.BtnModositas.Click += new System.EventHandler(this.BtnModositas_Click);
            // 
            // BtnMegjelenites
            // 
            this.BtnMegjelenites.Location = new System.Drawing.Point(12, 286);
            this.BtnMegjelenites.Name = "BtnMegjelenites";
            this.BtnMegjelenites.Size = new System.Drawing.Size(560, 30);
            this.BtnMegjelenites.TabIndex = 3;
            this.BtnMegjelenites.Text = "Termek megjelenitese";
            this.BtnMegjelenites.UseVisualStyleBackColor = true;
            this.BtnMegjelenites.Click += new System.EventHandler(this.BtnMegjelenites_Click);
            // 
            // BtnTorles
            // 
            this.BtnTorles.Location = new System.Drawing.Point(12, 322);
            this.BtnTorles.Name = "BtnTorles";
            this.BtnTorles.Size = new System.Drawing.Size(560, 30);
            this.BtnTorles.TabIndex = 4;
            this.BtnTorles.Text = "Termek torlese";
            this.BtnTorles.UseVisualStyleBackColor = true;
            this.BtnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.Location = new System.Drawing.Point(12, 358);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(560, 30);
            this.BtnKilepes.TabIndex = 5;
            this.BtnKilepes.Text = "Kilepes";
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.Controls.Add(this.BtnKilepes);
            this.Controls.Add(this.BtnTorles);
            this.Controls.Add(this.BtnMegjelenites);
            this.Controls.Add(this.BtnModositas);
            this.Controls.Add(this.BtnLetrehozas);
            this.Controls.Add(this.LsbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Raktarkezelo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAdatok;
        private System.Windows.Forms.Button BtnLetrehozas;
        private System.Windows.Forms.Button BtnModositas;
        private System.Windows.Forms.Button BtnMegjelenites;
        private System.Windows.Forms.Button BtnTorles;
        private System.Windows.Forms.Button BtnKilepes;
    }
}

