namespace GreenLife_Organic_Store
{
    partial class SALES_REPORT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SALES_REPORT));
            this.lblSalesReport1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnbtnGenerate = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lbltotalsum = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.btnhome35 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesReport1
            // 
            this.lblSalesReport1.AutoSize = true;
            this.lblSalesReport1.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesReport1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSalesReport1.Location = new System.Drawing.Point(41, 45);
            this.lblSalesReport1.Name = "lblSalesReport1";
            this.lblSalesReport1.Size = new System.Drawing.Size(188, 36);
            this.lblSalesReport1.TabIndex = 0;
            this.lblSalesReport1.Text = "Sales Report";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrom.Location = new System.Drawing.Point(57, 142);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(77, 26);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTo.Location = new System.Drawing.Point(387, 142);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(45, 26);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To:";
            // 
            // btnbtnGenerate
            // 
            this.btnbtnGenerate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnbtnGenerate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbtnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbtnGenerate.Location = new System.Drawing.Point(687, 137);
            this.btnbtnGenerate.Name = "btnbtnGenerate";
            this.btnbtnGenerate.Size = new System.Drawing.Size(104, 38);
            this.btnbtnGenerate.TabIndex = 3;
            this.btnbtnGenerate.Text = "Generate";
            this.btnbtnGenerate.UseVisualStyleBackColor = false;
            this.btnbtnGenerate.Click += new System.EventHandler(this.btnbtnGenerate_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(140, 142);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpFrom.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(438, 142);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 5;
            // 
            // dgvSales
            // 
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(140, 221);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 62;
            this.dgvSales.RowTemplate.Height = 28;
            this.dgvSales.Size = new System.Drawing.Size(680, 268);
            this.dgvSales.TabIndex = 6;
            // 
            // lbltotalsum
            // 
            this.lbltotalsum.AutoSize = true;
            this.lbltotalsum.BackColor = System.Drawing.Color.Transparent;
            this.lbltotalsum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotalsum.Location = new System.Drawing.Point(302, 516);
            this.lbltotalsum.Name = "lbltotalsum";
            this.lbltotalsum.Size = new System.Drawing.Size(130, 26);
            this.lbltotalsum.TabIndex = 7;
            this.lbltotalsum.Text = "Total Sales:";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(489, 516);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(183, 26);
            this.txtTotalSales.TabIndex = 8;
            // 
            // btnhome35
            // 
            this.btnhome35.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhome35.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome35.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome35.Location = new System.Drawing.Point(12, 533);
            this.btnhome35.Name = "btnhome35";
            this.btnhome35.Size = new System.Drawing.Size(122, 53);
            this.btnhome35.TabIndex = 9;
            this.btnhome35.Text = "Home";
            this.btnhome35.UseVisualStyleBackColor = false;
            this.btnhome35.Click += new System.EventHandler(this.btnhome35_Click);
            // 
            // SALES_REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 609);
            this.Controls.Add(this.btnhome35);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.lbltotalsum);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnbtnGenerate);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblSalesReport1);
            this.Name = "SALES_REPORT";
            this.Text = "SALES_REPORT";
            this.Load += new System.EventHandler(this.SALES_REPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesReport1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnbtnGenerate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lbltotalsum;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Button btnhome35;
    }
}