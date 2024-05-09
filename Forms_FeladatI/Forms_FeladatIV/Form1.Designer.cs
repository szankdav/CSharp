namespace Forms_FeladatIV
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesMaskentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kivagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beillesztesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem,
            this.szerkesztesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitasToolStripMenuItem,
            this.mentesToolStripMenuItem,
            this.mentesMaskentToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fajlToolStripMenuItem.Text = "Fajl";
            // 
            // megnyitasToolStripMenuItem
            // 
            this.megnyitasToolStripMenuItem.Name = "megnyitasToolStripMenuItem";
            this.megnyitasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.megnyitasToolStripMenuItem.Text = "Megnyitas";
            this.megnyitasToolStripMenuItem.Click += new System.EventHandler(this.megnyitasToolStripMenuItem_Click);
            // 
            // mentesToolStripMenuItem
            // 
            this.mentesToolStripMenuItem.Name = "mentesToolStripMenuItem";
            this.mentesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentesToolStripMenuItem.Text = "Mentes";
            this.mentesToolStripMenuItem.Click += new System.EventHandler(this.mentesToolStripMenuItem_Click);
            // 
            // mentesMaskentToolStripMenuItem
            // 
            this.mentesMaskentToolStripMenuItem.Name = "mentesMaskentToolStripMenuItem";
            this.mentesMaskentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentesMaskentToolStripMenuItem.Text = "Mentes maskent";
            this.mentesMaskentToolStripMenuItem.Click += new System.EventHandler(this.mentesMaskentToolStripMenuItem_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.kilepesToolStripMenuItem.Text = "Kilepes";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // szerkesztesToolStripMenuItem
            // 
            this.szerkesztesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kivagasToolStripMenuItem,
            this.masolasToolStripMenuItem,
            this.beillesztesToolStripMenuItem});
            this.szerkesztesToolStripMenuItem.Name = "szerkesztesToolStripMenuItem";
            this.szerkesztesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.szerkesztesToolStripMenuItem.Text = "Szerkesztes";
            // 
            // kivagasToolStripMenuItem
            // 
            this.kivagasToolStripMenuItem.Name = "kivagasToolStripMenuItem";
            this.kivagasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.kivagasToolStripMenuItem.Text = "Kivagas     CTRL + X";
            this.kivagasToolStripMenuItem.Click += new System.EventHandler(this.kivagasToolStripMenuItem_Click);
            // 
            // masolasToolStripMenuItem
            // 
            this.masolasToolStripMenuItem.Name = "masolasToolStripMenuItem";
            this.masolasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.masolasToolStripMenuItem.Text = "Masolas    CTRL + C";
            this.masolasToolStripMenuItem.Click += new System.EventHandler(this.masolasToolStripMenuItem_Click);
            // 
            // beillesztesToolStripMenuItem
            // 
            this.beillesztesToolStripMenuItem.Name = "beillesztesToolStripMenuItem";
            this.beillesztesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.beillesztesToolStripMenuItem.Text = "Beillesztes   CTRL + V";
            this.beillesztesToolStripMenuItem.Click += new System.EventHandler(this.beillesztesToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(760, 531);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Szovegszerkeszto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentesMaskentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kivagasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beillesztesToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

