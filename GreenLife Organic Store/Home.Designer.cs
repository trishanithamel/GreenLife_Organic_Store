namespace GreenLife_Organic_Store
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngetstart = new System.Windows.Forms.Button();
            this.lblGreenLife = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btngetstart);
            this.panel1.Controls.Add(this.lblGreenLife);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 539);
            this.panel1.TabIndex = 0;
            // 
            // btngetstart
            // 
            this.btngetstart.BackColor = System.Drawing.Color.OliveDrab;
            this.btngetstart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetstart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngetstart.Location = new System.Drawing.Point(360, 282);
            this.btngetstart.Name = "btngetstart";
            this.btngetstart.Size = new System.Drawing.Size(168, 53);
            this.btngetstart.TabIndex = 1;
            this.btngetstart.Text = "GET START";
            this.btngetstart.UseVisualStyleBackColor = false;
            this.btngetstart.Click += new System.EventHandler(this.BtnGetStart_Click);
            // 
            // lblGreenLife
            // 
            this.lblGreenLife.AutoSize = true;
            this.lblGreenLife.BackColor = System.Drawing.Color.Transparent;
            this.lblGreenLife.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenLife.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGreenLife.Location = new System.Drawing.Point(274, 209);
            this.lblGreenLife.Name = "lblGreenLife";
            this.lblGreenLife.Size = new System.Drawing.Size(361, 44);
            this.lblGreenLife.TabIndex = 0;
            this.lblGreenLife.Text = "GreenLife Organic Store ";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 539);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btngetstart;
        private System.Windows.Forms.Label lblGreenLife;
    }
}

