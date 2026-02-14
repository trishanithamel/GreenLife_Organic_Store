namespace GreenLife_Organic_Store
{
    partial class Product_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Management));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntaddpic = new System.Windows.Forms.Button();
            this.pictureBoxaddproduct = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtpemail = new System.Windows.Forms.TextBox();
            this.txtstockqty = new System.Windows.Forms.TextBox();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.lblpemail = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductManagement = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxaddproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bntaddpic);
            this.panel1.Controls.Add(this.pictureBoxaddproduct);
            this.panel1.Controls.Add(this.lblImage);
            this.panel1.Controls.Add(this.dgvProductList);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmbstatus);
            this.panel1.Controls.Add(this.cmbcategory);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.txtpemail);
            this.panel1.Controls.Add(this.txtstockqty);
            this.panel1.Controls.Add(this.txtsupplier);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.txtproductname);
            this.panel1.Controls.Add(this.lblpemail);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblSupplier);
            this.panel1.Controls.Add(this.lblStockQty);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.lblProductManagement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 669);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bntaddpic
            // 
            this.bntaddpic.BackColor = System.Drawing.SystemColors.Info;
            this.bntaddpic.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntaddpic.Location = new System.Drawing.Point(910, 552);
            this.bntaddpic.Name = "bntaddpic";
            this.bntaddpic.Size = new System.Drawing.Size(56, 34);
            this.bntaddpic.TabIndex = 24;
            this.bntaddpic.Text = "add";
            this.bntaddpic.UseVisualStyleBackColor = false;
            this.bntaddpic.Click += new System.EventHandler(this.bntaddpic_Click);
            // 
            // pictureBoxaddproduct
            // 
            this.pictureBoxaddproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxaddproduct.Location = new System.Drawing.Point(728, 241);
            this.pictureBoxaddproduct.Name = "pictureBoxaddproduct";
            this.pictureBoxaddproduct.Size = new System.Drawing.Size(338, 293);
            this.pictureBoxaddproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxaddproduct.TabIndex = 23;
            this.pictureBoxaddproduct.TabStop = false;
            this.pictureBoxaddproduct.Click += new System.EventHandler(this.pictureBoxaddproduct_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.BackColor = System.Drawing.Color.Transparent;
            this.lblImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImage.Location = new System.Drawing.Point(829, 554);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(75, 26);
            this.lblImage.TabIndex = 22;
            this.lblImage.Text = "Image";
            // 
            // dgvProductList
            // 
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(48, 329);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 62;
            this.dgvProductList.RowTemplate.Height = 28;
            this.dgvProductList.Size = new System.Drawing.Size(657, 316);
            this.dgvProductList.TabIndex = 21;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Cornsilk;
            this.btnhome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnhome.Location = new System.Drawing.Point(955, 604);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(99, 53);
            this.btnhome.TabIndex = 20;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(499, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 51);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(280, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 51);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(56, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 51);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Location = new System.Drawing.Point(218, 196);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(224, 28);
            this.cmbstatus.TabIndex = 16;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(218, 137);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(224, 28);
            this.cmbcategory.TabIndex = 15;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(910, 139);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(156, 26);
            this.txtdiscount.TabIndex = 14;
            // 
            // txtpemail
            // 
            this.txtpemail.Location = new System.Drawing.Point(559, 196);
            this.txtpemail.Name = "txtpemail";
            this.txtpemail.Size = new System.Drawing.Size(209, 26);
            this.txtpemail.TabIndex = 13;
            // 
            // txtstockqty
            // 
            this.txtstockqty.Location = new System.Drawing.Point(559, 140);
            this.txtstockqty.Name = "txtstockqty";
            this.txtstockqty.Size = new System.Drawing.Size(209, 26);
            this.txtstockqty.TabIndex = 12;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Location = new System.Drawing.Point(910, 91);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(156, 26);
            this.txtsupplier.TabIndex = 11;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(559, 91);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(209, 26);
            this.txtprice.TabIndex = 10;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(218, 91);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(224, 26);
            this.txtproductname.TabIndex = 9;
            // 
            // lblpemail
            // 
            this.lblpemail.AutoSize = true;
            this.lblpemail.BackColor = System.Drawing.Color.Transparent;
            this.lblpemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpemail.Location = new System.Drawing.Point(448, 196);
            this.lblpemail.Name = "lblpemail";
            this.lblpemail.Size = new System.Drawing.Size(73, 26);
            this.lblpemail.TabIndex = 8;
            this.lblpemail.Text = "Email";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(56, 196);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 26);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiscount.Location = new System.Drawing.Point(774, 140);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(133, 26);
            this.lblDiscount.TabIndex = 6;
            this.lblDiscount.Text = "Discount %";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSupplier.Location = new System.Drawing.Point(774, 92);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(100, 26);
            this.lblSupplier.TabIndex = 5;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.BackColor = System.Drawing.Color.Transparent;
            this.lblStockQty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStockQty.Location = new System.Drawing.Point(448, 140);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(114, 26);
            this.lblStockQty.TabIndex = 4;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(448, 92);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 26);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategory.Location = new System.Drawing.Point(51, 140);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 26);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductName.Location = new System.Drawing.Point(51, 92);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(160, 26);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductManagement
            // 
            this.lblProductManagement.AutoSize = true;
            this.lblProductManagement.BackColor = System.Drawing.Color.Transparent;
            this.lblProductManagement.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProductManagement.Location = new System.Drawing.Point(391, 20);
            this.lblProductManagement.Name = "lblProductManagement";
            this.lblProductManagement.Size = new System.Drawing.Size(314, 36);
            this.lblProductManagement.TabIndex = 0;
            this.lblProductManagement.Text = "Product Management";
            // 
            // Product_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 669);
            this.Controls.Add(this.panel1);
            this.Name = "Product_Management";
            this.Text = "Product_Management";
            this.Load += new System.EventHandler(this.Product_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxaddproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductManagement;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtpemail;
        private System.Windows.Forms.TextBox txtstockqty;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label lblpemail;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pictureBoxaddproduct;
        private System.Windows.Forms.Button bntaddpic;
    }
}