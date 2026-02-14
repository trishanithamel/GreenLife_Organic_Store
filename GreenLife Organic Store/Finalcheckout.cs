using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GreenLife_Organic_Store
{


    public partial class Finalcheckout : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        int cartID;
        int customerID;


        public Finalcheckout(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }


        private void Finalcheckout_Load(object sender, EventArgs e)
        {
            LoadCustomerDetails();
            LoadOrderSummary();
        }

        private void LoadCustomerDetails()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT FullName, ContactNumber, Address, Email FROM Customers WHERE CustomerID=@CustomerID", con);
                cmd.Parameters.AddWithValue("@CustomerID", this.customerID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString();
                    txtContact.Text = reader["ContactNumber"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                }
                reader.Close();
            }
        }

     
        private void LoadOrderSummary()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                
                SqlCommand getCart = new SqlCommand(
                    "SELECT TOP 1 CartID FROM Cart WHERE CustomerID=@CustomerID ORDER BY CreatedDate DESC", con);
                getCart.Parameters.AddWithValue("@CustomerID", this.customerID);

                object result = getCart.ExecuteScalar();
                if (result == null)
                {
                    dgvOrderSummary.DataSource = null;
                    lblSubtotal.Text = "0.00";
                    lblDiscount.Text = "0.00";
                    lblGrandTotal.Text = "0.00";
                    return;
                }

                cartID = Convert.ToInt32(result);

               
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        ci.CartItemID,
                        p.ProductID,
                        p.ProductName,
                        p.Price,
                        p.DiscountPercent,
                        ci.Quantity,
                        (p.Price * ci.Quantity) AS SubTotal,
                        ((p.Price * ci.Quantity) * p.DiscountPercent / 100) AS DiscountAmount,
                        ((p.Price * ci.Quantity) - ((p.Price * ci.Quantity) * p.DiscountPercent / 100)) AS Total
                    FROM CartItems ci
                    INNER JOIN Products p ON ci.ProductID = p.ProductID
                    WHERE ci.CartID=@CartID", con);

                da.SelectCommand.Parameters.AddWithValue("@CartID", cartID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrderSummary.DataSource = dt;

               
                if (dgvOrderSummary.Columns.Contains("ProductID"))
                    dgvOrderSummary.Columns["ProductID"].Visible = false;

                CalculateTotals(dt);
            }
        }

        private void CalculateTotals(DataTable dt)
        {
            decimal subtotal = 0;
            decimal discount = 0;
            decimal grandTotal = 0;

            foreach (DataRow row in dt.Rows)
            {
                subtotal += Convert.ToDecimal(row["SubTotal"]);
                discount += Convert.ToDecimal(row["DiscountAmount"]);
                grandTotal += Convert.ToDecimal(row["Total"]);
            }

            lblSubtotal.Text = subtotal.ToString("0.00");
            lblDiscount.Text = discount.ToString("0.00");
            lblGrandTotal.Text = grandTotal.ToString("0.00");
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (cartID == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            DialogResult emailChoice = MessageBox.Show(
                "Do you want to send a confirmation email to the customer?",
                "Send Email?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = null;

                try
                {
                    transaction = con.BeginTransaction();

                    
                    string insertOrderQuery = @"
                        INSERT INTO Orders (CartID, CustomerID, SubTotal, Discount, GrandTotal, StatusID, OrderDate)
                        VALUES (@CartID, @CustomerID, @SubTotal, @Discount, @GrandTotal, 1, GETDATE());
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdOrder = new SqlCommand(insertOrderQuery, con, transaction);
                    cmdOrder.Parameters.AddWithValue("@CartID", cartID);
                    cmdOrder.Parameters.AddWithValue("@CustomerID", this.customerID);
                    cmdOrder.Parameters.AddWithValue("@SubTotal", Convert.ToDecimal(lblSubtotal.Text));
                    cmdOrder.Parameters.AddWithValue("@Discount", Convert.ToDecimal(lblDiscount.Text));
                    cmdOrder.Parameters.AddWithValue("@GrandTotal", Convert.ToDecimal(lblGrandTotal.Text));

                    int orderID = Convert.ToInt32(cmdOrder.ExecuteScalar());

                   
                    foreach (DataGridViewRow row in dgvOrderSummary.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string insertItemQuery = @"
                                INSERT INTO OrderItems (OrderID, ProductID, Quantity, Price, DiscountPercent, Total)
                                VALUES (@OrderID, @ProductID, @Quantity, @Price, @DiscountPercent, @Total)";

                            SqlCommand cmdItem = new SqlCommand(insertItemQuery, con, transaction);
                            cmdItem.Parameters.AddWithValue("@OrderID", orderID);
                            cmdItem.Parameters.AddWithValue("@ProductID", Convert.ToInt32(row.Cells["ProductID"].Value));
                            cmdItem.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row.Cells["Quantity"].Value));
                            cmdItem.Parameters.AddWithValue("@Price", Convert.ToDecimal(row.Cells["Price"].Value));
                            cmdItem.Parameters.AddWithValue("@DiscountPercent", Convert.ToDecimal(row.Cells["DiscountPercent"].Value));
                            cmdItem.Parameters.AddWithValue("@Total", Convert.ToDecimal(row.Cells["Total"].Value));

                            cmdItem.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    if (emailChoice == DialogResult.Yes)
                    {
                        MessageBox.Show("Order confirmed! Email feature skipped because no email field is used.", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Order confirmed! Thank you for your purchase.", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearCart();

                    
                    CustomerDashbord dashboard = new CustomerDashbord(this.customerID);
                    this.Hide();
                    dashboard.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    if (transaction != null && transaction.Connection != null)
                        transaction.Rollback();

                    MessageBox.Show("Error saving order: " + ex.Message);
                }
            }
        }

        private void ClearCart()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    DELETE ci
                    FROM CartItems ci
                    INNER JOIN Cart c ON ci.CartID = c.CartID
                    WHERE c.CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", this.customerID);
                con.Open();
                cmd.ExecuteNonQuery();

                dgvOrderSummary.DataSource = null;
                lblSubtotal.Text = "0.00";
                lblDiscount.Text = "0.00";
                lblGrandTotal.Text = "0.00";
            }
        }

        private void btnback2_Click(object sender, EventArgs e)
        {
              cart cart= new cart(this.customerID);
            this.Hide();
            cart.ShowDialog();
        }

        private void panelcustomer_Enter(object sender, EventArgs e)
        {

        }
    }
}
