namespace NegyGomb
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
            this.BtnGeneralas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGeneralas
            // 
            this.BtnGeneralas.Location = new System.Drawing.Point(12, 12);
            this.BtnGeneralas.Name = "BtnGeneralas";
            this.BtnGeneralas.Size = new System.Drawing.Size(100, 23);
            this.BtnGeneralas.TabIndex = 0;
            this.BtnGeneralas.Text = "Generalas";
            this.BtnGeneralas.UseVisualStyleBackColor = true;
            this.BtnGeneralas.Click += new System.EventHandler(this.BtnGeneralas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BtnGeneralas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negy gomb dinamikusan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGeneralas;
    }
}

