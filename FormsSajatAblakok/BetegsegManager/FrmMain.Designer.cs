namespace BetegsegManager
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
            this.GrbFunkciok = new System.Windows.Forms.GroupBox();
            this.BtnFelvitel = new System.Windows.Forms.Button();
            this.BtnModositas = new System.Windows.Forms.Button();
            this.BtnMegjelenites = new System.Windows.Forms.Button();
            this.BtnTorles = new System.Windows.Forms.Button();
            this.BtnBezaras = new System.Windows.Forms.Button();
            this.GrbFunkciok.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsbAdatok
            // 
            this.LsbAdatok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsbAdatok.FormattingEnabled = true;
            this.LsbAdatok.ItemHeight = 16;
            this.LsbAdatok.Location = new System.Drawing.Point(12, 12);
            this.LsbAdatok.Name = "LsbAdatok";
            this.LsbAdatok.Size = new System.Drawing.Size(778, 708);
            this.LsbAdatok.TabIndex = 0;
            // 
            // GrbFunkciok
            // 
            this.GrbFunkciok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbFunkciok.Controls.Add(this.BtnBezaras);
            this.GrbFunkciok.Controls.Add(this.BtnTorles);
            this.GrbFunkciok.Controls.Add(this.BtnMegjelenites);
            this.GrbFunkciok.Controls.Add(this.BtnModositas);
            this.GrbFunkciok.Controls.Add(this.BtnFelvitel);
            this.GrbFunkciok.Location = new System.Drawing.Point(796, 12);
            this.GrbFunkciok.Name = "GrbFunkciok";
            this.GrbFunkciok.Size = new System.Drawing.Size(200, 708);
            this.GrbFunkciok.TabIndex = 1;
            this.GrbFunkciok.TabStop = false;
            this.GrbFunkciok.Text = "Funkciok";
            // 
            // BtnFelvitel
            // 
            this.BtnFelvitel.Location = new System.Drawing.Point(6, 21);
            this.BtnFelvitel.Name = "BtnFelvitel";
            this.BtnFelvitel.Size = new System.Drawing.Size(188, 40);
            this.BtnFelvitel.TabIndex = 0;
            this.BtnFelvitel.Text = "Uj felvitel";
            this.BtnFelvitel.UseVisualStyleBackColor = true;
            this.BtnFelvitel.Click += new System.EventHandler(this.BtnFelvitel_Click);
            // 
            // BtnModositas
            // 
            this.BtnModositas.Location = new System.Drawing.Point(6, 67);
            this.BtnModositas.Name = "BtnModositas";
            this.BtnModositas.Size = new System.Drawing.Size(188, 40);
            this.BtnModositas.TabIndex = 1;
            this.BtnModositas.Text = "Modositas";
            this.BtnModositas.UseVisualStyleBackColor = true;
            this.BtnModositas.Click += new System.EventHandler(this.BtnModositas_Click);
            // 
            // BtnMegjelenites
            // 
            this.BtnMegjelenites.Location = new System.Drawing.Point(6, 113);
            this.BtnMegjelenites.Name = "BtnMegjelenites";
            this.BtnMegjelenites.Size = new System.Drawing.Size(188, 40);
            this.BtnMegjelenites.TabIndex = 2;
            this.BtnMegjelenites.Text = "Megjelenites";
            this.BtnMegjelenites.UseVisualStyleBackColor = true;
            this.BtnMegjelenites.Click += new System.EventHandler(this.BtnMegjelenites_Click);
            // 
            // BtnTorles
            // 
            this.BtnTorles.Location = new System.Drawing.Point(6, 159);
            this.BtnTorles.Name = "BtnTorles";
            this.BtnTorles.Size = new System.Drawing.Size(188, 40);
            this.BtnTorles.TabIndex = 3;
            this.BtnTorles.Text = "Torles";
            this.BtnTorles.UseVisualStyleBackColor = true;
            this.BtnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            // 
            // BtnBezaras
            // 
            this.BtnBezaras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBezaras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBezaras.Location = new System.Drawing.Point(6, 668);
            this.BtnBezaras.Name = "BtnBezaras";
            this.BtnBezaras.Size = new System.Drawing.Size(188, 40);
            this.BtnBezaras.TabIndex = 4;
            this.BtnBezaras.Text = "Bezaras";
            this.BtnBezaras.UseVisualStyleBackColor = true;
            this.BtnBezaras.Click += new System.EventHandler(this.BtnBezaras_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnBezaras;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.GrbFunkciok);
            this.Controls.Add(this.LsbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Betegseg kezelo alkalmazas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.GrbFunkciok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAdatok;
        private System.Windows.Forms.GroupBox GrbFunkciok;
        private System.Windows.Forms.Button BtnBezaras;
        private System.Windows.Forms.Button BtnTorles;
        private System.Windows.Forms.Button BtnMegjelenites;
        private System.Windows.Forms.Button BtnModositas;
        private System.Windows.Forms.Button BtnFelvitel;
    }
}

