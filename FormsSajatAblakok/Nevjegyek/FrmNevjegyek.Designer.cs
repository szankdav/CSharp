namespace Nevjegyek
{
    partial class FrmNevjegyek
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
            this.BtnSajat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSajat
            // 
            this.BtnSajat.Location = new System.Drawing.Point(13, 13);
            this.BtnSajat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSajat.Name = "BtnSajat";
            this.BtnSajat.Size = new System.Drawing.Size(200, 40);
            this.BtnSajat.TabIndex = 0;
            this.BtnSajat.Text = "Nevjegy sajat dialogussal";
            this.BtnSajat.UseVisualStyleBackColor = true;
            this.BtnSajat.Click += new System.EventHandler(this.BtnSajat_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 61);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nevjegy about box segitsegevel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmNevjegyek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 119);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSajat);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNevjegyek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nevjegyek bemutatasa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSajat;
        private System.Windows.Forms.Button button2;
    }
}

