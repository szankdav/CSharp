namespace Szankovszky_David_Vizsga
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
            this.DgvCars = new System.Windows.Forms.DataGridView();
            this.BtnNewCar = new System.Windows.Forms.Button();
            this.BtnMostExpensiveCar = new System.Windows.Forms.Button();
            this.BtnAveragePrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCars
            // 
            this.DgvCars.AllowUserToAddRows = false;
            this.DgvCars.AllowUserToDeleteRows = false;
            this.DgvCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCars.Location = new System.Drawing.Point(16, 15);
            this.DgvCars.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCars.Name = "DgvCars";
            this.DgvCars.ReadOnly = true;
            this.DgvCars.Size = new System.Drawing.Size(1010, 185);
            this.DgvCars.TabIndex = 0;
            // 
            // BtnNewCar
            // 
            this.BtnNewCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnNewCar.Location = new System.Drawing.Point(16, 207);
            this.BtnNewCar.Name = "BtnNewCar";
            this.BtnNewCar.Size = new System.Drawing.Size(201, 51);
            this.BtnNewCar.TabIndex = 1;
            this.BtnNewCar.Text = "Add new car";
            this.BtnNewCar.UseVisualStyleBackColor = true;
            this.BtnNewCar.Click += new System.EventHandler(this.BtnNewCar_Click);
            // 
            // BtnMostExpensiveCar
            // 
            this.BtnMostExpensiveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMostExpensiveCar.Location = new System.Drawing.Point(825, 207);
            this.BtnMostExpensiveCar.Name = "BtnMostExpensiveCar";
            this.BtnMostExpensiveCar.Size = new System.Drawing.Size(201, 51);
            this.BtnMostExpensiveCar.TabIndex = 4;
            this.BtnMostExpensiveCar.Text = "Most expensive car";
            this.BtnMostExpensiveCar.UseVisualStyleBackColor = true;
            this.BtnMostExpensiveCar.Click += new System.EventHandler(this.BtnMostExpensiveCar_Click);
            // 
            // BtnAveragePrice
            // 
            this.BtnAveragePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAveragePrice.Location = new System.Drawing.Point(420, 206);
            this.BtnAveragePrice.Name = "BtnAveragePrice";
            this.BtnAveragePrice.Size = new System.Drawing.Size(201, 51);
            this.BtnAveragePrice.TabIndex = 5;
            this.BtnAveragePrice.Text = "Average price";
            this.BtnAveragePrice.UseVisualStyleBackColor = true;
            this.BtnAveragePrice.Click += new System.EventHandler(this.BtnAveragePrice_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 269);
            this.Controls.Add(this.BtnAveragePrice);
            this.Controls.Add(this.BtnMostExpensiveCar);
            this.Controls.Add(this.BtnNewCar);
            this.Controls.Add(this.DgvCars);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCars;
        private System.Windows.Forms.Button BtnNewCar;
        private System.Windows.Forms.Button BtnMostExpensiveCar;
        private System.Windows.Forms.Button BtnAveragePrice;
    }
}

