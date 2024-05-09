namespace KonyvNyilvantarto
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
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnViewBook = new System.Windows.Forms.Button();
            this.BtnModifyBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrbBookManage = new System.Windows.Forms.GroupBox();
            this.LswBookList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrbFilter = new System.Windows.Forms.GroupBox();
            this.TxbSzuresCim = new System.Windows.Forms.TextBox();
            this.TxbSzuresSzerzo = new System.Windows.Forms.TextBox();
            this.CmbSzuresMufaj = new System.Windows.Forms.ComboBox();
            this.LblCim = new System.Windows.Forms.Label();
            this.LblSzerzo = new System.Windows.Forms.Label();
            this.LblMufaj = new System.Windows.Forms.Label();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnResetFilter = new System.Windows.Forms.Button();
            this.GrbBookManage.SuspendLayout();
            this.GrbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddBook.ImageKey = "book(3).png";
            this.BtnAddBook.ImageList = this.imageList1;
            this.BtnAddBook.Location = new System.Drawing.Point(6, 21);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(200, 40);
            this.BtnAddBook.TabIndex = 1;
            this.BtnAddBook.Text = "Könyv hozzáadása";
            this.BtnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "book(3).png");
            this.imageList1.Images.SetKeyName(1, "book(2).png");
            this.imageList1.Images.SetKeyName(2, "book(1).png");
            this.imageList1.Images.SetKeyName(3, "book.png");
            this.imageList1.Images.SetKeyName(4, "exit.png");
            // 
            // BtnViewBook
            // 
            this.BtnViewBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewBook.ImageKey = "book(1).png";
            this.BtnViewBook.ImageList = this.imageList1;
            this.BtnViewBook.Location = new System.Drawing.Point(6, 67);
            this.BtnViewBook.Name = "BtnViewBook";
            this.BtnViewBook.Size = new System.Drawing.Size(200, 40);
            this.BtnViewBook.TabIndex = 2;
            this.BtnViewBook.Text = "Könyv megtekintése";
            this.BtnViewBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnViewBook.UseVisualStyleBackColor = true;
            this.BtnViewBook.Click += new System.EventHandler(this.BtnViewBook_Click);
            // 
            // BtnModifyBook
            // 
            this.BtnModifyBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModifyBook.ImageKey = "book(2).png";
            this.BtnModifyBook.ImageList = this.imageList1;
            this.BtnModifyBook.Location = new System.Drawing.Point(6, 113);
            this.BtnModifyBook.Name = "BtnModifyBook";
            this.BtnModifyBook.Size = new System.Drawing.Size(200, 40);
            this.BtnModifyBook.TabIndex = 3;
            this.BtnModifyBook.Text = "Könyv módosítása";
            this.BtnModifyBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModifyBook.UseVisualStyleBackColor = true;
            this.BtnModifyBook.Click += new System.EventHandler(this.BtnModifyBook_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteBook.ImageKey = "book.png";
            this.BtnDeleteBook.ImageList = this.imageList1;
            this.BtnDeleteBook.Location = new System.Drawing.Point(6, 159);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(200, 40);
            this.BtnDeleteBook.TabIndex = 4;
            this.BtnDeleteBook.Text = "Könyv törlése";
            this.BtnDeleteBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteBook.UseVisualStyleBackColor = true;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.ImageKey = "exit.png";
            this.BtnExit.ImageList = this.imageList1;
            this.BtnExit.Location = new System.Drawing.Point(778, 679);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(200, 40);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Kilépés";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // GrbBookManage
            // 
            this.GrbBookManage.Controls.Add(this.BtnAddBook);
            this.GrbBookManage.Controls.Add(this.BtnViewBook);
            this.GrbBookManage.Controls.Add(this.BtnDeleteBook);
            this.GrbBookManage.Controls.Add(this.BtnModifyBook);
            this.GrbBookManage.Location = new System.Drawing.Point(772, 12);
            this.GrbBookManage.Name = "GrbBookManage";
            this.GrbBookManage.Size = new System.Drawing.Size(212, 205);
            this.GrbBookManage.TabIndex = 6;
            this.GrbBookManage.TabStop = false;
            this.GrbBookManage.Text = "Könyvek kezelése";
            // 
            // LswBookList
            // 
            this.LswBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LswBookList.FullRowSelect = true;
            this.LswBookList.GridLines = true;
            this.LswBookList.HideSelection = false;
            this.LswBookList.Location = new System.Drawing.Point(12, 12);
            this.LswBookList.Name = "LswBookList";
            this.LswBookList.Size = new System.Drawing.Size(754, 707);
            this.LswBookList.TabIndex = 7;
            this.LswBookList.UseCompatibleStateImageBehavior = false;
            this.LswBookList.View = System.Windows.Forms.View.Details;
            this.LswBookList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.LswBookList_ColumnWidthChanging);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cím";
            this.columnHeader2.Width = 376;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Szerző";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Műfaj";
            this.columnHeader4.Width = 174;
            // 
            // GrbFilter
            // 
            this.GrbFilter.Controls.Add(this.BtnResetFilter);
            this.GrbFilter.Controls.Add(this.BtnFilter);
            this.GrbFilter.Controls.Add(this.LblMufaj);
            this.GrbFilter.Controls.Add(this.LblSzerzo);
            this.GrbFilter.Controls.Add(this.LblCim);
            this.GrbFilter.Controls.Add(this.CmbSzuresMufaj);
            this.GrbFilter.Controls.Add(this.TxbSzuresSzerzo);
            this.GrbFilter.Controls.Add(this.TxbSzuresCim);
            this.GrbFilter.Location = new System.Drawing.Point(772, 223);
            this.GrbFilter.Name = "GrbFilter";
            this.GrbFilter.Size = new System.Drawing.Size(212, 288);
            this.GrbFilter.TabIndex = 8;
            this.GrbFilter.TabStop = false;
            this.GrbFilter.Text = "Szűrés";
            // 
            // TxbSzuresCim
            // 
            this.TxbSzuresCim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSzuresCim.Location = new System.Drawing.Point(6, 43);
            this.TxbSzuresCim.Name = "TxbSzuresCim";
            this.TxbSzuresCim.Size = new System.Drawing.Size(200, 22);
            this.TxbSzuresCim.TabIndex = 0;
            // 
            // TxbSzuresSzerzo
            // 
            this.TxbSzuresSzerzo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbSzuresSzerzo.Location = new System.Drawing.Point(6, 105);
            this.TxbSzuresSzerzo.Name = "TxbSzuresSzerzo";
            this.TxbSzuresSzerzo.Size = new System.Drawing.Size(200, 22);
            this.TxbSzuresSzerzo.TabIndex = 1;
            // 
            // CmbSzuresMufaj
            // 
            this.CmbSzuresMufaj.FormattingEnabled = true;
            this.CmbSzuresMufaj.Location = new System.Drawing.Point(6, 166);
            this.CmbSzuresMufaj.Name = "CmbSzuresMufaj";
            this.CmbSzuresMufaj.Size = new System.Drawing.Size(200, 24);
            this.CmbSzuresMufaj.TabIndex = 2;
            // 
            // LblCim
            // 
            this.LblCim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCim.Location = new System.Drawing.Point(6, 18);
            this.LblCim.Name = "LblCim";
            this.LblCim.Size = new System.Drawing.Size(200, 22);
            this.LblCim.TabIndex = 3;
            this.LblCim.Text = "Cím";
            this.LblCim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSzerzo
            // 
            this.LblSzerzo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSzerzo.Location = new System.Drawing.Point(6, 80);
            this.LblSzerzo.Name = "LblSzerzo";
            this.LblSzerzo.Size = new System.Drawing.Size(200, 22);
            this.LblSzerzo.TabIndex = 4;
            this.LblSzerzo.Text = "Szerző";
            this.LblSzerzo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMufaj
            // 
            this.LblMufaj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMufaj.Location = new System.Drawing.Point(6, 141);
            this.LblMufaj.Name = "LblMufaj";
            this.LblMufaj.Size = new System.Drawing.Size(200, 22);
            this.LblMufaj.TabIndex = 5;
            this.LblMufaj.Text = "Műfaj";
            this.LblMufaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(6, 196);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(200, 40);
            this.BtnFilter.TabIndex = 6;
            this.BtnFilter.Text = "Szűrés";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnResetFilter
            // 
            this.BtnResetFilter.Location = new System.Drawing.Point(6, 242);
            this.BtnResetFilter.Name = "BtnResetFilter";
            this.BtnResetFilter.Size = new System.Drawing.Size(200, 40);
            this.BtnResetFilter.TabIndex = 7;
            this.BtnResetFilter.Text = "Visszaállítás";
            this.BtnResetFilter.UseVisualStyleBackColor = true;
            this.BtnResetFilter.Click += new System.EventHandler(this.BtnResetFilter_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 731);
            this.Controls.Add(this.GrbFilter);
            this.Controls.Add(this.LswBookList);
            this.Controls.Add(this.GrbBookManage);
            this.Controls.Add(this.BtnExit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Könyv Nyilvántartó";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.GrbBookManage.ResumeLayout(false);
            this.GrbFilter.ResumeLayout(false);
            this.GrbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.Button BtnViewBook;
        private System.Windows.Forms.Button BtnModifyBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox GrbBookManage;
        private System.Windows.Forms.ListView LswBookList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox GrbFilter;
        private System.Windows.Forms.TextBox TxbSzuresCim;
        private System.Windows.Forms.Label LblMufaj;
        private System.Windows.Forms.Label LblSzerzo;
        private System.Windows.Forms.Label LblCim;
        private System.Windows.Forms.ComboBox CmbSzuresMufaj;
        private System.Windows.Forms.TextBox TxbSzuresSzerzo;
        private System.Windows.Forms.Button BtnResetFilter;
        private System.Windows.Forms.Button BtnFilter;
    }
}

