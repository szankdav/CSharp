namespace VizsgaMgr
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
            this.LblVizsgak = new System.Windows.Forms.Label();
            this.LblFeladatok = new System.Windows.Forms.Label();
            this.LsbVizsgak = new System.Windows.Forms.ListBox();
            this.LsbFeladatok = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizsgákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizsgaLétrehozásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizsgaMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizsgaMegjelenítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizsgaTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatLétrehozásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatMódosításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatMegjelenítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblVizsgak
            // 
            this.LblVizsgak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblVizsgak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblVizsgak.Location = new System.Drawing.Point(12, 25);
            this.LblVizsgak.Name = "LblVizsgak";
            this.LblVizsgak.Size = new System.Drawing.Size(377, 30);
            this.LblVizsgak.TabIndex = 1;
            this.LblVizsgak.Text = "Vizsgák";
            this.LblVizsgak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFeladatok
            // 
            this.LblFeladatok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFeladatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblFeladatok.Location = new System.Drawing.Point(395, 25);
            this.LblFeladatok.Name = "LblFeladatok";
            this.LblFeladatok.Size = new System.Drawing.Size(377, 30);
            this.LblFeladatok.TabIndex = 2;
            this.LblFeladatok.Text = "Feladatok";
            this.LblFeladatok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LsbVizsgak
            // 
            this.LsbVizsgak.FormattingEnabled = true;
            this.LsbVizsgak.ItemHeight = 16;
            this.LsbVizsgak.Location = new System.Drawing.Point(12, 58);
            this.LsbVizsgak.Name = "LsbVizsgak";
            this.LsbVizsgak.Size = new System.Drawing.Size(377, 484);
            this.LsbVizsgak.TabIndex = 3;
            // 
            // LsbFeladatok
            // 
            this.LsbFeladatok.FormattingEnabled = true;
            this.LsbFeladatok.ItemHeight = 16;
            this.LsbFeladatok.Location = new System.Drawing.Point(395, 58);
            this.LsbFeladatok.Name = "LsbFeladatok";
            this.LsbFeladatok.Size = new System.Drawing.Size(377, 484);
            this.LsbFeladatok.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.vizsgákToolStripMenuItem,
            this.feladatokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // vizsgákToolStripMenuItem
            // 
            this.vizsgákToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizsgaLétrehozásaToolStripMenuItem,
            this.vizsgaMódosításaToolStripMenuItem,
            this.vizsgaMegjelenítéseToolStripMenuItem,
            this.vizsgaTörléseToolStripMenuItem});
            this.vizsgákToolStripMenuItem.Name = "vizsgákToolStripMenuItem";
            this.vizsgákToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.vizsgákToolStripMenuItem.Text = "Vizsgák";
            // 
            // vizsgaLétrehozásaToolStripMenuItem
            // 
            this.vizsgaLétrehozásaToolStripMenuItem.Name = "vizsgaLétrehozásaToolStripMenuItem";
            this.vizsgaLétrehozásaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.vizsgaLétrehozásaToolStripMenuItem.Text = "Vizsga létrehozása";
            // 
            // vizsgaMódosításaToolStripMenuItem
            // 
            this.vizsgaMódosításaToolStripMenuItem.Name = "vizsgaMódosításaToolStripMenuItem";
            this.vizsgaMódosításaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.vizsgaMódosításaToolStripMenuItem.Text = "Vizsga módosítása";
            // 
            // vizsgaMegjelenítéseToolStripMenuItem
            // 
            this.vizsgaMegjelenítéseToolStripMenuItem.Name = "vizsgaMegjelenítéseToolStripMenuItem";
            this.vizsgaMegjelenítéseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.vizsgaMegjelenítéseToolStripMenuItem.Text = "Vizsga megjelenítése";
            // 
            // vizsgaTörléseToolStripMenuItem
            // 
            this.vizsgaTörléseToolStripMenuItem.Name = "vizsgaTörléseToolStripMenuItem";
            this.vizsgaTörléseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.vizsgaTörléseToolStripMenuItem.Text = "Vizsga törlése";
            // 
            // feladatokToolStripMenuItem
            // 
            this.feladatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feladatLétrehozásaToolStripMenuItem,
            this.feladatMódosításaToolStripMenuItem,
            this.feladatMegjelenítéseToolStripMenuItem,
            this.feladatTörléseToolStripMenuItem});
            this.feladatokToolStripMenuItem.Name = "feladatokToolStripMenuItem";
            this.feladatokToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.feladatokToolStripMenuItem.Text = "Feladatok";
            // 
            // feladatLétrehozásaToolStripMenuItem
            // 
            this.feladatLétrehozásaToolStripMenuItem.Name = "feladatLétrehozásaToolStripMenuItem";
            this.feladatLétrehozásaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.feladatLétrehozásaToolStripMenuItem.Text = "Feladat létrehozása";
            // 
            // feladatMódosításaToolStripMenuItem
            // 
            this.feladatMódosításaToolStripMenuItem.Name = "feladatMódosításaToolStripMenuItem";
            this.feladatMódosításaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.feladatMódosításaToolStripMenuItem.Text = "Feladat módosítása";
            // 
            // feladatMegjelenítéseToolStripMenuItem
            // 
            this.feladatMegjelenítéseToolStripMenuItem.Name = "feladatMegjelenítéseToolStripMenuItem";
            this.feladatMegjelenítéseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.feladatMegjelenítéseToolStripMenuItem.Text = "Feladat megjelenítése";
            // 
            // feladatTörléseToolStripMenuItem
            // 
            this.feladatTörléseToolStripMenuItem.Name = "feladatTörléseToolStripMenuItem";
            this.feladatTörléseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.feladatTörléseToolStripMenuItem.Text = "Feladat törlése";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LsbFeladatok);
            this.Controls.Add(this.LsbVizsgak);
            this.Controls.Add(this.LblFeladatok);
            this.Controls.Add(this.LblVizsgak);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizsga Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblVizsgak;
        private System.Windows.Forms.Label LblFeladatok;
        private System.Windows.Forms.ListBox LsbVizsgak;
        private System.Windows.Forms.ListBox LsbFeladatok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizsgákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizsgaLétrehozásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizsgaMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizsgaMegjelenítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizsgaTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatLétrehozásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatMódosításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatMegjelenítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatTörléseToolStripMenuItem;
    }
}

