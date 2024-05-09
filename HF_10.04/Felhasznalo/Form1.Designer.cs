namespace Felhasznalo
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
            this.LblFelhasznaloBejelnetkezettFelhasznalo = new System.Windows.Forms.Label();
            this.LsbFelhasznaloJarmuvek = new System.Windows.Forms.ListBox();
            this.GrbFelhasznaloJarmuvek = new System.Windows.Forms.GroupBox();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.BtnFelhasznaloValtas = new System.Windows.Forms.Button();
            this.BtnJarmuKolcsonzese = new System.Windows.Forms.Button();
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa = new System.Windows.Forms.Button();
            this.GrbFelhasznaloJarmuvek.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFelhasznaloBejelnetkezettFelhasznalo
            // 
            this.LblFelhasznaloBejelnetkezettFelhasznalo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFelhasznaloBejelnetkezettFelhasznalo.Location = new System.Drawing.Point(12, 9);
            this.LblFelhasznaloBejelnetkezettFelhasznalo.Name = "LblFelhasznaloBejelnetkezettFelhasznalo";
            this.LblFelhasznaloBejelnetkezettFelhasznalo.Size = new System.Drawing.Size(356, 20);
            this.LblFelhasznaloBejelnetkezettFelhasznalo.TabIndex = 0;
            this.LblFelhasznaloBejelnetkezettFelhasznalo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LsbFelhasznaloJarmuvek
            // 
            this.LsbFelhasznaloJarmuvek.FormattingEnabled = true;
            this.LsbFelhasznaloJarmuvek.HorizontalScrollbar = true;
            this.LsbFelhasznaloJarmuvek.ItemHeight = 16;
            this.LsbFelhasznaloJarmuvek.Location = new System.Drawing.Point(6, 21);
            this.LsbFelhasznaloJarmuvek.Name = "LsbFelhasznaloJarmuvek";
            this.LsbFelhasznaloJarmuvek.Size = new System.Drawing.Size(344, 196);
            this.LsbFelhasznaloJarmuvek.TabIndex = 1;
            // 
            // GrbFelhasznaloJarmuvek
            // 
            this.GrbFelhasznaloJarmuvek.Controls.Add(this.BtnFelhasznaloJarmukolcsonzesVisszavonasa);
            this.GrbFelhasznaloJarmuvek.Controls.Add(this.BtnKilepes);
            this.GrbFelhasznaloJarmuvek.Controls.Add(this.BtnFelhasznaloValtas);
            this.GrbFelhasznaloJarmuvek.Controls.Add(this.BtnJarmuKolcsonzese);
            this.GrbFelhasznaloJarmuvek.Controls.Add(this.LsbFelhasznaloJarmuvek);
            this.GrbFelhasznaloJarmuvek.Location = new System.Drawing.Point(12, 32);
            this.GrbFelhasznaloJarmuvek.Name = "GrbFelhasznaloJarmuvek";
            this.GrbFelhasznaloJarmuvek.Size = new System.Drawing.Size(356, 370);
            this.GrbFelhasznaloJarmuvek.TabIndex = 2;
            this.GrbFelhasznaloJarmuvek.TabStop = false;
            this.GrbFelhasznaloJarmuvek.Text = "Járművek";
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.Location = new System.Drawing.Point(6, 331);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(344, 30);
            this.BtnKilepes.TabIndex = 4;
            this.BtnKilepes.Text = "Kilépés";
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // BtnFelhasznaloValtas
            // 
            this.BtnFelhasznaloValtas.Location = new System.Drawing.Point(6, 295);
            this.BtnFelhasznaloValtas.Name = "BtnFelhasznaloValtas";
            this.BtnFelhasznaloValtas.Size = new System.Drawing.Size(344, 30);
            this.BtnFelhasznaloValtas.TabIndex = 3;
            this.BtnFelhasznaloValtas.Text = "Felhasználóváltás";
            this.BtnFelhasznaloValtas.UseVisualStyleBackColor = true;
            this.BtnFelhasznaloValtas.Click += new System.EventHandler(this.BtnFelhasznaloValtas_Click);
            // 
            // BtnJarmuKolcsonzese
            // 
            this.BtnJarmuKolcsonzese.Location = new System.Drawing.Point(6, 223);
            this.BtnJarmuKolcsonzese.Name = "BtnJarmuKolcsonzese";
            this.BtnJarmuKolcsonzese.Size = new System.Drawing.Size(344, 30);
            this.BtnJarmuKolcsonzese.TabIndex = 2;
            this.BtnJarmuKolcsonzese.Text = "Jármű kölcsönzése";
            this.BtnJarmuKolcsonzese.UseVisualStyleBackColor = true;
            this.BtnJarmuKolcsonzese.Click += new System.EventHandler(this.BtnJarmuKolcsonzese_Click);
            // 
            // BtnFelhasznaloJarmukolcsonzesVisszavonasa
            // 
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa.Location = new System.Drawing.Point(6, 259);
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa.Name = "BtnFelhasznaloJarmukolcsonzesVisszavonasa";
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa.Size = new System.Drawing.Size(344, 30);
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa.TabIndex = 5;
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa.Text = "Jármű kölcsönzésének visszavonása";
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa.UseVisualStyleBackColor = true;
            this.BtnFelhasznaloJarmukolcsonzesVisszavonasa.Click += new System.EventHandler(this.BtnFelhasznaloJarmukolcsonzesVisszavonasa_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 409);
            this.Controls.Add(this.GrbFelhasznaloJarmuvek);
            this.Controls.Add(this.LblFelhasznaloBejelnetkezettFelhasznalo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felhasználó felület";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GrbFelhasznaloJarmuvek.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblFelhasznaloBejelnetkezettFelhasznalo;
        private System.Windows.Forms.ListBox LsbFelhasznaloJarmuvek;
        private System.Windows.Forms.GroupBox GrbFelhasznaloJarmuvek;
        private System.Windows.Forms.Button BtnKilepes;
        private System.Windows.Forms.Button BtnFelhasznaloValtas;
        private System.Windows.Forms.Button BtnJarmuKolcsonzese;
        private System.Windows.Forms.Button BtnFelhasznaloJarmukolcsonzesVisszavonasa;
    }
}

