namespace GepAlkatreszekAbstract
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LsbAdatok = new System.Windows.Forms.ListBox();
            this.GrbFunkciok = new System.Windows.Forms.GroupBox();
            this.BtnTorles = new System.Windows.Forms.Button();
            this.BtnMegjelenites = new System.Windows.Forms.Button();
            this.BtnModositas = new System.Windows.Forms.Button();
            this.BtnLetrehozas = new System.Windows.Forms.Button();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.TxbAlapanyagAr = new System.Windows.Forms.TextBox();
            this.ImlIkonok = new System.Windows.Forms.ImageList(this.components);
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
            this.LsbAdatok.Size = new System.Drawing.Size(766, 708);
            this.LsbAdatok.TabIndex = 0;
            this.LsbAdatok.SelectedIndexChanged += new System.EventHandler(this.LsbAdatok_SelectedIndexChanged);
            this.LsbAdatok.DoubleClick += new System.EventHandler(this.LsbAdatok_DoubleClick);
            // 
            // GrbFunkciok
            // 
            this.GrbFunkciok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbFunkciok.Controls.Add(this.BtnTorles);
            this.GrbFunkciok.Controls.Add(this.BtnMegjelenites);
            this.GrbFunkciok.Controls.Add(this.BtnModositas);
            this.GrbFunkciok.Controls.Add(this.BtnLetrehozas);
            this.GrbFunkciok.Location = new System.Drawing.Point(784, 12);
            this.GrbFunkciok.Name = "GrbFunkciok";
            this.GrbFunkciok.Size = new System.Drawing.Size(212, 205);
            this.GrbFunkciok.TabIndex = 1;
            this.GrbFunkciok.TabStop = false;
            this.GrbFunkciok.Text = "Funkciók";
            // 
            // BtnTorles
            // 
            this.BtnTorles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTorles.ImageKey = "Delete.png";
            this.BtnTorles.ImageList = this.ImlIkonok;
            this.BtnTorles.Location = new System.Drawing.Point(6, 159);
            this.BtnTorles.Name = "BtnTorles";
            this.BtnTorles.Size = new System.Drawing.Size(200, 40);
            this.BtnTorles.TabIndex = 3;
            this.BtnTorles.Text = "Törlés";
            this.BtnTorles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTorles.UseVisualStyleBackColor = true;
            this.BtnTorles.Click += new System.EventHandler(this.BtnTorles_Click);
            this.BtnTorles.MouseLeave += new System.EventHandler(this.BtnLetrehozas_MouseLeave);
            this.BtnTorles.MouseHover += new System.EventHandler(this.BtnLetrehozas_MouseHover);
            // 
            // BtnMegjelenites
            // 
            this.BtnMegjelenites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMegjelenites.ImageKey = "Preview.png";
            this.BtnMegjelenites.ImageList = this.ImlIkonok;
            this.BtnMegjelenites.Location = new System.Drawing.Point(6, 113);
            this.BtnMegjelenites.Name = "BtnMegjelenites";
            this.BtnMegjelenites.Size = new System.Drawing.Size(200, 40);
            this.BtnMegjelenites.TabIndex = 2;
            this.BtnMegjelenites.Text = "Megjelenítés";
            this.BtnMegjelenites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMegjelenites.UseVisualStyleBackColor = true;
            this.BtnMegjelenites.Click += new System.EventHandler(this.BtnMegjelenites_Click);
            this.BtnMegjelenites.MouseLeave += new System.EventHandler(this.BtnLetrehozas_MouseLeave);
            this.BtnMegjelenites.MouseHover += new System.EventHandler(this.BtnLetrehozas_MouseHover);
            // 
            // BtnModositas
            // 
            this.BtnModositas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModositas.ImageKey = "Edit.png";
            this.BtnModositas.ImageList = this.ImlIkonok;
            this.BtnModositas.Location = new System.Drawing.Point(6, 67);
            this.BtnModositas.Name = "BtnModositas";
            this.BtnModositas.Size = new System.Drawing.Size(200, 40);
            this.BtnModositas.TabIndex = 1;
            this.BtnModositas.Text = "Módosítás";
            this.BtnModositas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModositas.UseVisualStyleBackColor = true;
            this.BtnModositas.Click += new System.EventHandler(this.BtnModositas_Click);
            this.BtnModositas.MouseLeave += new System.EventHandler(this.BtnLetrehozas_MouseLeave);
            this.BtnModositas.MouseHover += new System.EventHandler(this.BtnLetrehozas_MouseHover);
            // 
            // BtnLetrehozas
            // 
            this.BtnLetrehozas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLetrehozas.ImageKey = "New.png";
            this.BtnLetrehozas.ImageList = this.ImlIkonok;
            this.BtnLetrehozas.Location = new System.Drawing.Point(6, 21);
            this.BtnLetrehozas.Name = "BtnLetrehozas";
            this.BtnLetrehozas.Size = new System.Drawing.Size(200, 40);
            this.BtnLetrehozas.TabIndex = 0;
            this.BtnLetrehozas.Text = "Létrehozás";
            this.BtnLetrehozas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLetrehozas.UseVisualStyleBackColor = true;
            this.BtnLetrehozas.Click += new System.EventHandler(this.BtnLetrehozas_Click);
            this.BtnLetrehozas.MouseLeave += new System.EventHandler(this.BtnLetrehozas_MouseLeave);
            this.BtnLetrehozas.MouseHover += new System.EventHandler(this.BtnLetrehozas_MouseHover);
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKilepes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKilepes.ImageKey = "Close.png";
            this.BtnKilepes.ImageList = this.ImlIkonok;
            this.BtnKilepes.Location = new System.Drawing.Point(790, 677);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(200, 40);
            this.BtnKilepes.TabIndex = 2;
            this.BtnKilepes.Text = "Kilépés";
            this.BtnKilepes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            this.BtnKilepes.MouseLeave += new System.EventHandler(this.BtnLetrehozas_MouseLeave);
            this.BtnKilepes.MouseHover += new System.EventHandler(this.BtnLetrehozas_MouseHover);
            // 
            // TxbAlapanyagAr
            // 
            this.TxbAlapanyagAr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbAlapanyagAr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbAlapanyagAr.Location = new System.Drawing.Point(784, 223);
            this.TxbAlapanyagAr.Name = "TxbAlapanyagAr";
            this.TxbAlapanyagAr.ReadOnly = true;
            this.TxbAlapanyagAr.Size = new System.Drawing.Size(212, 22);
            this.TxbAlapanyagAr.TabIndex = 3;
            // 
            // ImlIkonok
            // 
            this.ImlIkonok.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlIkonok.ImageStream")));
            this.ImlIkonok.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlIkonok.Images.SetKeyName(0, "New.png");
            this.ImlIkonok.Images.SetKeyName(1, "Edit.png");
            this.ImlIkonok.Images.SetKeyName(2, "Preview.png");
            this.ImlIkonok.Images.SetKeyName(3, "Delete.png");
            this.ImlIkonok.Images.SetKeyName(4, "Ok.png");
            this.ImlIkonok.Images.SetKeyName(5, "Cancel.png");
            this.ImlIkonok.Images.SetKeyName(6, "Close.png");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnKilepes;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TxbAlapanyagAr);
            this.Controls.Add(this.BtnKilepes);
            this.Controls.Add(this.GrbFunkciok);
            this.Controls.Add(this.LsbAdatok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gépalkatrész Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.GrbFunkciok.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LsbAdatok;
        private System.Windows.Forms.GroupBox GrbFunkciok;
        private System.Windows.Forms.Button BtnTorles;
        private System.Windows.Forms.Button BtnMegjelenites;
        private System.Windows.Forms.Button BtnModositas;
        private System.Windows.Forms.Button BtnLetrehozas;
        private System.Windows.Forms.Button BtnKilepes;
        private System.Windows.Forms.TextBox TxbAlapanyagAr;
        private System.Windows.Forms.ImageList ImlIkonok;
    }
}

