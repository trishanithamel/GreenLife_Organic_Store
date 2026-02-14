namespace GreenLife_Organic_Store
{
    partial class OrderDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsForm));
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnhome38 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderDetails.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrderDetails.Location = new System.Drawing.Point(36, 49);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(201, 36);
            this.lblOrderDetails.TabIndex = 2;
            this.lblOrderDetails.Text = "Order Details";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrderID.Location = new System.Drawing.Point(482, 128);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(111, 26);
            this.lblOrderID.TabIndex = 4;
            this.lblOrderID.Text = "OrderID:";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(215, 190);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 62;
            this.dgvOrderItems.RowTemplate.Height = 28;
            this.dgvOrderItems.Size = new System.Drawing.Size(707, 305);
            this.dgvOrderItems.TabIndex = 6;
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.Color.OliveDrab;
            this.btnClose1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose1.Location = new System.Drawing.Point(871, 561);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(113, 53);
            this.btnClose1.TabIndex = 7;
            this.btnClose1.Text = "Close";
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.OliveDrab;
            this.btnexport.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexport.Location = new System.Drawing.Point(215, 516);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(113, 53);
            this.btnexport.TabIndex = 8;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnhome38
            // 
            this.btnhome38.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhome38.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome38.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome38.Location = new System.Drawing.Point(29, 561);
            this.btnhome38.Name = "btnhome38";
            this.btnhome38.Size = new System.Drawing.Size(113, 53);
            this.btnhome38.TabIndex = 9;
            this.btnhome38.Text = "Home";
            this.btnhome38.UseVisualStyleBackColor = false;
            this.btnhome38.Click += new System.EventHandler(this.btnhome38_Click);
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 656);
            this.Controls.Add(this.btnhome38);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblOrderDetails);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnhome38;
    }
}