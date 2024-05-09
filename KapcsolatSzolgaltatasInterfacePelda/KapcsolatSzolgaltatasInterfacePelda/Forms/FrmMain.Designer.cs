namespace KapcsolatSzolgaltatasInterfacePelda
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
            this.LsbCegek = new System.Windows.Forms.ListBox();
            this.LsbSzolgaltatasok = new System.Windows.Forms.ListBox();
            this.GrbCegek = new System.Windows.Forms.GroupBox();
            this.BtnTorlesC = new System.Windows.Forms.Button();
            this.ImlIkonok = new System.Windows.Forms.ImageList(this.components);
            this.BtnMegjelenitesC = new System.Windows.Forms.Button();
            this.BtnModositasC = new System.Windows.Forms.Button();
            this.BtnLetrehozasC = new System.Windows.Forms.Button();
            this.GrbSzolgaltatasok = new System.Windows.Forms.GroupBox();
            this.BtnTorlesSz = new System.Windows.Forms.Button();
            this.BtnMegjelenitesSz = new System.Windows.Forms.Button();
            this.BtnModositasSz = new System.Windows.Forms.Button();
            this.BtnLetrehozasSz = new System.Windows.Forms.Button();
            this.BtnKilepes = new System.Windows.Forms.Button();
            this.GrbCegek.SuspendLayout();
            this.GrbSzolgaltatasok.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsbCegek
            // 
            this.LsbCegek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsbCegek.FormattingEnabled = true;
            this.LsbCegek.ItemHeight = 16;
            this.LsbCegek.Location = new System.Drawing.Point(12, 12);
            this.LsbCegek.Name = "LsbCegek";
            this.LsbCegek.Size = new System.Drawing.Size(816, 340);
            this.LsbCegek.TabIndex = 0;
            this.LsbCegek.SelectedIndexChanged += new System.EventHandler(this.LsbCegek_SelectedIndexChanged);
            // 
            // LsbSzolgaltatasok
            // 
            this.LsbSzolgaltatasok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsbSzolgaltatasok.FormattingEnabled = true;
            this.LsbSzolgaltatasok.ItemHeight = 16;
            this.LsbSzolgaltatasok.Location = new System.Drawing.Point(12, 358);
            this.LsbSzolgaltatasok.Name = "LsbSzolgaltatasok";
            this.LsbSzolgaltatasok.Size = new System.Drawing.Size(816, 340);
            this.LsbSzolgaltatasok.TabIndex = 1;
            // 
            // GrbCegek
            // 
            this.GrbCegek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbCegek.Controls.Add(this.BtnTorlesC);
            this.GrbCegek.Controls.Add(this.BtnMegjelenitesC);
            this.GrbCegek.Controls.Add(this.BtnModositasC);
            this.GrbCegek.Controls.Add(this.BtnLetrehozasC);
            this.GrbCegek.Location = new System.Drawing.Point(834, 12);
            this.GrbCegek.Name = "GrbCegek";
            this.GrbCegek.Size = new System.Drawing.Size(162, 205);
            this.GrbCegek.TabIndex = 6;
            this.GrbCegek.TabStop = false;
            this.GrbCegek.Text = "Cégek";
            // 
            // BtnTorlesC
            // 
            this.BtnTorlesC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTorlesC.ImageKey = "Delete.png";
            this.BtnTorlesC.ImageList = this.ImlIkonok;
            this.BtnTorlesC.Location = new System.Drawing.Point(6, 159);
            this.BtnTorlesC.Name = "BtnTorlesC";
            this.BtnTorlesC.Size = new System.Drawing.Size(150, 40);
            this.BtnTorlesC.TabIndex = 3;
            this.BtnTorlesC.Text = "Törlés";
            this.BtnTorlesC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTorlesC.UseVisualStyleBackColor = true;
            this.BtnTorlesC.Click += new System.EventHandler(this.BtnTorlesC_Click);
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
            // BtnMegjelenitesC
            // 
            this.BtnMegjelenitesC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMegjelenitesC.ImageKey = "Preview.png";
            this.BtnMegjelenitesC.ImageList = this.ImlIkonok;
            this.BtnMegjelenitesC.Location = new System.Drawing.Point(6, 113);
            this.BtnMegjelenitesC.Name = "BtnMegjelenitesC";
            this.BtnMegjelenitesC.Size = new System.Drawing.Size(150, 40);
            this.BtnMegjelenitesC.TabIndex = 2;
            this.BtnMegjelenitesC.Text = "Megjelenítés";
            this.BtnMegjelenitesC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMegjelenitesC.UseVisualStyleBackColor = true;
            this.BtnMegjelenitesC.Click += new System.EventHandler(this.BtnMegjelenitesC_Click);
            // 
            // BtnModositasC
            // 
            this.BtnModositasC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModositasC.ImageKey = "Edit.png";
            this.BtnModositasC.ImageList = this.ImlIkonok;
            this.BtnModositasC.Location = new System.Drawing.Point(6, 67);
            this.BtnModositasC.Name = "BtnModositasC";
            this.BtnModositasC.Size = new System.Drawing.Size(150, 40);
            this.BtnModositasC.TabIndex = 1;
            this.BtnModositasC.Text = "Módosítás";
            this.BtnModositasC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModositasC.UseVisualStyleBackColor = true;
            this.BtnModositasC.Click += new System.EventHandler(this.BtnModositasC_Click);
            // 
            // BtnLetrehozasC
            // 
            this.BtnLetrehozasC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLetrehozasC.ImageKey = "New.png";
            this.BtnLetrehozasC.ImageList = this.ImlIkonok;
            this.BtnLetrehozasC.Location = new System.Drawing.Point(6, 21);
            this.BtnLetrehozasC.Name = "BtnLetrehozasC";
            this.BtnLetrehozasC.Size = new System.Drawing.Size(150, 40);
            this.BtnLetrehozasC.TabIndex = 0;
            this.BtnLetrehozasC.Text = "Létrehozás";
            this.BtnLetrehozasC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLetrehozasC.UseVisualStyleBackColor = true;
            this.BtnLetrehozasC.Click += new System.EventHandler(this.BtnLetrehozasC_Click);
            // 
            // GrbSzolgaltatasok
            // 
            this.GrbSzolgaltatasok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbSzolgaltatasok.Controls.Add(this.BtnTorlesSz);
            this.GrbSzolgaltatasok.Controls.Add(this.BtnMegjelenitesSz);
            this.GrbSzolgaltatasok.Controls.Add(this.BtnModositasSz);
            this.GrbSzolgaltatasok.Controls.Add(this.BtnLetrehozasSz);
            this.GrbSzolgaltatasok.Location = new System.Drawing.Point(834, 358);
            this.GrbSzolgaltatasok.Name = "GrbSzolgaltatasok";
            this.GrbSzolgaltatasok.Size = new System.Drawing.Size(162, 205);
            this.GrbSzolgaltatasok.TabIndex = 7;
            this.GrbSzolgaltatasok.TabStop = false;
            this.GrbSzolgaltatasok.Text = "Szolgáltatások";
            // 
            // BtnTorlesSz
            // 
            this.BtnTorlesSz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTorlesSz.ImageKey = "Delete.png";
            this.BtnTorlesSz.ImageList = this.ImlIkonok;
            this.BtnTorlesSz.Location = new System.Drawing.Point(6, 159);
            this.BtnTorlesSz.Name = "BtnTorlesSz";
            this.BtnTorlesSz.Size = new System.Drawing.Size(150, 40);
            this.BtnTorlesSz.TabIndex = 3;
            this.BtnTorlesSz.Text = "Törlés";
            this.BtnTorlesSz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTorlesSz.UseVisualStyleBackColor = true;
            this.BtnTorlesSz.Click += new System.EventHandler(this.BtnTorlesSz_Click);
            // 
            // BtnMegjelenitesSz
            // 
            this.BtnMegjelenitesSz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMegjelenitesSz.ImageKey = "Preview.png";
            this.BtnMegjelenitesSz.ImageList = this.ImlIkonok;
            this.BtnMegjelenitesSz.Location = new System.Drawing.Point(6, 113);
            this.BtnMegjelenitesSz.Name = "BtnMegjelenitesSz";
            this.BtnMegjelenitesSz.Size = new System.Drawing.Size(150, 40);
            this.BtnMegjelenitesSz.TabIndex = 2;
            this.BtnMegjelenitesSz.Text = "Megjelenítés";
            this.BtnMegjelenitesSz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMegjelenitesSz.UseVisualStyleBackColor = true;
            this.BtnMegjelenitesSz.Click += new System.EventHandler(this.BtnMegjelenitesSz_Click);
            // 
            // BtnModositasSz
            // 
            this.BtnModositasSz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModositasSz.ImageKey = "Edit.png";
            this.BtnModositasSz.ImageList = this.ImlIkonok;
            this.BtnModositasSz.Location = new System.Drawing.Point(6, 67);
            this.BtnModositasSz.Name = "BtnModositasSz";
            this.BtnModositasSz.Size = new System.Drawing.Size(150, 40);
            this.BtnModositasSz.TabIndex = 1;
            this.BtnModositasSz.Text = "Módosítás";
            this.BtnModositasSz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModositasSz.UseVisualStyleBackColor = true;
            this.BtnModositasSz.Click += new System.EventHandler(this.BtnModositasSz_Click);
            // 
            // BtnLetrehozasSz
            // 
            this.BtnLetrehozasSz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLetrehozasSz.ImageKey = "New.png";
            this.BtnLetrehozasSz.ImageList = this.ImlIkonok;
            this.BtnLetrehozasSz.Location = new System.Drawing.Point(6, 21);
            this.BtnLetrehozasSz.Name = "BtnLetrehozasSz";
            this.BtnLetrehozasSz.Size = new System.Drawing.Size(150, 40);
            this.BtnLetrehozasSz.TabIndex = 0;
            this.BtnLetrehozasSz.Text = "Létrehozás";
            this.BtnLetrehozasSz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLetrehozasSz.UseVisualStyleBackColor = true;
            this.BtnLetrehozasSz.Click += new System.EventHandler(this.BtnLetrehozasSz_Click);
            // 
            // BtnKilepes
            // 
            this.BtnKilepes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKilepes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKilepes.ImageKey = "Close.png";
            this.BtnKilepes.ImageList = this.ImlIkonok;
            this.BtnKilepes.Location = new System.Drawing.Point(840, 658);
            this.BtnKilepes.Name = "BtnKilepes";
            this.BtnKilepes.Size = new System.Drawing.Size(150, 40);
            this.BtnKilepes.TabIndex = 8;
            this.BtnKilepes.Text = "Kilépés";
            this.BtnKilepes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKilepes.UseVisualStyleBackColor = true;
            this.BtnKilepes.Click += new System.EventHandler(this.BtnKilepes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnKilepes;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnKilepes);
            this.Controls.Add(this.GrbSzolgaltatasok);
            this.Controls.Add(this.GrbCegek);
            this.Controls.Add(this.LsbSzolgaltatasok);
            this.Controls.Add(this.LsbCegek);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cegek es szolgaltatasok interface pelda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.GrbCegek.ResumeLayout(false);
            this.GrbSzolgaltatasok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbCegek;
        private System.Windows.Forms.ListBox LsbSzolgaltatasok;
        private System.Windows.Forms.GroupBox GrbCegek;
        private System.Windows.Forms.Button BtnTorlesC;
        private System.Windows.Forms.Button BtnMegjelenitesC;
        private System.Windows.Forms.Button BtnModositasC;
        private System.Windows.Forms.Button BtnLetrehozasC;
        private System.Windows.Forms.GroupBox GrbSzolgaltatasok;
        private System.Windows.Forms.Button BtnTorlesSz;
        private System.Windows.Forms.Button BtnMegjelenitesSz;
        private System.Windows.Forms.Button BtnModositasSz;
        private System.Windows.Forms.Button BtnLetrehozasSz;
        private System.Windows.Forms.Button BtnKilepes;
        private System.Windows.Forms.ImageList ImlIkonok;
    }
}

