namespace GreenLife_Organic_Store
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.btnhome34 = new System.Windows.Forms.Button();
            this.btnSALESREPORT = new System.Windows.Forms.Button();
            this.lblreports = new System.Windows.Forms.Label();
            this.btnstock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhome34
            // 
            this.btnhome34.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhome34.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome34.Location = new System.Drawing.Point(35, 440);
            this.btnhome34.Name = "btnhome34";
            this.btnhome34.Size = new System.Drawing.Size(113, 53);
            this.btnhome34.TabIndex = 0;
            this.btnhome34.Text = "Home";
            this.btnhome34.UseVisualStyleBackColor = false;
            this.btnhome34.Click += new System.EventHandler(this.btnhome34_Click);
            // 
            // btnSALESREPORT
            // 
            this.btnSALESREPORT.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSALESREPORT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALESREPORT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSALESREPORT.Location = new System.Drawing.Point(121, 216);
            this.btnSALESREPORT.Name = "btnSALESREPORT";
            this.btnSALESREPORT.Size = new System.Drawing.Size(166, 75);
            this.btnSALESREPORT.TabIndex = 1;
            this.btnSALESREPORT.Text = "sales Report";
            this.btnSALESREPORT.UseVisualStyleBackColor = false;
            this.btnSALESREPORT.Click += new System.EventHandler(this.btnSALESREPORT_Click);
            // 
            // lblreports
            // 
            this.lblreports.AutoSize = true;
            this.lblreports.BackColor = System.Drawing.Color.Transparent;
            this.lblreports.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblreports.Location = new System.Drawing.Point(29, 42);
            this.lblreports.Name = "lblreports";
            this.lblreports.Size = new System.Drawing.Size(478, 36);
            this.lblreports.TabIndex = 4;
            this.lblreports.Text = "GreenLife Organic Store  Reports";
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.Color.OliveDrab;
            this.btnstock.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnstock.Location = new System.Drawing.Point(362, 216);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(166, 75);
            this.btnstock.TabIndex = 5;
            this.btnstock.Text = "Stock Report";
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(601, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Order Hitory Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnstock);
            this.Controls.Add(this.lblreports);
            this.Controls.Add(this.btnSALESREPORT);
            this.Controls.Add(this.btnhome34);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhome34;
        private System.Windows.Forms.Button btnSALESREPORT;
        private System.Windows.Forms.Label lblreports;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button button1;
    }
}