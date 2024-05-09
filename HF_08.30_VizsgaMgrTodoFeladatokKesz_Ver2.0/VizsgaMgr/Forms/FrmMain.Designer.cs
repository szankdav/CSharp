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
            this.FajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VizsgakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VizsgaLetrehozasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VizsgaModositasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VizsgaMegjeleniteseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VizsgaTorleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatLetrehozasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatModositasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatMegjeleniteseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeladatTorleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.LsbVizsgak.SelectedIndexChanged += new System.EventHandler(this.LsbVizsgak_SelectedIndexChanged);
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
            this.FajlToolStripMenuItem,
            this.VizsgakToolStripMenuItem,
            this.FeladatokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FajlToolStripMenuItem
            // 
            this.FajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KilepesToolStripMenuItem});
            this.FajlToolStripMenuItem.Name = "FajlToolStripMenuItem";
            this.FajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FajlToolStripMenuItem.Text = "Fájl";
            // 
            // KilepesToolStripMenuItem
            // 
            this.KilepesToolStripMenuItem.Name = "KilepesToolStripMenuItem";
            this.KilepesToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.KilepesToolStripMenuItem.Text = "Kilépés";
            this.KilepesToolStripMenuItem.Click += new System.EventHandler(this.KilepesToolStripMenuItem_Click);
            // 
            // VizsgakToolStripMenuItem
            // 
            this.VizsgakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VizsgaLetrehozasaToolStripMenuItem,
            this.VizsgaModositasaToolStripMenuItem,
            this.VizsgaMegjeleniteseToolStripMenuItem,
            this.VizsgaTorleseToolStripMenuItem});
            this.VizsgakToolStripMenuItem.Name = "VizsgakToolStripMenuItem";
            this.VizsgakToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.VizsgakToolStripMenuItem.Text = "Vizsgák";
            // 
            // VizsgaLetrehozasaToolStripMenuItem
            // 
            this.VizsgaLetrehozasaToolStripMenuItem.Name = "VizsgaLetrehozasaToolStripMenuItem";
            this.VizsgaLetrehozasaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.VizsgaLetrehozasaToolStripMenuItem.Text = "Vizsga létrehozása";
            this.VizsgaLetrehozasaToolStripMenuItem.Click += new System.EventHandler(this.VizsgaLetrehozasaToolStripMenuItem_Click);
            // 
            // VizsgaModositasaToolStripMenuItem
            // 
            this.VizsgaModositasaToolStripMenuItem.Name = "VizsgaModositasaToolStripMenuItem";
            this.VizsgaModositasaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.VizsgaModositasaToolStripMenuItem.Text = "Vizsga módosítása";
            this.VizsgaModositasaToolStripMenuItem.Click += new System.EventHandler(this.VizsgaModositasaToolStripMenuItem_Click);
            // 
            // VizsgaMegjeleniteseToolStripMenuItem
            // 
            this.VizsgaMegjeleniteseToolStripMenuItem.Name = "VizsgaMegjeleniteseToolStripMenuItem";
            this.VizsgaMegjeleniteseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.VizsgaMegjeleniteseToolStripMenuItem.Text = "Vizsga megjelenítése";
            this.VizsgaMegjeleniteseToolStripMenuItem.Click += new System.EventHandler(this.VizsgaMegjeleniteseToolStripMenuItem_Click);
            // 
            // VizsgaTorleseToolStripMenuItem
            // 
            this.VizsgaTorleseToolStripMenuItem.Name = "VizsgaTorleseToolStripMenuItem";
            this.VizsgaTorleseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.VizsgaTorleseToolStripMenuItem.Text = "Vizsga törlése";
            this.VizsgaTorleseToolStripMenuItem.Click += new System.EventHandler(this.VizsgaTorleseToolStripMenuItem_Click);
            // 
            // FeladatokToolStripMenuItem
            // 
            this.FeladatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FeladatLetrehozasaToolStripMenuItem,
            this.FeladatModositasaToolStripMenuItem,
            this.FeladatMegjeleniteseToolStripMenuItem,
            this.FeladatTorleseToolStripMenuItem});
            this.FeladatokToolStripMenuItem.Name = "FeladatokToolStripMenuItem";
            this.FeladatokToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.FeladatokToolStripMenuItem.Text = "Feladatok";
            // 
            // FeladatLetrehozasaToolStripMenuItem
            // 
            this.FeladatLetrehozasaToolStripMenuItem.Name = "FeladatLetrehozasaToolStripMenuItem";
            this.FeladatLetrehozasaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.FeladatLetrehozasaToolStripMenuItem.Text = "Feladat létrehozása";
            this.FeladatLetrehozasaToolStripMenuItem.Click += new System.EventHandler(this.FeladatLetrehozasaToolStripMenuItem_Click);
            // 
            // FeladatModositasaToolStripMenuItem
            // 
            this.FeladatModositasaToolStripMenuItem.Name = "FeladatModositasaToolStripMenuItem";
            this.FeladatModositasaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.FeladatModositasaToolStripMenuItem.Text = "Feladat módosítása";
            this.FeladatModositasaToolStripMenuItem.Click += new System.EventHandler(this.FeladatModositasaToolStripMenuItem_Click);
            // 
            // FeladatMegjeleniteseToolStripMenuItem
            // 
            this.FeladatMegjeleniteseToolStripMenuItem.Name = "FeladatMegjeleniteseToolStripMenuItem";
            this.FeladatMegjeleniteseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.FeladatMegjeleniteseToolStripMenuItem.Text = "Feladat megjelenítése";
            this.FeladatMegjeleniteseToolStripMenuItem.Click += new System.EventHandler(this.FeladatMegjeleniteseToolStripMenuItem_Click);
            // 
            // FeladatTorleseToolStripMenuItem
            // 
            this.FeladatTorleseToolStripMenuItem.Name = "FeladatTorleseToolStripMenuItem";
            this.FeladatTorleseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.FeladatTorleseToolStripMenuItem.Text = "Feladat törlése";
            this.FeladatTorleseToolStripMenuItem.Click += new System.EventHandler(this.FeladatTorleseToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem FajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VizsgakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VizsgaLetrehozasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VizsgaModositasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VizsgaMegjeleniteseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VizsgaTorleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FeladatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FeladatLetrehozasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FeladatModositasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FeladatMegjeleniteseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FeladatTorleseToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

