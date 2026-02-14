namespace GreenLife_Organic_Store
{
    partial class TrackYourorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackYourorder));
            this.btnhome4 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelOrderDetails = new System.Windows.Forms.Panel();
            this.lblSelectedOrderTotal = new System.Windows.Forms.Label();
            this.lblSelectedOrderTotalText = new System.Windows.Forms.Label();
            this.lblSelectedOrderStatus = new System.Windows.Forms.Label();
            this.lblSelectedOrderStatusText = new System.Windows.Forms.Label();
            this.lblSelectedOrderDate = new System.Windows.Forms.Label();
            this.lblSelectedOrderDateText = new System.Windows.Forms.Label();
            this.lblSelectedOrderID = new System.Windows.Forms.Label();
            this.lblSelectedOrderIDText = new System.Windows.Forms.Label();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.lblOrders = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblOrderTracking = new System.Windows.Forms.Label();
            this.panelOrderDetails.SuspendLayout();
            this.panelOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhome4
            // 
            this.btnhome4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnhome4.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhome4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome4.Location = new System.Drawing.Point(60, 580);
            this.btnhome4.Name = "btnhome4";
            this.btnhome4.Size = new System.Drawing.Size(107, 52);
            this.btnhome4.TabIndex = 9;
            this.btnhome4.Text = "Home";
            this.btnhome4.UseVisualStyleBackColor = false;
            this.btnhome4.Click += new System.EventHandler(this.btnhome4_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(945, 580);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 52);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelOrderDetails
            // 
            this.panelOrderDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelOrderDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderTotal);
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderTotalText);
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderStatus);
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderStatusText);
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderDate);
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderDateText);
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderID);
            this.panelOrderDetails.Controls.Add(this.lblSelectedOrderIDText);
            this.panelOrderDetails.Location = new System.Drawing.Point(258, 376);
            this.panelOrderDetails.Name = "panelOrderDetails";
            this.panelOrderDetails.Size = new System.Drawing.Size(623, 256);
            this.panelOrderDetails.TabIndex = 7;
            // 
            // lblSelectedOrderTotal
            // 
            this.lblSelectedOrderTotal.AutoSize = true;
            this.lblSelectedOrderTotal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderTotal.Location = new System.Drawing.Point(346, 202);
            this.lblSelectedOrderTotal.Name = "lblSelectedOrderTotal";
            this.lblSelectedOrderTotal.Size = new System.Drawing.Size(96, 20);
            this.lblSelectedOrderTotal.TabIndex = 16;
            this.lblSelectedOrderTotal.Text = "Grand Total";
            // 
            // lblSelectedOrderTotalText
            // 
            this.lblSelectedOrderTotalText.AutoSize = true;
            this.lblSelectedOrderTotalText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderTotalText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderTotalText.Location = new System.Drawing.Point(181, 202);
            this.lblSelectedOrderTotalText.Name = "lblSelectedOrderTotalText";
            this.lblSelectedOrderTotalText.Size = new System.Drawing.Size(96, 20);
            this.lblSelectedOrderTotalText.TabIndex = 15;
            this.lblSelectedOrderTotalText.Text = "Grand Total";
            // 
            // lblSelectedOrderStatus
            // 
            this.lblSelectedOrderStatus.AutoSize = true;
            this.lblSelectedOrderStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderStatus.Location = new System.Drawing.Point(346, 142);
            this.lblSelectedOrderStatus.Name = "lblSelectedOrderStatus";
            this.lblSelectedOrderStatus.Size = new System.Drawing.Size(53, 20);
            this.lblSelectedOrderStatus.TabIndex = 14;
            this.lblSelectedOrderStatus.Text = "Status";
            // 
            // lblSelectedOrderStatusText
            // 
            this.lblSelectedOrderStatusText.AutoSize = true;
            this.lblSelectedOrderStatusText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderStatusText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderStatusText.Location = new System.Drawing.Point(181, 142);
            this.lblSelectedOrderStatusText.Name = "lblSelectedOrderStatusText";
            this.lblSelectedOrderStatusText.Size = new System.Drawing.Size(53, 20);
            this.lblSelectedOrderStatusText.TabIndex = 13;
            this.lblSelectedOrderStatusText.Text = "Status";
            // 
            // lblSelectedOrderDate
            // 
            this.lblSelectedOrderDate.AutoSize = true;
            this.lblSelectedOrderDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderDate.Location = new System.Drawing.Point(346, 86);
            this.lblSelectedOrderDate.Name = "lblSelectedOrderDate";
            this.lblSelectedOrderDate.Size = new System.Drawing.Size(90, 20);
            this.lblSelectedOrderDate.TabIndex = 12;
            this.lblSelectedOrderDate.Text = "Order Date";
            // 
            // lblSelectedOrderDateText
            // 
            this.lblSelectedOrderDateText.AutoSize = true;
            this.lblSelectedOrderDateText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderDateText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderDateText.Location = new System.Drawing.Point(181, 86);
            this.lblSelectedOrderDateText.Name = "lblSelectedOrderDateText";
            this.lblSelectedOrderDateText.Size = new System.Drawing.Size(90, 20);
            this.lblSelectedOrderDateText.TabIndex = 11;
            this.lblSelectedOrderDateText.Text = "Order Date";
            // 
            // lblSelectedOrderID
            // 
            this.lblSelectedOrderID.AutoSize = true;
            this.lblSelectedOrderID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderID.Location = new System.Drawing.Point(346, 35);
            this.lblSelectedOrderID.Name = "lblSelectedOrderID";
            this.lblSelectedOrderID.Size = new System.Drawing.Size(75, 20);
            this.lblSelectedOrderID.TabIndex = 10;
            this.lblSelectedOrderID.Text = "Order ID";
            // 
            // lblSelectedOrderIDText
            // 
            this.lblSelectedOrderIDText.AutoSize = true;
            this.lblSelectedOrderIDText.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrderIDText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedOrderIDText.Location = new System.Drawing.Point(181, 35);
            this.lblSelectedOrderIDText.Name = "lblSelectedOrderIDText";
            this.lblSelectedOrderIDText.Size = new System.Drawing.Size(75, 20);
            this.lblSelectedOrderIDText.TabIndex = 9;
            this.lblSelectedOrderIDText.Text = "Order ID";
            // 
            // panelOrders
            // 
            this.panelOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrders.BackColor = System.Drawing.Color.Transparent;
            this.panelOrders.Controls.Add(this.lblOrders);
            this.panelOrders.Controls.Add(this.dgvOrders);
            this.panelOrders.Location = new System.Drawing.Point(60, 78);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(1036, 273);
            this.panelOrders.TabIndex = 6;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOrders.Location = new System.Drawing.Point(30, 29);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(142, 26);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Your Orders";
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(17, 58);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(976, 212);
            this.dgvOrders.TabIndex = 0;
            // 
            // lblOrderTracking
            // 
            this.lblOrderTracking.AutoSize = true;
            this.lblOrderTracking.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTracking.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTracking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrderTracking.Location = new System.Drawing.Point(34, 29);
            this.lblOrderTracking.Name = "lblOrderTracking";
            this.lblOrderTracking.Size = new System.Drawing.Size(229, 36);
            this.lblOrderTracking.TabIndex = 5;
            this.lblOrderTracking.Text = "Order Tracking";
            // 
            // TrackYourorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 680);
            this.Controls.Add(this.btnhome4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelOrderDetails);
            this.Controls.Add(this.panelOrders);
            this.Controls.Add(this.lblOrderTracking);
            this.Name = "TrackYourorder";
            this.Text = "TrackYourorder";
            this.Load += new System.EventHandler(this.TrackYourorder_Load);
            this.panelOrderDetails.ResumeLayout(false);
            this.panelOrderDetails.PerformLayout();
            this.panelOrders.ResumeLayout(false);
            this.panelOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhome4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblOrderTracking;
        private System.Windows.Forms.Label lblSelectedOrderTotal;
        private System.Windows.Forms.Label lblSelectedOrderTotalText;
        private System.Windows.Forms.Label lblSelectedOrderStatus;
        private System.Windows.Forms.Label lblSelectedOrderStatusText;
        private System.Windows.Forms.Label lblSelectedOrderDate;
        private System.Windows.Forms.Label lblSelectedOrderDateText;
        private System.Windows.Forms.Label lblSelectedOrderID;
        private System.Windows.Forms.Label lblSelectedOrderIDText;
    }
}