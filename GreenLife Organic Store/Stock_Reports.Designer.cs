namespace GreenLife_Organic_Store
{
    partial class Stock_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Reports));
            this.lblstockReport1 = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnhome36 = new System.Windows.Forms.Button();
            this.btnrefresh1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstockReport1
            // 
            this.lblstockReport1.AutoSize = true;
            this.lblstockReport1.BackColor = System.Drawing.Color.Transparent;
            this.lblstockReport1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockReport1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblstockReport1.Location = new System.Drawing.Point(49, 40);
            this.lblstockReport1.Name = "lblstockReport1";
            this.lblstockReport1.Size = new System.Drawing.Size(195, 36);
            this.lblstockReport1.TabIndex = 1;
            this.lblstockReport1.Text = "Stock Report";
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(88, 115);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(834, 344);
            this.dgvStock.TabIndex = 2;
            // 
            // btnhome36
            // 
            this.btnhome36.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhome36.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome36.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome36.Location = new System.Drawing.Point(39, 552);
            this.btnhome36.Name = "btnhome36";
            this.btnhome36.Size = new System.Drawing.Size(122, 53);
            this.btnhome36.TabIndex = 10;
            this.btnhome36.Text = "Home";
            this.btnhome36.UseVisualStyleBackColor = false;
            this.btnhome36.Click += new System.EventHandler(this.btnhome36_Click);
            // 
            // btnrefresh1
            // 
            this.btnrefresh1.BackColor = System.Drawing.Color.OliveDrab;
            this.btnrefresh1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrefresh1.Location = new System.Drawing.Point(783, 465);
            this.btnrefresh1.Name = "btnrefresh1";
            this.btnrefresh1.Size = new System.Drawing.Size(122, 53);
            this.btnrefresh1.TabIndex = 11;
            this.btnrefresh1.Text = "Refresh";
            this.btnrefresh1.UseVisualStyleBackColor = false;
            // 
            // Stock_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 644);
            this.Controls.Add(this.btnrefresh1);
            this.Controls.Add(this.btnhome36);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.lblstockReport1);
            this.Name = "Stock_Reports";
            this.Text = "Stock_Reports";
            this.Load += new System.EventHandler(this.Stock_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstockReport1;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnhome36;
        private System.Windows.Forms.Button btnrefresh1;
    }
}