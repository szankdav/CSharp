namespace SinglecastDelegatePelda
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NudElsoOp = new System.Windows.Forms.NumericUpDown();
            this.NudMasodikOp = new System.Windows.Forms.NumericUpDown();
            this.CmbMuvelet = new System.Windows.Forms.ComboBox();
            this.BtnSzamolas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudElsoOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMasodikOp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elso operandus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masodik operandus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Muvelet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NudElsoOp
            // 
            this.NudElsoOp.Location = new System.Drawing.Point(167, 12);
            this.NudElsoOp.Name = "NudElsoOp";
            this.NudElsoOp.Size = new System.Drawing.Size(150, 22);
            this.NudElsoOp.TabIndex = 3;
            // 
            // NudMasodikOp
            // 
            this.NudMasodikOp.Location = new System.Drawing.Point(167, 40);
            this.NudMasodikOp.Name = "NudMasodikOp";
            this.NudMasodikOp.Size = new System.Drawing.Size(150, 22);
            this.NudMasodikOp.TabIndex = 4;
            // 
            // CmbMuvelet
            // 
            this.CmbMuvelet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMuvelet.FormattingEnabled = true;
            this.CmbMuvelet.Location = new System.Drawing.Point(166, 68);
            this.CmbMuvelet.Name = "CmbMuvelet";
            this.CmbMuvelet.Size = new System.Drawing.Size(150, 24);
            this.CmbMuvelet.TabIndex = 5;
            this.CmbMuvelet.SelectedIndexChanged += new System.EventHandler(this.CmbMuvelet_SelectedIndexChanged);
            // 
            // BtnSzamolas
            // 
            this.BtnSzamolas.Location = new System.Drawing.Point(11, 98);
            this.BtnSzamolas.Name = "BtnSzamolas";
            this.BtnSzamolas.Size = new System.Drawing.Size(306, 40);
            this.BtnSzamolas.TabIndex = 6;
            this.BtnSzamolas.Text = "Szamolas";
            this.BtnSzamolas.UseVisualStyleBackColor = true;
            this.BtnSzamolas.Click += new System.EventHandler(this.BtnSzamolas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 150);
            this.Controls.Add(this.BtnSzamolas);
            this.Controls.Add(this.CmbMuvelet);
            this.Controls.Add(this.NudMasodikOp);
            this.Controls.Add(this.NudElsoOp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Singlecast Delegate Pelda";
            ((System.ComponentModel.ISupportInitialize)(this.NudElsoOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMasodikOp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NudElsoOp;
        private System.Windows.Forms.NumericUpDown NudMasodikOp;
        private System.Windows.Forms.ComboBox CmbMuvelet;
        private System.Windows.Forms.Button BtnSzamolas;
    }
}

