namespace Admin
{
    partial class FrmUjJarmu
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
            this.LblRendszam = new System.Windows.Forms.Label();
            this.LblFutottKM = new System.Windows.Forms.Label();
            this.TbcAdminUjJarmu = new System.Windows.Forms.TabControl();
            this.TbpAdminAuto = new System.Windows.Forms.TabPage();
            this.TbpAdminMotor = new System.Windows.Forms.TabPage();
            this.GrbAdminUjJarmuAdatai = new System.Windows.Forms.GroupBox();
            this.TxbRendszam = new System.Windows.Forms.TextBox();
            this.NudFutottKM = new System.Windows.Forms.NumericUpDown();
            this.CmbAdminUjAutoMotorTipus = new System.Windows.Forms.ComboBox();
            this.LblAdminUjAutoMotorTipus = new System.Windows.Forms.Label();
            this.LblAdminUjMotorKobcenti = new System.Windows.Forms.Label();
            this.NudAdminUjMotorKobcentimeter = new System.Windows.Forms.NumericUpDown();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnMegsem = new System.Windows.Forms.Button();
            this.TbcAdminUjJarmu.SuspendLayout();
            this.TbpAdminAuto.SuspendLayout();
            this.TbpAdminMotor.SuspendLayout();
            this.GrbAdminUjJarmuAdatai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFutottKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdminUjMotorKobcentimeter)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRendszam
            // 
            this.LblRendszam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRendszam.Location = new System.Drawing.Point(6, 18);
            this.LblRendszam.Name = "LblRendszam";
            this.LblRendszam.Size = new System.Drawing.Size(150, 22);
            this.LblRendszam.TabIndex = 0;
            this.LblRendszam.Text = "Rendszám";
            // 
            // LblFutottKM
            // 
            this.LblFutottKM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFutottKM.Location = new System.Drawing.Point(6, 46);
            this.LblFutottKM.Name = "LblFutottKM";
            this.LblFutottKM.Size = new System.Drawing.Size(150, 22);
            this.LblFutottKM.TabIndex = 1;
            this.LblFutottKM.Text = "Futott KM";
            // 
            // TbcAdminUjJarmu
            // 
            this.TbcAdminUjJarmu.Controls.Add(this.TbpAdminAuto);
            this.TbcAdminUjJarmu.Controls.Add(this.TbpAdminMotor);
            this.TbcAdminUjJarmu.Location = new System.Drawing.Point(6, 74);
            this.TbcAdminUjJarmu.Name = "TbcAdminUjJarmu";
            this.TbcAdminUjJarmu.SelectedIndex = 0;
            this.TbcAdminUjJarmu.Size = new System.Drawing.Size(341, 60);
            this.TbcAdminUjJarmu.TabIndex = 3;
            // 
            // TbpAdminAuto
            // 
            this.TbpAdminAuto.Controls.Add(this.LblAdminUjAutoMotorTipus);
            this.TbpAdminAuto.Controls.Add(this.CmbAdminUjAutoMotorTipus);
            this.TbpAdminAuto.Location = new System.Drawing.Point(4, 25);
            this.TbpAdminAuto.Name = "TbpAdminAuto";
            this.TbpAdminAuto.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAdminAuto.Size = new System.Drawing.Size(333, 31);
            this.TbpAdminAuto.TabIndex = 0;
            this.TbpAdminAuto.Text = "Autó";
            this.TbpAdminAuto.UseVisualStyleBackColor = true;
            // 
            // TbpAdminMotor
            // 
            this.TbpAdminMotor.Controls.Add(this.NudAdminUjMotorKobcentimeter);
            this.TbpAdminMotor.Controls.Add(this.LblAdminUjMotorKobcenti);
            this.TbpAdminMotor.Location = new System.Drawing.Point(4, 25);
            this.TbpAdminMotor.Name = "TbpAdminMotor";
            this.TbpAdminMotor.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAdminMotor.Size = new System.Drawing.Size(333, 31);
            this.TbpAdminMotor.TabIndex = 1;
            this.TbpAdminMotor.Text = "Motor";
            this.TbpAdminMotor.UseVisualStyleBackColor = true;
            // 
            // GrbAdminUjJarmuAdatai
            // 
            this.GrbAdminUjJarmuAdatai.Controls.Add(this.NudFutottKM);
            this.GrbAdminUjJarmuAdatai.Controls.Add(this.TxbRendszam);
            this.GrbAdminUjJarmuAdatai.Controls.Add(this.LblRendszam);
            this.GrbAdminUjJarmuAdatai.Controls.Add(this.TbcAdminUjJarmu);
            this.GrbAdminUjJarmuAdatai.Controls.Add(this.LblFutottKM);
            this.GrbAdminUjJarmuAdatai.Location = new System.Drawing.Point(12, 12);
            this.GrbAdminUjJarmuAdatai.Name = "GrbAdminUjJarmuAdatai";
            this.GrbAdminUjJarmuAdatai.Size = new System.Drawing.Size(353, 137);
            this.GrbAdminUjJarmuAdatai.TabIndex = 4;
            this.GrbAdminUjJarmuAdatai.TabStop = false;
            this.GrbAdminUjJarmuAdatai.Text = "Jármű adatai";
            // 
            // TxbRendszam
            // 
            this.TxbRendszam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxbRendszam.Location = new System.Drawing.Point(162, 18);
            this.TxbRendszam.Name = "TxbRendszam";
            this.TxbRendszam.Size = new System.Drawing.Size(185, 22);
            this.TxbRendszam.TabIndex = 4;
            // 
            // NudFutottKM
            // 
            this.NudFutottKM.Location = new System.Drawing.Point(162, 46);
            this.NudFutottKM.Name = "NudFutottKM";
            this.NudFutottKM.Size = new System.Drawing.Size(185, 22);
            this.NudFutottKM.TabIndex = 6;
            // 
            // CmbAdminUjAutoMotorTipus
            // 
            this.CmbAdminUjAutoMotorTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAdminUjAutoMotorTipus.FormattingEnabled = true;
            this.CmbAdminUjAutoMotorTipus.Location = new System.Drawing.Point(162, 3);
            this.CmbAdminUjAutoMotorTipus.Name = "CmbAdminUjAutoMotorTipus";
            this.CmbAdminUjAutoMotorTipus.Size = new System.Drawing.Size(165, 24);
            this.CmbAdminUjAutoMotorTipus.TabIndex = 0;
            // 
            // LblAdminUjAutoMotorTipus
            // 
            this.LblAdminUjAutoMotorTipus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAdminUjAutoMotorTipus.Location = new System.Drawing.Point(6, 3);
            this.LblAdminUjAutoMotorTipus.Name = "LblAdminUjAutoMotorTipus";
            this.LblAdminUjAutoMotorTipus.Size = new System.Drawing.Size(150, 24);
            this.LblAdminUjAutoMotorTipus.TabIndex = 7;
            this.LblAdminUjAutoMotorTipus.Text = "Motor típusa";
            // 
            // LblAdminUjMotorKobcenti
            // 
            this.LblAdminUjMotorKobcenti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAdminUjMotorKobcenti.Location = new System.Drawing.Point(6, 3);
            this.LblAdminUjMotorKobcenti.Name = "LblAdminUjMotorKobcenti";
            this.LblAdminUjMotorKobcenti.Size = new System.Drawing.Size(150, 22);
            this.LblAdminUjMotorKobcenti.TabIndex = 7;
            this.LblAdminUjMotorKobcenti.Text = "Köbcentiméter";
            // 
            // NudAdminUjMotorKobcentimeter
            // 
            this.NudAdminUjMotorKobcentimeter.Location = new System.Drawing.Point(162, 3);
            this.NudAdminUjMotorKobcentimeter.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudAdminUjMotorKobcentimeter.Name = "NudAdminUjMotorKobcentimeter";
            this.NudAdminUjMotorKobcentimeter.Size = new System.Drawing.Size(165, 22);
            this.NudAdminUjMotorKobcentimeter.TabIndex = 8;
            this.NudAdminUjMotorKobcentimeter.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(12, 155);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(170, 30);
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnMegsem
            // 
            this.BtnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnMegsem.Location = new System.Drawing.Point(195, 155);
            this.BtnMegsem.Name = "BtnMegsem";
            this.BtnMegsem.Size = new System.Drawing.Size(170, 30);
            this.BtnMegsem.TabIndex = 8;
            this.BtnMegsem.Text = "Mégsem";
            this.BtnMegsem.UseVisualStyleBackColor = true;
            // 
            // FrmUjJarmu
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnMegsem;
            this.ClientSize = new System.Drawing.Size(381, 197);
            this.Controls.Add(this.BtnMegsem);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrbAdminUjJarmuAdatai);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUjJarmu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új jármű hozzáadása";
            this.TbcAdminUjJarmu.ResumeLayout(false);
            this.TbpAdminAuto.ResumeLayout(false);
            this.TbpAdminMotor.ResumeLayout(false);
            this.GrbAdminUjJarmuAdatai.ResumeLayout(false);
            this.GrbAdminUjJarmuAdatai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFutottKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAdminUjMotorKobcentimeter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblRendszam;
        private System.Windows.Forms.Label LblFutottKM;
        private System.Windows.Forms.TabControl TbcAdminUjJarmu;
        private System.Windows.Forms.TabPage TbpAdminAuto;
        private System.Windows.Forms.TabPage TbpAdminMotor;
        private System.Windows.Forms.GroupBox GrbAdminUjJarmuAdatai;
        private System.Windows.Forms.NumericUpDown NudFutottKM;
        private System.Windows.Forms.TextBox TxbRendszam;
        private System.Windows.Forms.Label LblAdminUjAutoMotorTipus;
        private System.Windows.Forms.ComboBox CmbAdminUjAutoMotorTipus;
        private System.Windows.Forms.NumericUpDown NudAdminUjMotorKobcentimeter;
        private System.Windows.Forms.Label LblAdminUjMotorKobcenti;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnMegsem;
    }
}