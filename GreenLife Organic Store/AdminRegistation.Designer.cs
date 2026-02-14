namespace GreenLife_Organic_Store
{
    partial class AdminRegistation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegistation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadminRegister = new System.Windows.Forms.Button();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.txtadminusername = new System.Windows.Forms.TextBox();
            this.txtadminfullname = new System.Windows.Forms.TextBox();
            this.lbladminPassword = new System.Windows.Forms.Label();
            this.lbladminUsername = new System.Windows.Forms.Label();
            this.lbladminFullName = new System.Windows.Forms.Label();
            this.lblAdminRegistration = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnadminRegister);
            this.panel1.Controls.Add(this.txtadminpassword);
            this.panel1.Controls.Add(this.txtadminusername);
            this.panel1.Controls.Add(this.txtadminfullname);
            this.panel1.Controls.Add(this.lbladminPassword);
            this.panel1.Controls.Add(this.lbladminUsername);
            this.panel1.Controls.Add(this.lbladminFullName);
            this.panel1.Controls.Add(this.lblAdminRegistration);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 624);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnadminRegister
            // 
            this.btnadminRegister.BackColor = System.Drawing.Color.OliveDrab;
            this.btnadminRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadminRegister.Location = new System.Drawing.Point(292, 426);
            this.btnadminRegister.Name = "btnadminRegister";
            this.btnadminRegister.Size = new System.Drawing.Size(159, 49);
            this.btnadminRegister.TabIndex = 7;
            this.btnadminRegister.Text = "Register";
            this.btnadminRegister.UseVisualStyleBackColor = false;
            this.btnadminRegister.Click += new System.EventHandler(this.btnadminRegister_Click);
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Location = new System.Drawing.Point(265, 338);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.Size = new System.Drawing.Size(243, 26);
            this.txtadminpassword.TabIndex = 6;
            this.txtadminpassword.TextChanged += new System.EventHandler(this.txtadminpassword_TextChanged);
            // 
            // txtadminusername
            // 
            this.txtadminusername.Location = new System.Drawing.Point(265, 277);
            this.txtadminusername.Name = "txtadminusername";
            this.txtadminusername.Size = new System.Drawing.Size(243, 26);
            this.txtadminusername.TabIndex = 5;
            this.txtadminusername.TextChanged += new System.EventHandler(this.txtadminusername_TextChanged);
            // 
            // txtadminfullname
            // 
            this.txtadminfullname.Location = new System.Drawing.Point(265, 205);
            this.txtadminfullname.Name = "txtadminfullname";
            this.txtadminfullname.Size = new System.Drawing.Size(243, 26);
            this.txtadminfullname.TabIndex = 4;
            // 
            // lbladminPassword
            // 
            this.lbladminPassword.AutoSize = true;
            this.lbladminPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbladminPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbladminPassword.Location = new System.Drawing.Point(82, 339);
            this.lbladminPassword.Name = "lbladminPassword";
            this.lbladminPassword.Size = new System.Drawing.Size(110, 26);
            this.lbladminPassword.TabIndex = 3;
            this.lbladminPassword.Text = "Password";
            // 
            // lbladminUsername
            // 
            this.lbladminUsername.AutoSize = true;
            this.lbladminUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbladminUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbladminUsername.Location = new System.Drawing.Point(82, 277);
            this.lbladminUsername.Name = "lbladminUsername";
            this.lbladminUsername.Size = new System.Drawing.Size(115, 26);
            this.lbladminUsername.TabIndex = 2;
            this.lbladminUsername.Text = "Username";
            // 
            // lbladminFullName
            // 
            this.lbladminFullName.AutoSize = true;
            this.lbladminFullName.BackColor = System.Drawing.Color.Transparent;
            this.lbladminFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminFullName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbladminFullName.Location = new System.Drawing.Point(82, 206);
            this.lbladminFullName.Name = "lbladminFullName";
            this.lbladminFullName.Size = new System.Drawing.Size(119, 26);
            this.lbladminFullName.TabIndex = 1;
            this.lbladminFullName.Text = "Full Name";
            // 
            // lblAdminRegistration
            // 
            this.lblAdminRegistration.AutoSize = true;
            this.lblAdminRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminRegistration.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdminRegistration.Location = new System.Drawing.Point(143, 74);
            this.lblAdminRegistration.Name = "lblAdminRegistration";
            this.lblAdminRegistration.Size = new System.Drawing.Size(438, 39);
            this.lblAdminRegistration.TabIndex = 0;
            this.lblAdminRegistration.Text = "Admin Registration";
            this.lblAdminRegistration.Click += new System.EventHandler(this.lblAdminRegistration_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.OliveDrab;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(538, 563);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 49);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminRegistation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 624);
            this.Controls.Add(this.panel1);
            this.Name = "AdminRegistation";
            this.Text = "AdminRegistation";
            this.Load += new System.EventHandler(this.AdminRegistation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdminRegistration;
        private System.Windows.Forms.Label lbladminFullName;
        private System.Windows.Forms.Button btnadminRegister;
        private System.Windows.Forms.TextBox txtadminpassword;
        private System.Windows.Forms.TextBox txtadminusername;
        private System.Windows.Forms.TextBox txtadminfullname;
        private System.Windows.Forms.Label lbladminPassword;
        private System.Windows.Forms.Label lbladminUsername;
        private System.Windows.Forms.Button btnBack;
    }
}