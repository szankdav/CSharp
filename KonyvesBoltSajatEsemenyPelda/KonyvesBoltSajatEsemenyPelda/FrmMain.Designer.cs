namespace KonyvesBoltSajatEsemenyPelda
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
            this.LsbKonyvMolyok = new System.Windows.Forms.ListBox();
            this.LsbEsemenyek = new System.Windows.Forms.ListBox();
            this.BtnMolyLetrehozasa = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.LblTimerStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LsbKonyvMolyok
            // 
            this.LsbKonyvMolyok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LsbKonyvMolyok.FormattingEnabled = true;
            this.LsbKonyvMolyok.ItemHeight = 16;
            this.LsbKonyvMolyok.Location = new System.Drawing.Point(12, 12);
            this.LsbKonyvMolyok.Name = "LsbKonyvMolyok";
            this.LsbKonyvMolyok.Size = new System.Drawing.Size(200, 676);
            this.LsbKonyvMolyok.TabIndex = 0;
            // 
            // LsbEsemenyek
            // 
            this.LsbEsemenyek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsbEsemenyek.FormattingEnabled = true;
            this.LsbEsemenyek.ItemHeight = 16;
            this.LsbEsemenyek.Location = new System.Drawing.Point(218, 12);
            this.LsbEsemenyek.Name = "LsbEsemenyek";
            this.LsbEsemenyek.Size = new System.Drawing.Size(778, 676);
            this.LsbEsemenyek.TabIndex = 1;
            // 
            // BtnMolyLetrehozasa
            // 
            this.BtnMolyLetrehozasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnMolyLetrehozasa.Location = new System.Drawing.Point(12, 694);
            this.BtnMolyLetrehozasa.Name = "BtnMolyLetrehozasa";
            this.BtnMolyLetrehozasa.Size = new System.Drawing.Size(200, 23);
            this.BtnMolyLetrehozasa.TabIndex = 2;
            this.BtnMolyLetrehozasa.Text = "Uj konyvmoly";
            this.BtnMolyLetrehozasa.UseVisualStyleBackColor = true;
            this.BtnMolyLetrehozasa.Click += new System.EventHandler(this.BtnMolyLetrehozasa_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnTimer.Location = new System.Drawing.Point(218, 694);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(200, 23);
            this.BtnTimer.TabIndex = 3;
            this.BtnTimer.Text = "Timer inditasa/leallitasa";
            this.BtnTimer.UseVisualStyleBackColor = true;
            this.BtnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // LblTimerStatus
            // 
            this.LblTimerStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTimerStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTimerStatus.Location = new System.Drawing.Point(424, 694);
            this.LblTimerStatus.Name = "LblTimerStatus";
            this.LblTimerStatus.Size = new System.Drawing.Size(200, 23);
            this.LblTimerStatus.TabIndex = 4;
            this.LblTimerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LblTimerStatus);
            this.Controls.Add(this.BtnTimer);
            this.Controls.Add(this.BtnMolyLetrehozasa);
            this.Controls.Add(this.LsbEsemenyek);
            this.Controls.Add(this.LsbKonyvMolyok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konyvesbolt Sajat Esemeny Pelda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsbKonyvMolyok;
        private System.Windows.Forms.ListBox LsbEsemenyek;
        private System.Windows.Forms.Button BtnMolyLetrehozasa;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Label LblTimerStatus;
        private System.Windows.Forms.Timer timer1;
    }
}

