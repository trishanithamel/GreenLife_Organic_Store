namespace GreenLife_Organic_Store
{
    partial class cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cart));
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountText = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalText = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnhome3 = new System.Windows.Forms.Button();
            this.btncountine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.BackColor = System.Drawing.Color.Transparent;
            this.lblShoppingCart.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShoppingCart.Location = new System.Drawing.Point(24, 25);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(218, 36);
            this.lblShoppingCart.TabIndex = 0;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(66, 81);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.Size = new System.Drawing.Size(395, 317);
            this.dgvCart.TabIndex = 1;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.lblGrandTotal);
            this.panel19.Controls.Add(this.lblTotalText);
            this.panel19.Controls.Add(this.lblDiscount);
            this.panel19.Controls.Add(this.lblDiscountText);
            this.panel19.Controls.Add(this.lblsubtotal);
            this.panel19.Controls.Add(this.lblSubtotalText);
            this.panel19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel19.Location = new System.Drawing.Point(559, 81);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(340, 317);
            this.panel19.TabIndex = 2;
            this.panel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(245, 210);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(54, 26);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "0.00";
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(14, 210);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(145, 26);
            this.lblTotalText.TabIndex = 4;
            this.lblTotalText.Text = "Grand Total:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(245, 146);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(54, 26);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "0.00";
            // 
            // lblDiscountText
            // 
            this.lblDiscountText.AutoSize = true;
            this.lblDiscountText.Location = new System.Drawing.Point(14, 146);
            this.lblDiscountText.Name = "lblDiscountText";
            this.lblDiscountText.Size = new System.Drawing.Size(110, 26);
            this.lblDiscountText.TabIndex = 2;
            this.lblDiscountText.Text = "Discount:";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Location = new System.Drawing.Point(245, 88);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(54, 26);
            this.lblsubtotal.TabIndex = 1;
            this.lblsubtotal.Text = "0.00";
            // 
            // lblSubtotalText
            // 
            this.lblSubtotalText.AutoSize = true;
            this.lblSubtotalText.Location = new System.Drawing.Point(14, 88);
            this.lblSubtotalText.Name = "lblSubtotalText";
            this.lblSubtotalText.Size = new System.Drawing.Size(106, 26);
            this.lblSubtotalText.TabIndex = 0;
            this.lblSubtotalText.Text = "Subtotal:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(66, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 46);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.OliveDrab;
            this.btnClearCart.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearCart.Location = new System.Drawing.Point(303, 413);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(158, 46);
            this.btnClearCart.TabIndex = 4;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.BtnClearCart_Click);
            this.btnClearCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // btnhome3
            // 
            this.btnhome3.BackColor = System.Drawing.Color.OliveDrab;
            this.btnhome3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhome3.Location = new System.Drawing.Point(825, 19);
            this.btnhome3.Name = "btnhome3";
            this.btnhome3.Size = new System.Drawing.Size(98, 42);
            this.btnhome3.TabIndex = 5;
            this.btnhome3.Text = "Home ";
            this.btnhome3.UseVisualStyleBackColor = false;
            this.btnhome3.Click += new System.EventHandler(this.BtnHome3_Click);
            this.btnhome3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // btncountine
            // 
            this.btncountine.BackColor = System.Drawing.SystemColors.Info;
            this.btncountine.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncountine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncountine.Location = new System.Drawing.Point(30, 519);
            this.btncountine.Name = "btncountine";
            this.btncountine.Size = new System.Drawing.Size(224, 57);
            this.btncountine.TabIndex = 6;
            this.btncountine.Text = "Continue Shopping ";
            this.btncountine.UseVisualStyleBackColor = false;
            this.btncountine.Click += new System.EventHandler(this.BtnCountine_Click);
            this.btncountine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(699, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncountine);
            this.Controls.Add(this.btnhome3);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblShoppingCart);
            this.Name = "cart";
            this.Text = "cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountText;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label lblSubtotalText;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnhome3;
        private System.Windows.Forms.Button btncountine;
        private System.Windows.Forms.Button button1;
    }
}