namespace GreenLife_Organic_Store
{
    partial class ORDER_HISTORY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ORDER_HISTORY));
            this.lblorderhistory1 = new System.Windows.Forms.Label();
            this.dtpfrom1 = new System.Windows.Forms.DateTimePicker();
            this.lblFrom2 = new System.Windows.Forms.Label();
            this.lblto2 = new System.Windows.Forms.Label();
            this.dtpTo1 = new System.Windows.Forms.DateTimePicker();
            this.btnfilter = new System.Windows.Forms.Button();
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.btnrefresh2 = new System.Windows.Forms.Button();
            this.btnhome37 = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblorderhistory1
            // 
            this.lblorderhistory1.AutoSize = true;
            this.lblorderhistory1.BackColor = System.Drawing.Color.Transparent;
            this.lblorderhistory1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderhistory1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblorderhistory1.Location = new System.Drawing.Point(27, 45);
            this.lblorderhistory1.Name = "lblorderhistory1";
            this.lblorderhistory1.Size = new System.Drawing.Size(209, 36);
            this.lblorderhistory1.TabIndex = 1;
            this.lblorderhistory1.Text = "Order History";
            // 
            // dtpfrom1
            // 
            this.dtpfrom1.Location = new System.Drawing.Point(231, 144);
            this.dtpfrom1.Name = "dtpfrom1";
            this.dtpfrom1.Size = new System.Drawing.Size(200, 26);
            this.dtpfrom1.TabIndex = 2;
            // 
            // lblFrom2
            // 
            this.lblFrom2.AutoSize = true;
            this.lblFrom2.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrom2.Location = new System.Drawing.Point(148, 144);
            this.lblFrom2.Name = "lblFrom2";
            this.lblFrom2.Size = new System.Drawing.Size(77, 26);
            this.lblFrom2.TabIndex = 3;
            this.lblFrom2.Text = "From:";
            // 
            // lblto2
            // 
            this.lblto2.AutoSize = true;
            this.lblto2.BackColor = System.Drawing.Color.Transparent;
            this.lblto2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblto2.Location = new System.Drawing.Point(504, 144);
            this.lblto2.Name = "lblto2";
            this.lblto2.Size = new System.Drawing.Size(45, 26);
            this.lblto2.TabIndex = 4;
            this.lblto2.Text = "To:";
            // 
            // dtpTo1
            // 
            this.dtpTo1.Location = new System.Drawing.Point(555, 144);
            this.dtpTo1.Name = "dtpTo1";
            this.dtpTo1.Size = new System.Drawing.Size(200, 26);
            this.dtpTo1.TabIndex = 5;
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.OliveDrab;
            this.btnfilter.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfilter.Location = new System.Drawing.Point(811, 139);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(104, 38);
            this.btnfilter.TabIndex = 6;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Location = new System.Drawing.Point(70, 203);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.RowHeadersWidth = 62;
            this.dgvOrderHistory.RowTemplate.Height = 28;
            this.dgvOrderHistory.Size = new System.Drawing.Size(881, 268);
            this.dgvOrderHistory.TabIndex = 7;
            // 
            // btnrefresh2
            // 
            this.btnrefresh2.BackColor = System.Drawing.Color.OliveDrab;
            this.btnrefresh2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrefresh2.Location = new System.Drawing.Point(829, 486);
            this.btnrefresh2.Name = "btnrefresh2";
            this.btnrefresh2.Size = new System.Drawing.Size(122, 53);
            this.btnrefresh2.TabIndex = 12;
            this.btnrefresh2.Text = "Refresh";
            this.btnrefresh2.UseVisualStyleBackColor = false;
            this.btnrefresh2.Click += new System.EventHandler(this.btnrefresh2_Click);
            // 
            // btnhome37
            // 
            this.btnhome37.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhome37.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome37.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome37.Location = new System.Drawing.Point(33, 571);
            this.btnhome37.Name = "btnhome37";
            this.btnhome37.Size = new System.Drawing.Size(122, 53);
            this.btnhome37.TabIndex = 13;
            this.btnhome37.Text = "Home";
            this.btnhome37.UseVisualStyleBackColor = false;
            this.btnhome37.Click += new System.EventHandler(this.btnhome37_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.OliveDrab;
            this.btnViewDetails.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewDetails.Location = new System.Drawing.Point(794, 571);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(157, 53);
            this.btnViewDetails.TabIndex = 14;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // ORDER_HISTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 661);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnhome37);
            this.Controls.Add(this.btnrefresh2);
            this.Controls.Add(this.dgvOrderHistory);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.dtpTo1);
            this.Controls.Add(this.lblto2);
            this.Controls.Add(this.lblFrom2);
            this.Controls.Add(this.dtpfrom1);
            this.Controls.Add(this.lblorderhistory1);
            this.Name = "ORDER_HISTORY";
            this.Text = "ORDER_HISTORY";
            this.Load += new System.EventHandler(this.ORDER_HISTORY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblorderhistory1;
        private System.Windows.Forms.DateTimePicker dtpfrom1;
        private System.Windows.Forms.Label lblFrom2;
        private System.Windows.Forms.Label lblto2;
        private System.Windows.Forms.DateTimePicker dtpTo1;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.Button btnrefresh2;
        private System.Windows.Forms.Button btnhome37;
        private System.Windows.Forms.Button btnViewDetails;
    }
}