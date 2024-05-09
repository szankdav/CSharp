namespace Admin
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
            this.LblAdminJarmuLista = new System.Windows.Forms.Label();
            this.LblAdminFelhasznalokLista = new System.Windows.Forms.Label();
            this.LsbAdminJarmuLista = new System.Windows.Forms.ListBox();
            this.LsbAdminFelhasznaloLista = new System.Windows.Forms.ListBox();
            this.GrbJarmuKezeles = new System.Windows.Forms.GroupBox();
            this.BtnAdminJarmuTorlese = new System.Windows.Forms.Button();
            this.BtnAdminJarmuMegjelenitese = new System.Windows.Forms.Button();
            this.BtnAdminJarmuModositasa = new System.Windows.Forms.Button();
            this.BtnAdminUjJarmu = new System.Windows.Forms.Button();
            this.GrbFelhasznaloKezeles = new System.Windows.Forms.GroupBox();
            this.BtnAdminFelhasznaloTorlese = new System.Windows.Forms.Button();
            this.BtnAdminFelhasznaloMegjelenitese = new System.Windows.Forms.Button();
            this.BtnAdminFelhasznaloModositasa = new System.Windows.Forms.Button();
            this.BtnAdminUjFelhasznalo = new System.Windows.Forms.Button();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.GrbJarmuKezeles.SuspendLayout();
            this.GrbFelhasznaloKezeles.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAdminJarmuLista
            // 
            this.LblAdminJarmuLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAdminJarmuLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAdminJarmuLista.Location = new System.Drawing.Point(6, 18);
            this.LblAdminJarmuLista.Name = "LblAdminJarmuLista";
            this.LblAdminJarmuLista.Size = new System.Drawing.Size(363, 22);
            this.LblAdminJarmuLista.TabIndex = 0;
            this.LblAdminJarmuLista.Text = "Járművek";
            this.LblAdminJarmuLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAdminFelhasznalokLista
            // 
            this.LblAdminFelhasznalokLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAdminFelhasznalokLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAdminFelhasznalokLista.Location = new System.Drawing.Point(6, 18);
            this.LblAdminFelhasznalokLista.Name = "LblAdminFelhasznalokLista";
            this.LblAdminFelhasznalokLista.Size = new System.Drawing.Size(363, 22);
            this.LblAdminFelhasznalokLista.TabIndex = 1;
            this.LblAdminFelhasznalokLista.Text = "Felhasználók";
            this.LblAdminFelhasznalokLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LsbAdminJarmuLista
            // 
            this.LsbAdminJarmuLista.FormattingEnabled = true;
            this.LsbAdminJarmuLista.HorizontalScrollbar = true;
            this.LsbAdminJarmuLista.ItemHeight = 16;
            this.LsbAdminJarmuLista.Location = new System.Drawing.Point(6, 43);
            this.LsbAdminJarmuLista.Name = "LsbAdminJarmuLista";
            this.LsbAdminJarmuLista.Size = new System.Drawing.Size(363, 212);
            this.LsbAdminJarmuLista.TabIndex = 2;
            this.LsbAdminJarmuLista.SelectedIndexChanged += new System.EventHandler(this.LsbAdminJarmuLista_SelectedIndexChanged);
            // 
            // LsbAdminFelhasznaloLista
            // 
            this.LsbAdminFelhasznaloLista.FormattingEnabled = true;
            this.LsbAdminFelhasznaloLista.HorizontalScrollbar = true;
            this.LsbAdminFelhasznaloLista.ItemHeight = 16;
            this.LsbAdminFelhasznaloLista.Location = new System.Drawing.Point(6, 43);
            this.LsbAdminFelhasznaloLista.Name = "LsbAdminFelhasznaloLista";
            this.LsbAdminFelhasznaloLista.Size = new System.Drawing.Size(363, 212);
            this.LsbAdminFelhasznaloLista.TabIndex = 3;
            this.LsbAdminFelhasznaloLista.SelectedIndexChanged += new System.EventHandler(this.LsbAdminFelhasznaloLista_SelectedIndexChanged);
            // 
            // GrbJarmuKezeles
            // 
            this.GrbJarmuKezeles.Controls.Add(this.BtnAdminJarmuTorlese);
            this.GrbJarmuKezeles.Controls.Add(this.BtnAdminJarmuMegjelenitese);
            this.GrbJarmuKezeles.Controls.Add(this.BtnAdminJarmuModositasa);
            this.GrbJarmuKezeles.Controls.Add(this.BtnAdminUjJarmu);
            this.GrbJarmuKezeles.Controls.Add(this.LsbAdminJarmuLista);
            this.GrbJarmuKezeles.Controls.Add(this.LblAdminJarmuLista);
            this.GrbJarmuKezeles.Location = new System.Drawing.Point(12, 12);
            this.GrbJarmuKezeles.Name = "GrbJarmuKezeles";
            this.GrbJarmuKezeles.Size = new System.Drawing.Size(375, 408);
            this.GrbJarmuKezeles.TabIndex = 4;
            this.GrbJarmuKezeles.TabStop = false;
            this.GrbJarmuKezeles.Text = "Jármű kezelés";
            // 
            // BtnAdminJarmuTorlese
            // 
            this.BtnAdminJarmuTorlese.Location = new System.Drawing.Point(6, 369);
            this.BtnAdminJarmuTorlese.Name = "BtnAdminJarmuTorlese";
            this.BtnAdminJarmuTorlese.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminJarmuTorlese.TabIndex = 6;
            this.BtnAdminJarmuTorlese.Text = "Jármű törlése";
            this.BtnAdminJarmuTorlese.UseVisualStyleBackColor = true;
            this.BtnAdminJarmuTorlese.Click += new System.EventHandler(this.BtnAdminJarmuTorlese_Click);
            // 
            // BtnAdminJarmuMegjelenitese
            // 
            this.BtnAdminJarmuMegjelenitese.Location = new System.Drawing.Point(6, 333);
            this.BtnAdminJarmuMegjelenitese.Name = "BtnAdminJarmuMegjelenitese";
            this.BtnAdminJarmuMegjelenitese.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminJarmuMegjelenitese.TabIndex = 5;
            this.BtnAdminJarmuMegjelenitese.Text = "Jármű megjelenítése";
            this.BtnAdminJarmuMegjelenitese.UseVisualStyleBackColor = true;
            this.BtnAdminJarmuMegjelenitese.Click += new System.EventHandler(this.BtnAdminJarmuMegjelenitese_Click);
            // 
            // BtnAdminJarmuModositasa
            // 
            this.BtnAdminJarmuModositasa.Location = new System.Drawing.Point(6, 297);
            this.BtnAdminJarmuModositasa.Name = "BtnAdminJarmuModositasa";
            this.BtnAdminJarmuModositasa.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminJarmuModositasa.TabIndex = 4;
            this.BtnAdminJarmuModositasa.Text = "Jármű módosítása";
            this.BtnAdminJarmuModositasa.UseVisualStyleBackColor = true;
            this.BtnAdminJarmuModositasa.Click += new System.EventHandler(this.BtnAdminJarmuModositasa_Click);
            // 
            // BtnAdminUjJarmu
            // 
            this.BtnAdminUjJarmu.Location = new System.Drawing.Point(6, 261);
            this.BtnAdminUjJarmu.Name = "BtnAdminUjJarmu";
            this.BtnAdminUjJarmu.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminUjJarmu.TabIndex = 3;
            this.BtnAdminUjJarmu.Text = "Új Jármű hozááadása";
            this.BtnAdminUjJarmu.UseVisualStyleBackColor = true;
            this.BtnAdminUjJarmu.Click += new System.EventHandler(this.BtnAdminUjJarmu_Click);
            // 
            // GrbFelhasznaloKezeles
            // 
            this.GrbFelhasznaloKezeles.Controls.Add(this.BtnAdminFelhasznaloTorlese);
            this.GrbFelhasznaloKezeles.Controls.Add(this.LsbAdminFelhasznaloLista);
            this.GrbFelhasznaloKezeles.Controls.Add(this.BtnAdminFelhasznaloMegjelenitese);
            this.GrbFelhasznaloKezeles.Controls.Add(this.LblAdminFelhasznalokLista);
            this.GrbFelhasznaloKezeles.Controls.Add(this.BtnAdminFelhasznaloModositasa);
            this.GrbFelhasznaloKezeles.Controls.Add(this.BtnAdminUjFelhasznalo);
            this.GrbFelhasznaloKezeles.Location = new System.Drawing.Point(393, 12);
            this.GrbFelhasznaloKezeles.Name = "GrbFelhasznaloKezeles";
            this.GrbFelhasznaloKezeles.Size = new System.Drawing.Size(375, 408);
            this.GrbFelhasznaloKezeles.TabIndex = 5;
            this.GrbFelhasznaloKezeles.TabStop = false;
            this.GrbFelhasznaloKezeles.Text = "Felhasználó kezelés";
            // 
            // BtnAdminFelhasznaloTorlese
            // 
            this.BtnAdminFelhasznaloTorlese.Location = new System.Drawing.Point(6, 369);
            this.BtnAdminFelhasznaloTorlese.Name = "BtnAdminFelhasznaloTorlese";
            this.BtnAdminFelhasznaloTorlese.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminFelhasznaloTorlese.TabIndex = 10;
            this.BtnAdminFelhasznaloTorlese.Text = "Felhasználó törlése";
            this.BtnAdminFelhasznaloTorlese.UseVisualStyleBackColor = true;
            this.BtnAdminFelhasznaloTorlese.Click += new System.EventHandler(this.BtnAdminFelhasznaloTorlese_Click);
            // 
            // BtnAdminFelhasznaloMegjelenitese
            // 
            this.BtnAdminFelhasznaloMegjelenitese.Location = new System.Drawing.Point(6, 333);
            this.BtnAdminFelhasznaloMegjelenitese.Name = "BtnAdminFelhasznaloMegjelenitese";
            this.BtnAdminFelhasznaloMegjelenitese.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminFelhasznaloMegjelenitese.TabIndex = 9;
            this.BtnAdminFelhasznaloMegjelenitese.Text = "Felhasználó megjelenítése";
            this.BtnAdminFelhasznaloMegjelenitese.UseVisualStyleBackColor = true;
            this.BtnAdminFelhasznaloMegjelenitese.Click += new System.EventHandler(this.BtnAdminFelhasznaloMegjelenitese_Click);
            // 
            // BtnAdminFelhasznaloModositasa
            // 
            this.BtnAdminFelhasznaloModositasa.Location = new System.Drawing.Point(6, 297);
            this.BtnAdminFelhasznaloModositasa.Name = "BtnAdminFelhasznaloModositasa";
            this.BtnAdminFelhasznaloModositasa.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminFelhasznaloModositasa.TabIndex = 8;
            this.BtnAdminFelhasznaloModositasa.Text = "Felhasználó módosítása";
            this.BtnAdminFelhasznaloModositasa.UseVisualStyleBackColor = true;
            this.BtnAdminFelhasznaloModositasa.Click += new System.EventHandler(this.BtnAdminFelhasznaloModositasa_Click);
            // 
            // BtnAdminUjFelhasznalo
            // 
            this.BtnAdminUjFelhasznalo.Location = new System.Drawing.Point(6, 261);
            this.BtnAdminUjFelhasznalo.Name = "BtnAdminUjFelhasznalo";
            this.BtnAdminUjFelhasznalo.Size = new System.Drawing.Size(363, 30);
            this.BtnAdminUjFelhasznalo.TabIndex = 7;
            this.BtnAdminUjFelhasznalo.Text = "Felhasználó hozzáadása";
            this.BtnAdminUjFelhasznalo.UseVisualStyleBackColor = true;
            this.BtnAdminUjFelhasznalo.Click += new System.EventHandler(this.BtnAdminUjFelhasznalo_Click);
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnKilepes.Location = new System.Drawing.Point(290, 426);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(200, 30);
            this.BtnKilepes.TabIndex = 6;
            this.BtnKilepes.Text = "Kilépés";
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.BtnKilepes);
            this.Controls.Add(this.GrbFelhasznaloKezeles);
            this.Controls.Add(this.GrbJarmuKezeles);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin felület";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GrbJarmuKezeles.ResumeLayout(false);
            this.GrbFelhasznaloKezeles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblAdminJarmuLista;
        private System.Windows.Forms.Label LblAdminFelhasznalokLista;
        private System.Windows.Forms.ListBox LsbAdminJarmuLista;
        private System.Windows.Forms.ListBox LsbAdminFelhasznaloLista;
        private System.Windows.Forms.GroupBox GrbJarmuKezeles;
        private System.Windows.Forms.GroupBox GrbFelhasznaloKezeles;
        private System.Windows.Forms.Button BtnAdminJarmuTorlese;
        private System.Windows.Forms.Button BtnAdminJarmuMegjelenitese;
        private System.Windows.Forms.Button BtnAdminJarmuModositasa;
        private System.Windows.Forms.Button BtnAdminUjJarmu;
        private System.Windows.Forms.Button BtnAdminFelhasznaloTorlese;
        private System.Windows.Forms.Button BtnAdminFelhasznaloMegjelenitese;
        private System.Windows.Forms.Button BtnAdminFelhasznaloModositasa;
        private System.Windows.Forms.Button BtnAdminUjFelhasznalo;
        private System.Windows.Forms.Button BtnKilepes;
    }
}

