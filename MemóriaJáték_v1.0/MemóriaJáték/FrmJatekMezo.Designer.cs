namespace MemóriaJáték
{
    partial class FrmJatekMezo
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
            this.LblIdomero = new System.Windows.Forms.Label();
            this.BtnUjJatekJatekbol = new System.Windows.Forms.Button();
            this.BtnKilepesJatekbol = new System.Windows.Forms.Button();
            this.GrbJatekMezo = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblIdomero
            // 
            this.LblIdomero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblIdomero.Location = new System.Drawing.Point(12, 9);
            this.LblIdomero.Name = "LblIdomero";
            this.LblIdomero.Size = new System.Drawing.Size(154, 40);
            this.LblIdomero.TabIndex = 0;
            this.LblIdomero.Text = "label1";
            this.LblIdomero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnUjJatekJatekbol
            // 
            this.BtnUjJatekJatekbol.Location = new System.Drawing.Point(172, 9);
            this.BtnUjJatekJatekbol.Name = "BtnUjJatekJatekbol";
            this.BtnUjJatekJatekbol.Size = new System.Drawing.Size(150, 40);
            this.BtnUjJatekJatekbol.TabIndex = 1;
            this.BtnUjJatekJatekbol.Text = "Új játék";
            this.BtnUjJatekJatekbol.UseVisualStyleBackColor = true;
            this.BtnUjJatekJatekbol.Click += new System.EventHandler(this.BtnUjJatekJatekbol_Click);
            // 
            // BtnKilepesJatekbol
            // 
            this.BtnKilepesJatekbol.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnKilepesJatekbol.Location = new System.Drawing.Point(359, 9);
            this.BtnKilepesJatekbol.Name = "BtnKilepesJatekbol";
            this.BtnKilepesJatekbol.Size = new System.Drawing.Size(150, 40);
            this.BtnKilepesJatekbol.TabIndex = 2;
            this.BtnKilepesJatekbol.Text = "Kilépés";
            this.BtnKilepesJatekbol.UseVisualStyleBackColor = true;
            this.BtnKilepesJatekbol.Click += new System.EventHandler(this.BtnKilepesJatekbol_Click);
            // 
            // GrbJatekMezo
            // 
            this.GrbJatekMezo.Location = new System.Drawing.Point(12, 55);
            this.GrbJatekMezo.Name = "GrbJatekMezo";
            this.GrbJatekMezo.Size = new System.Drawing.Size(497, 262);
            this.GrbJatekMezo.TabIndex = 3;
            this.GrbJatekMezo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmJatekMezo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnKilepesJatekbol;
            this.ClientSize = new System.Drawing.Size(521, 329);
            this.Controls.Add(this.GrbJatekMezo);
            this.Controls.Add(this.BtnKilepesJatekbol);
            this.Controls.Add(this.BtnUjJatekJatekbol);
            this.Controls.Add(this.LblIdomero);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJatekMezo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmJatekMezo_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblIdomero;
        private System.Windows.Forms.Button BtnUjJatekJatekbol;
        private System.Windows.Forms.Button BtnKilepesJatekbol;
        private System.Windows.Forms.GroupBox GrbJatekMezo;
        private System.Windows.Forms.Timer timer1;
    }
}