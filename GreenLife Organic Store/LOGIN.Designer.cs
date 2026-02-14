namespace GreenLife_Organic_Store
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkregister = new System.Windows.Forms.LinkLabel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lBLLOGIN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnback1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lnkregister);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.lBLLOGIN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 541);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnback1
            // 
            this.btnback1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnback1.BackColor = System.Drawing.SystemColors.Info;
            this.btnback1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback1.Location = new System.Drawing.Point(24, 478);
            this.btnback1.Name = "btnback1";
            this.btnback1.Size = new System.Drawing.Size(77, 42);
            this.btnback1.TabIndex = 7;
            this.btnback1.Text = "Back";
            this.btnback1.UseVisualStyleBackColor = false;
            this.btnback1.Click += new System.EventHandler(this.btnback1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.OliveDrab;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(393, 321);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 46);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkregister
            // 
            this.lnkregister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkregister.AutoSize = true;
            this.lnkregister.BackColor = System.Drawing.Color.Transparent;
            this.lnkregister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkregister.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.lnkregister.Location = new System.Drawing.Point(342, 386);
            this.lnkregister.Name = "lnkregister";
            this.lnkregister.Size = new System.Drawing.Size(251, 26);
            this.lnkregister.TabIndex = 5;
            this.lnkregister.TabStop = true;
            this.lnkregister.Text = "Don\'t have an account?";
            this.lnkregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkregister_LinkClicked);
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.Location = new System.Drawing.Point(365, 250);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(306, 26);
            this.txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusername.Location = new System.Drawing.Point(365, 176);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(306, 26);
            this.txtusername.TabIndex = 3;
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpassword.Location = new System.Drawing.Point(162, 250);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(110, 26);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusername.Location = new System.Drawing.Point(157, 176);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(125, 26);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "User Name";
            // 
            // lBLLOGIN
            // 
            this.lBLLOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBLLOGIN.AutoSize = true;
            this.lBLLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.lBLLOGIN.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLLOGIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lBLLOGIN.Location = new System.Drawing.Point(385, 42);
            this.lBLLOGIN.Name = "lBLLOGIN";
            this.lBLLOGIN.Size = new System.Drawing.Size(155, 45);
            this.lBLLOGIN.TabIndex = 0;
            this.lBLLOGIN.Text = "LOGIN";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.panel1);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lBLLOGIN;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkregister;
        private System.Windows.Forms.Button btnback1;
    }
}