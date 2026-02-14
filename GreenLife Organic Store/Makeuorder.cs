using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLife_Organic_Store
{
    public partial class Makeuorder : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        private readonly int customerID;
        private int currentPage = 0;
        private const int pageSize = 3;
        private List<DataRow> allProducts = new List<DataRow>();
        public Makeuorder(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
            LoadProducts();
            LoadCategories();

            
            btnaddtocart1.Click += BtnAddToCart_Click;
            btnaddtocart2.Click += BtnAddToCart_Click;
            btnaddtocart3.Click += BtnAddToCart_Click;

            
            this.Activated += Makeuorder_Activated;
            
            
            cmbsearch.SelectedIndexChanged += cmbsearch_SelectedIndexChanged;
        }

        private void Makeuorder_Activated(object sender, EventArgs e)
        {
            
            string name = txtsearch.Text.Trim();
            int? categoryId = null;
            if (cmbsearch.SelectedIndex != -1)
                categoryId = Convert.ToInt32(cmbsearch.SelectedValue);

            LoadProducts(name, categoryId);
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName FROM Categories";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbsearch.DataSource = dt;
                cmbsearch.DisplayMember = "CategoryName";
                cmbsearch.ValueMember = "CategoryID";
                cmbsearch.SelectedIndex = -1;
            }
        }
        private void LoadProducts(string searchName = "", int? categoryId = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                   
                    string query = "SELECT ProductID, ProductName, Price, DiscountPercent, StockQuantity, ProductImage FROM Products WHERE 1=1";
                    
                    if (categoryId.HasValue)
                        query += " AND CategoryID = @CategoryID";

                    if (!string.IsNullOrWhiteSpace(searchName))
                        query += " AND ProductName LIKE @ProductName";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    if (categoryId.HasValue)
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId.Value);

                    if (!string.IsNullOrWhiteSpace(searchName))
                        cmd.Parameters.AddWithValue("@ProductName", "%" + searchName + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    allProducts.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        allProducts.Add(row);
                    }

                    currentPage = 0; 
                    UpdateProductDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void UpdateProductDisplay()
        {
            int startIndex = currentPage * pageSize;
            int endIndex = Math.Min(startIndex + pageSize, allProducts.Count);

            for (int i = 0; i < pageSize; i++)
            {
                int productIndex = startIndex + i;

                PictureBox picBox = this.Controls.Find("pictureBox" + (i + 1), true)[0] as PictureBox;
                Label lblName = this.Controls.Find("lblname" + (i + 1), true)[0] as Label;
                Label lblPrice = this.Controls.Find("lblprice" + (i + 1), true)[0] as Label;
                Label lblDiscount = this.Controls.Find("lblDiscount" + (i + 1), true)[0] as Label;
                NumericUpDown nudQuantity = this.Controls.Find("nudQuantity" + (i + 1), true)[0] as NumericUpDown;
                Button btnAdd = this.Controls.Find("btnaddtocart" + (i + 1), true)[0] as Button;

                if (productIndex < allProducts.Count)
                {
                    DataRow row = allProducts[productIndex];
                    int productId = Convert.ToInt32(row["ProductID"]);
                    string name = row["ProductName"].ToString();
                    decimal price = Convert.ToDecimal(row["Price"]);
                    decimal discount = Convert.ToDecimal(row["DiscountPercent"]);
                    int stock = Convert.ToInt32(row["StockQuantity"]);
                    string imagePath = row["ProductImage"].ToString();

                    lblName.Text = name;
                    lblPrice.Text = "Rs. " + price.ToString("N2");
                    lblDiscount.Text = discount.ToString("0") + "%";
                    nudQuantity.Value = 1;

                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                        picBox.Image = Image.FromFile(imagePath);
                    else
                        picBox.Image = Image.FromFile(@"C:\Users\User\Downloads\WhatsApp Image 2026-02-10 at 22.02.55 (1).jpeg");

                    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox.Tag = productId;
                    btnAdd.Enabled = stock > 0;
                    btnAdd.Visible = true;
                    nudQuantity.Visible = true;
                }
                else
                {
                   
                    lblName.Text = "";
                    lblPrice.Text = "";
                    lblDiscount.Text = "";
                    nudQuantity.Value = 1;
                    picBox.Image = Image.FromFile(@"C:\Users\User\Downloads\WhatsApp Image 2026-02-10 at 22.02.55 (1).jpeg");
                    picBox.Tag = null;
                    btnAdd.Enabled = false;
                    btnAdd.Visible = false;
                    nudQuantity.Visible = false;
                }
            }

           
            btnPrevious.Enabled = currentPage > 0;
            btnNext.Enabled = (currentPage + 1) * pageSize < allProducts.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((currentPage + 1) * pageSize < allProducts.Count)
            {
                currentPage++;
                UpdateProductDisplay();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                UpdateProductDisplay();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text.Trim();
            int? categoryId = null;
            if (cmbsearch.SelectedIndex != -1)
                categoryId = Convert.ToInt32(cmbsearch.SelectedValue);

            LoadProducts(name, categoryId);
        }

        private void btnaddtocart2_Click(object sender, EventArgs e)
        {

        }
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            int index = 0;

            if (btn.Name == "btnaddtocart1") index = 1;
            else if (btn.Name == "btnaddtocart2") index = 2;
            else if (btn.Name == "btnaddtocart3") index = 3;

            PictureBox picBox = this.Controls.Find("pictureBox" + index, true)[0] as PictureBox;
            NumericUpDown nudQuantity = this.Controls.Find("nudQuantity" + index, true)[0] as NumericUpDown;

            if (picBox.Tag != null)
            {
                int productId = Convert.ToInt32(picBox.Tag);
                int quantity = (int)nudQuantity.Value;

                AddToCart(productId, quantity);
            }
        }

        private void AddToCart(int productId, int quantity)
        {
            if (quantity <= 0)
            {
                MessageBox.Show("Please select a valid quantity.");
                return;
            }

            
            if (customerID <= 0)
            {
                MessageBox.Show("Invalid Customer ID. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                   
                    string stockQuery = "SELECT StockQuantity FROM Products WHERE ProductID = @ProductID";
                    SqlCommand stockCmd = new SqlCommand(stockQuery, conn);
                    stockCmd.Parameters.AddWithValue("@ProductID", productId);

                    object stockResult = stockCmd.ExecuteScalar();

                    if (stockResult == null)
                    {
                        MessageBox.Show("Product not found!");
                        return;
                    }

                    int availableStock = Convert.ToInt32(stockResult);

                    
                    if (availableStock <= 0)
                    {
                        MessageBox.Show("This product is OUT OF STOCK!");
                        return;
                    }

                   
                    if (quantity > availableStock)
                    {
                        MessageBox.Show("Only " + availableStock + " items available in stock!");
                        return;
                    }

                 
                    int cartId = 0;

                    string getCartQuery = "SELECT TOP 1 CartID FROM Cart WHERE CustomerID = @CustomerID ORDER BY CreatedDate DESC";
                    SqlCommand cmd = new SqlCommand(getCartQuery, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        cartId = Convert.ToInt32(result);
                    }
                    else
                    {
                        string insertCartQuery = "INSERT INTO Cart (CustomerID, CreatedDate) VALUES (@CustomerID, GETDATE()); SELECT SCOPE_IDENTITY();";
                        cmd = new SqlCommand(insertCartQuery, conn);
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cartId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

           
                    string insertItemQuery = @"INSERT INTO CartItems 
                                       (CartID, ProductID, Quantity) 
                                       VALUES (@CartID, @ProductID, @Quantity)";

                    cmd = new SqlCommand(insertItemQuery, conn);
                    cmd.Parameters.AddWithValue("@CartID", cartId);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    cmd.ExecuteNonQuery();

                    string updateStockQuery = @"UPDATE Products 
                                        SET StockQuantity = StockQuantity - @Quantity 
                                        WHERE ProductID = @ProductID";

                    cmd = new SqlCommand(updateStockQuery, conn);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product added to cart successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to cart: " + ex.Message);
            }
        }

        private void btnhome3_Click(object sender, EventArgs e)
        {
        
            CustomerDashbord customerDashbord = new CustomerDashbord(this.customerID);
            this.Hide();
            customerDashbord.ShowDialog();
        }

        private void btncartpage_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT COUNT(*) 
                        FROM CartItems ci 
                        INNER JOIN Cart c ON ci.CartID = c.CartID 
                        WHERE c.CartID = (
                            SELECT TOP 1 CartID 
                            FROM Cart 
                            WHERE CustomerID = @CustomerID 
                            ORDER BY CreatedDate DESC
                        )";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    int itemCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (itemCount > 0)
                    {
                        
                        cart cartForm = new cart(this.customerID);
                        this.Hide();
                        cartForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        
                        MessageBox.Show("You must add at least one product to your cart before viewing it.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking cart: " + ex.Message);
            }
        }

        private void Makeuorder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtsearch.Text = "";
            cmbsearch.SelectedIndex = -1;

            
            LoadProducts();
        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
             
             btnSearch_Click(sender, e);
        }
    }
}
