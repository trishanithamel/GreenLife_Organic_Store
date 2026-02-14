namespace GreenLife_Organic_Store
{
    partial class CustomerDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashbord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblq = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblword = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblCustomerdashbord = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncustomerreview = new System.Windows.Forms.Button();
            this.btnlogout2 = new System.Windows.Forms.Button();
            this.btnProfileManagement = new System.Windows.Forms.Button();
            this.btntrack = new System.Windows.Forms.Button();
            this.btnPlaceOrders = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblq);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblword);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.lblCustomerdashbord);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 677);
            this.panel1.TabIndex = 0;
            // 
            // lblq
            // 
            this.lblq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblq.AutoSize = true;
            this.lblq.BackColor = System.Drawing.Color.Transparent;
            this.lblq.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblq.Location = new System.Drawing.Point(372, 514);
            this.lblq.Name = "lblq";
            this.lblq.Size = new System.Drawing.Size(594, 60);
            this.lblq.TabIndex = 5;
            this.lblq.Text = resources.GetString("lblq.Text");
            this.lblq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(523, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 199);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblword
            // 
            this.lblword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblword.AutoSize = true;
            this.lblword.BackColor = System.Drawing.Color.Transparent;
            this.lblword.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblword.Location = new System.Drawing.Point(541, 470);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(220, 20);
            this.lblword.TabIndex = 3;
            this.lblword.Text = "\"Fresh. Healthy. Sustainable.\"";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lblWelcome.Location = new System.Drawing.Point(348, 400);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(667, 41);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to GreenLife Organic Store";
            // 
            // lblCustomerdashbord
            // 
            this.lblCustomerdashbord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomerdashbord.AutoSize = true;
            this.lblCustomerdashbord.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerdashbord.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerdashbord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCustomerdashbord.Location = new System.Drawing.Point(527, 38);
            this.lblCustomerdashbord.Name = "lblCustomerdashbord";
            this.lblCustomerdashbord.Size = new System.Drawing.Size(292, 36);
            this.lblCustomerdashbord.TabIndex = 1;
            this.lblCustomerdashbord.Text = "Customer Dashbord";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.Controls.Add(this.btncustomerreview);
            this.panel2.Controls.Add(this.btnlogout2);
            this.panel2.Controls.Add(this.btnProfileManagement);
            this.panel2.Controls.Add(this.btntrack);
            this.panel2.Controls.Add(this.btnPlaceOrders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 677);
            this.panel2.TabIndex = 0;
            // 
            // btncustomerreview
            // 
            this.btncustomerreview.BackColor = System.Drawing.Color.OliveDrab;
            this.btncustomerreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomerreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncustomerreview.Location = new System.Drawing.Point(11, 445);
            this.btncustomerreview.Name = "btncustomerreview";
            this.btncustomerreview.Size = new System.Drawing.Size(250, 70);
            this.btncustomerreview.TabIndex = 4;
            this.btncustomerreview.Text = "Customer Reviews";
            this.btncustomerreview.UseVisualStyleBackColor = false;
            this.btncustomerreview.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogout2
            // 
            this.btnlogout2.BackColor = System.Drawing.Color.Khaki;
            this.btnlogout2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogout2.Location = new System.Drawing.Point(61, 560);
            this.btnlogout2.Name = "btnlogout2";
            this.btnlogout2.Size = new System.Drawing.Size(110, 68);
            this.btnlogout2.TabIndex = 3;
            this.btnlogout2.Text = "Logout";
            this.btnlogout2.UseVisualStyleBackColor = false;
            this.btnlogout2.Click += new System.EventHandler(this.btnlogout2_Click);
            // 
            // btnProfileManagement
            // 
            this.btnProfileManagement.BackColor = System.Drawing.Color.OliveDrab;
            this.btnProfileManagement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfileManagement.Location = new System.Drawing.Point(11, 317);
            this.btnProfileManagement.Name = "btnProfileManagement";
            this.btnProfileManagement.Size = new System.Drawing.Size(250, 70);
            this.btnProfileManagement.TabIndex = 2;
            this.btnProfileManagement.Text = "Profile Management";
            this.btnProfileManagement.UseVisualStyleBackColor = false;
            this.btnProfileManagement.Click += new System.EventHandler(this.btnProfileManagement_Click);
            // 
            // btntrack
            // 
            this.btntrack.BackColor = System.Drawing.Color.OliveDrab;
            this.btntrack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntrack.Location = new System.Drawing.Point(11, 198);
            this.btntrack.Name = "btntrack";
            this.btntrack.Size = new System.Drawing.Size(241, 67);
            this.btntrack.TabIndex = 1;
            this.btntrack.Text = "Track Your Order ";
            this.btntrack.UseVisualStyleBackColor = false;
            this.btntrack.Click += new System.EventHandler(this.btntrack_Click);
            // 
            // btnPlaceOrders
            // 
            this.btnPlaceOrders.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPlaceOrders.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlaceOrders.Location = new System.Drawing.Point(11, 86);
            this.btnPlaceOrders.Name = "btnPlaceOrders";
            this.btnPlaceOrders.Size = new System.Drawing.Size(241, 66);
            this.btnPlaceOrders.TabIndex = 0;
            this.btnPlaceOrders.Text = "Place Orders";
            this.btnPlaceOrders.UseVisualStyleBackColor = false;
            this.btnPlaceOrders.Click += new System.EventHandler(this.btnPlaceOrders_Click);
            // 
            // CustomerDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 677);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashbord";
            this.Load += new System.EventHandler(this.CustomerDashbord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomerdashbord;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btntrack;
        private System.Windows.Forms.Button btnPlaceOrders;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout2;
        private System.Windows.Forms.Button btnProfileManagement;
        private System.Windows.Forms.Button btncustomerreview;
        private System.Windows.Forms.Label lblq;
    }
}