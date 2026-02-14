using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLife_Organic_Store
{
    public partial class Product_Management : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        private string selectedImagePath = null;

        public Product_Management()
        {
            InitializeComponent();
            LoadCategories();
            LoadStatuses();
            LoadProducts();
        }
        
        private void LoadCategories()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbcategory.DataSource = dt;
                cmbcategory.DisplayMember = "CategoryName";
                cmbcategory.ValueMember = "CategoryID";
            }
        }

      
        private void LoadStatuses()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT StatusID, StatusName FROM Statuses", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbstatus.DataSource = dt;
                cmbstatus.DisplayMember = "StatusName";
                cmbstatus.ValueMember = "StatusID";
            }
        }

       
        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT P.ProductID, P.ProductName, C.CategoryName, S.StatusName,
                                        P.Price, P.StockQuantity, P.Email, P.Supplier, P.DiscountPercent
                                 FROM Products P
                                 JOIN Categories C ON P.CategoryID = C.CategoryID
                                 JOIN Statuses S ON P.StatusID = S.StatusID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProductList.DataSource = dt;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bntaddpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxaddproduct.Image = Image.FromFile(ofd.FileName);
                selectedImagePath = ofd.FileName; 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Products 
                                     (ProductName, CategoryID, StatusID, Price, StockQuantity, Email, Supplier, DiscountPercent, ProductImage)
                                     VALUES
                                     (@name,@cat,@status,@price,@stock,@email,@supplier,@discount,@img)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtproductname.Text);
                    cmd.Parameters.AddWithValue("@cat", cmbcategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@status", cmbstatus.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtprice.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtstockqty.Text));
                    cmd.Parameters.AddWithValue("@email", txtpemail.Text);
                    cmd.Parameters.AddWithValue("@supplier", txtsupplier.Text);
                    cmd.Parameters.AddWithValue("@discount", decimal.Parse(txtdiscount.Text));
                    cmd.Parameters.AddWithValue("@img", (object)selectedImagePath ?? DBNull.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product Added Successfully!");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProductList.CurrentRow == null) return;

            int productId = Convert.ToInt32(dgvProductList.CurrentRow.Cells["ProductID"].Value);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Products SET 
                                     ProductName=@name, CategoryID=@cat, StatusID=@status,
                                     Price=@price, StockQuantity=@stock, Email=@email,
                                     Supplier=@supplier, DiscountPercent=@discount,
                                     ProductImage=@img
                                     WHERE ProductID=@id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", txtproductname.Text);
                    cmd.Parameters.AddWithValue("@cat", cmbcategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@status", cmbstatus.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtprice.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtstockqty.Text));
                    cmd.Parameters.AddWithValue("@email", txtpemail.Text);
                    cmd.Parameters.AddWithValue("@supplier", txtsupplier.Text);
                    cmd.Parameters.AddWithValue("@discount", decimal.Parse(txtdiscount.Text));
                    cmd.Parameters.AddWithValue("@img", (object)selectedImagePath ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", productId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Product Updated Successfully!");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProductList.CurrentRow == null) return;

            int productId = Convert.ToInt32(dgvProductList.CurrentRow.Cells["ProductID"].Value);

            var confirm = MessageBox.Show("Are you sure to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        
                        SqlCommand deleteOrderItems = new SqlCommand("DELETE FROM OrderItems WHERE ProductID=@id", con, transaction);
                        deleteOrderItems.Parameters.AddWithValue("@id", productId);
                        deleteOrderItems.ExecuteNonQuery();

                       
                        SqlCommand deleteProduct = new SqlCommand("DELETE FROM Products WHERE ProductID=@id", con, transaction);
                        deleteProduct.Parameters.AddWithValue("@id", productId);
                        deleteProduct.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Product Deleted Successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                LoadProducts();
            }
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductList.CurrentRow == null) return;

            txtproductname.Text = dgvProductList.CurrentRow.Cells["ProductName"].Value.ToString();
            cmbcategory.Text = dgvProductList.CurrentRow.Cells["CategoryName"].Value.ToString();
            cmbstatus.Text = dgvProductList.CurrentRow.Cells["StatusName"].Value.ToString();
            txtprice.Text = dgvProductList.CurrentRow.Cells["Price"].Value.ToString();
            txtstockqty.Text = dgvProductList.CurrentRow.Cells["StockQuantity"].Value.ToString();
            txtpemail.Text = dgvProductList.CurrentRow.Cells["Email"].Value.ToString();
            txtsupplier.Text = dgvProductList.CurrentRow.Cells["Supplier"].Value.ToString();
            txtdiscount.Text = dgvProductList.CurrentRow.Cells["DiscountPercent"].Value.ToString();

            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductImage FROM Products WHERE ProductID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", dgvProductList.CurrentRow.Cells["ProductID"].Value);
                con.Open();
                var result = cmd.ExecuteScalar();
                con.Close();

                if (result != DBNull.Value && result != null)
                {
                    string imagePath = result.ToString();
                    if (File.Exists(imagePath))
                        pictureBoxaddproduct.Image = Image.FromFile(imagePath);
                    else
                        pictureBoxaddproduct.Image = null;
                }
                else
                {
                    pictureBoxaddproduct.Image = null;
                }

                
                selectedImagePath = result != DBNull.Value ? result.ToString() : null;
            }
        }

        private void pictureBoxaddproduct_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AdminDashbord adminDashbord= new AdminDashbord();
            this.Hide();
            adminDashbord.ShowDialog();
        }

        private void Product_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
