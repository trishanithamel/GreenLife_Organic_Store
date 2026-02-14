namespace GreenLife_Organic_Store
{
    partial class Finalcheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finalcheckout));
            this.lblCheckout1 = new System.Windows.Forms.Label();
            this.btnback2 = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.panelcustomer = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblContactText = new System.Windows.Forms.Label();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.lblFullNameText = new System.Windows.Forms.Label();
            this.dgvcustomerdetails = new System.Windows.Forms.DataGridView();
            this.panelOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblDiscountText = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.dgvOrderSummary = new System.Windows.Forms.DataGridView();
            this.panelcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerdetails)).BeginInit();
            this.panelOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCheckout1
            // 
            this.lblCheckout1.AutoSize = true;
            this.lblCheckout1.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckout1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCheckout1.Location = new System.Drawing.Point(-149, -94);
            this.lblCheckout1.Name = "lblCheckout1";
            this.lblCheckout1.Size = new System.Drawing.Size(222, 26);
            this.lblCheckout1.TabIndex = 6;
            this.lblCheckout1.Text = "Customer_Checkout";
            // 
            // btnback2
            // 
            this.btnback2.BackColor = System.Drawing.Color.OliveDrab;
            this.btnback2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback2.Location = new System.Drawing.Point(31, 569);
            this.btnback2.Name = "btnback2";
            this.btnback2.Size = new System.Drawing.Size(83, 52);
            this.btnback2.TabIndex = 12;
            this.btnback2.Text = "Back";
            this.btnback2.UseVisualStyleBackColor = false;
            this.btnback2.Click += new System.EventHandler(this.btnback2_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.OliveDrab;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(793, 561);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(179, 60);
            this.btnConfirmOrder.TabIndex = 11;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // panelcustomer
            // 
            this.panelcustomer.BackColor = System.Drawing.Color.Transparent;
            this.panelcustomer.Controls.Add(this.txtAddress);
            this.panelcustomer.Controls.Add(this.txtContact);
            this.panelcustomer.Controls.Add(this.txtEmail);
            this.panelcustomer.Controls.Add(this.txtFullName);
            this.panelcustomer.Controls.Add(this.lblAddressText);
            this.panelcustomer.Controls.Add(this.lblContactText);
            this.panelcustomer.Controls.Add(this.lblEmailText);
            this.panelcustomer.Controls.Add(this.lblFullNameText);
            this.panelcustomer.Controls.Add(this.dgvcustomerdetails);
            this.panelcustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelcustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelcustomer.Location = new System.Drawing.Point(129, 303);
            this.panelcustomer.Name = "panelcustomer";
            this.panelcustomer.Size = new System.Drawing.Size(697, 239);
            this.panelcustomer.TabIndex = 10;
            this.panelcustomer.TabStop = false;
            this.panelcustomer.Text = "Customer Details";
            this.panelcustomer.Enter += new System.EventHandler(this.panelcustomer_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtAddress.Location = new System.Drawing.Point(268, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(328, 35);
            this.txtAddress.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Info;
            this.txtContact.Location = new System.Drawing.Point(268, 145);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(328, 35);
            this.txtContact.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(268, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 35);
            this.txtEmail.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFullName.Location = new System.Drawing.Point(268, 53);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(328, 35);
            this.txtFullName.TabIndex = 5;
            // 
            // lblAddressText
            // 
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Location = new System.Drawing.Point(72, 198);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(103, 26);
            this.lblAddressText.TabIndex = 4;
            this.lblAddressText.Text = "Address:";
            // 
            // lblContactText
            // 
            this.lblContactText.AutoSize = true;
            this.lblContactText.Location = new System.Drawing.Point(72, 154);
            this.lblContactText.Name = "lblContactText";
            this.lblContactText.Size = new System.Drawing.Size(101, 26);
            this.lblContactText.TabIndex = 3;
            this.lblContactText.Text = "Contact:";
            // 
            // lblEmailText
            // 
            this.lblEmailText.AutoSize = true;
            this.lblEmailText.Location = new System.Drawing.Point(72, 102);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(81, 26);
            this.lblEmailText.TabIndex = 2;
            this.lblEmailText.Text = "Email:";
            // 
            // lblFullNameText
            // 
            this.lblFullNameText.AutoSize = true;
            this.lblFullNameText.ForeColor = System.Drawing.Color.Transparent;
            this.lblFullNameText.Location = new System.Drawing.Point(72, 54);
            this.lblFullNameText.Name = "lblFullNameText";
            this.lblFullNameText.Size = new System.Drawing.Size(127, 26);
            this.lblFullNameText.TabIndex = 1;
            this.lblFullNameText.Text = "Full Name:";
            // 
            // dgvcustomerdetails
            // 
            this.dgvcustomerdetails.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvcustomerdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomerdetails.Location = new System.Drawing.Point(0, 34);
            this.dgvcustomerdetails.Name = "dgvcustomerdetails";
            this.dgvcustomerdetails.RowHeadersWidth = 62;
            this.dgvcustomerdetails.RowTemplate.Height = 28;
            this.dgvcustomerdetails.Size = new System.Drawing.Size(694, 199);
            this.dgvcustomerdetails.TabIndex = 0;
            // 
            // panelOrderSummary
            // 
            this.panelOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.panelOrderSummary.Controls.Add(this.lblGrandTotal);
            this.panelOrderSummary.Controls.Add(this.lblDiscount);
            this.panelOrderSummary.Controls.Add(this.lblTotalText);
            this.panelOrderSummary.Controls.Add(this.lblDiscountText);
            this.panelOrderSummary.Controls.Add(this.lblSubtotal);
            this.panelOrderSummary.Controls.Add(this.lblsub);
            this.panelOrderSummary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOrderSummary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelOrderSummary.Location = new System.Drawing.Point(46, 44);
            this.panelOrderSummary.Name = "panelOrderSummary";
            this.panelOrderSummary.Size = new System.Drawing.Size(445, 185);
            this.panelOrderSummary.TabIndex = 9;
            this.panelOrderSummary.TabStop = false;
            this.panelOrderSummary.Text = "📦 Order Summary";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(301, 146);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(54, 26);
            this.lblGrandTotal.TabIndex = 6;
            this.lblGrandTotal.Text = "0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(301, 101);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(54, 26);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = "0.00";
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(48, 146);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(140, 26);
            this.lblTotalText.TabIndex = 4;
            this.lblTotalText.Text = "Grand total:";
            // 
            // lblDiscountText
            // 
            this.lblDiscountText.AutoSize = true;
            this.lblDiscountText.Location = new System.Drawing.Point(48, 101);
            this.lblDiscountText.Name = "lblDiscountText";
            this.lblDiscountText.Size = new System.Drawing.Size(110, 26);
            this.lblDiscountText.TabIndex = 3;
            this.lblDiscountText.Text = "Discount:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(301, 60);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 26);
            this.lblSubtotal.TabIndex = 2;
            this.lblSubtotal.Text = "0.00";
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.Location = new System.Drawing.Point(48, 60);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(106, 26);
            this.lblsub.TabIndex = 1;
            this.lblsub.Text = "Subtotal:";
            // 
            // dgvOrderSummary
            // 
            this.dgvOrderSummary.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderSummary.Location = new System.Drawing.Point(532, 54);
            this.dgvOrderSummary.Name = "dgvOrderSummary";
            this.dgvOrderSummary.RowHeadersWidth = 62;
            this.dgvOrderSummary.RowTemplate.Height = 28;
            this.dgvOrderSummary.Size = new System.Drawing.Size(481, 226);
            this.dgvOrderSummary.TabIndex = 0;
            // 
            // Finalcheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 647);
            this.Controls.Add(this.btnback2);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.panelcustomer);
            this.Controls.Add(this.panelOrderSummary);
            this.Controls.Add(this.lblCheckout1);
            this.Controls.Add(this.dgvOrderSummary);
            this.Name = "Finalcheckout";
            this.Text = "Finalcheckout";
            this.Load += new System.EventHandler(this.Finalcheckout_Load);
            this.panelcustomer.ResumeLayout(false);
            this.panelcustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerdetails)).EndInit();
            this.panelOrderSummary.ResumeLayout(false);
            this.panelOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCheckout1;
        private System.Windows.Forms.Button btnback2;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.GroupBox panelcustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblContactText;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label lblFullNameText;
        private System.Windows.Forms.DataGridView dgvcustomerdetails;
        private System.Windows.Forms.GroupBox panelOrderSummary;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblDiscountText;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.DataGridView dgvOrderSummary;
    }
}