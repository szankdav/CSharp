namespace BillenoGombGDIPelda
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
            this.billenoGomb1 = new BillenoGombGDIPelda.BillenoGomb();
            this.SuspendLayout();
            // 
            // billenoGomb1
            // 
            this.billenoGomb1.CheckState = false;
            this.billenoGomb1.LedColor = System.Drawing.Color.Green;
            this.billenoGomb1.Location = new System.Drawing.Point(337, 159);
            this.billenoGomb1.MinimumSize = new System.Drawing.Size(100, 70);
            this.billenoGomb1.Name = "billenoGomb1";
            this.billenoGomb1.Size = new System.Drawing.Size(100, 70);
            this.billenoGomb1.TabIndex = 0;
            this.billenoGomb1.Text = "billenoGomb1";
            this.billenoGomb1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.billenoGomb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BillenoGomb billenoGomb1;
    }
}

