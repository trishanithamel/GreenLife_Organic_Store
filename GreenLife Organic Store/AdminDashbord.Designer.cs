namespace GreenLife_Organic_Store
{
    partial class AdminDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashbord));
            this.lblAdminDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.dgvadmindashbord = new System.Windows.Forms.DataGridView();
            this.btnregisteradmin = new System.Windows.Forms.Button();
            this.btnrefresh3 = new System.Windows.Forms.Button();
            this.btnReview1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadmindashbord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminDashboard
            // 
            this.lblAdminDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdminDashboard.AutoSize = true;
            this.lblAdminDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminDashboard.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdminDashboard.Location = new System.Drawing.Point(535, 60);
            this.lblAdminDashboard.Name = "lblAdminDashboard";
            this.lblAdminDashboard.Size = new System.Drawing.Size(269, 36);
            this.lblAdminDashboard.TabIndex = 0;
            this.lblAdminDashboard.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnManageOrders);
            this.panel1.Controls.Add(this.btnManageCustomers);
            this.panel1.Controls.Add(this.btnManageProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 665);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Khaki;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(85, 548);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 55);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReports.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Location = new System.Drawing.Point(25, 439);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(255, 59);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.BackColor = System.Drawing.Color.OliveDrab;
            this.btnManageOrders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageOrders.Location = new System.Drawing.Point(25, 298);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(255, 59);
            this.btnManageOrders.TabIndex = 2;
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = false;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.Color.OliveDrab;
            this.btnManageCustomers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageCustomers.Location = new System.Drawing.Point(25, 161);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(255, 57);
            this.btnManageCustomers.TabIndex = 1;
            this.btnManageCustomers.Text = "Manage Customers";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.BackColor = System.Drawing.Color.OliveDrab;
            this.btnManageProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageProducts.Location = new System.Drawing.Point(25, 54);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(255, 54);
            this.btnManageProducts.TabIndex = 0;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = false;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // dgvadmindashbord
            // 
            this.dgvadmindashbord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvadmindashbord.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvadmindashbord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadmindashbord.Location = new System.Drawing.Point(360, 152);
            this.dgvadmindashbord.Name = "dgvadmindashbord";
            this.dgvadmindashbord.RowHeadersWidth = 62;
            this.dgvadmindashbord.RowTemplate.Height = 28;
            this.dgvadmindashbord.Size = new System.Drawing.Size(646, 382);
            this.dgvadmindashbord.TabIndex = 2;
            // 
            // btnregisteradmin
            // 
            this.btnregisteradmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnregisteradmin.BackColor = System.Drawing.Color.OliveDrab;
            this.btnregisteradmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregisteradmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnregisteradmin.Location = new System.Drawing.Point(896, 581);
            this.btnregisteradmin.Name = "btnregisteradmin";
            this.btnregisteradmin.Size = new System.Drawing.Size(127, 59);
            this.btnregisteradmin.TabIndex = 3;
            this.btnregisteradmin.Text = "Register ";
            this.btnregisteradmin.UseVisualStyleBackColor = false;
            this.btnregisteradmin.Click += new System.EventHandler(this.btnregisteradmin_Click);
            // 
            // btnrefresh3
            // 
            this.btnrefresh3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnrefresh3.BackColor = System.Drawing.Color.OliveDrab;
            this.btnrefresh3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrefresh3.Location = new System.Drawing.Point(360, 585);
            this.btnrefresh3.Name = "btnrefresh3";
            this.btnrefresh3.Size = new System.Drawing.Size(106, 55);
            this.btnrefresh3.TabIndex = 5;
            this.btnrefresh3.Text = "Refresh";
            this.btnrefresh3.UseVisualStyleBackColor = false;
            this.btnrefresh3.Click += new System.EventHandler(this.btnrefresh3_Click);
            // 
            // btnReview1
            // 
            this.btnReview1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReview1.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReview1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReview1.Location = new System.Drawing.Point(601, 583);
            this.btnReview1.Name = "btnReview1";
            this.btnReview1.Size = new System.Drawing.Size(168, 55);
            this.btnReview1.TabIndex = 6;
            this.btnReview1.Text = "View Review";
            this.btnReview1.UseVisualStyleBackColor = false;
            this.btnReview1.Click += new System.EventHandler(this.btnReview1_Click_1);
            // 
            // AdminDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 665);
            this.Controls.Add(this.btnReview1);
            this.Controls.Add(this.btnrefresh3);
            this.Controls.Add(this.btnregisteradmin);
            this.Controls.Add(this.dgvadmindashbord);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAdminDashboard);
            this.Name = "AdminDashbord";
            this.Text = "AdminDashbord";
            this.Load += new System.EventHandler(this.AdminDashbord_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvadmindashbord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvadmindashbord;
        private System.Windows.Forms.Button btnregisteradmin;
        private System.Windows.Forms.Button btnrefresh3;
        private System.Windows.Forms.Button btnReview1;
    }
}