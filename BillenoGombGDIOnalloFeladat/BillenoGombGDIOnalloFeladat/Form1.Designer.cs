namespace BillenoGombGDIOnalloFeladat
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
            this.csuszkaGomb1 = new BillenoGombGDIOnalloFeladat.CsuszkaGomb();
            this.SuspendLayout();
            // 
            // csuszkaGomb1
            // 
            this.csuszkaGomb1.BackgroundColor = System.Drawing.Color.Blue;
            this.csuszkaGomb1.Checkstate = false;
            this.csuszkaGomb1.ForegroundColor = System.Drawing.Color.White;
            this.csuszkaGomb1.Location = new System.Drawing.Point(211, 132);
            this.csuszkaGomb1.MinimumSize = new System.Drawing.Size(100, 30);
            this.csuszkaGomb1.Name = "csuszkaGomb1";
            this.csuszkaGomb1.Size = new System.Drawing.Size(100, 30);
            this.csuszkaGomb1.TabIndex = 0;
            this.csuszkaGomb1.Text = "csuszkaGomb1";
            this.csuszkaGomb1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.csuszkaGomb1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CsuszkaGomb csuszkaGomb1;
    }
}

