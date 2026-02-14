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
using static GreenLife_Organic_Store.LOGIN;

namespace GreenLife_Organic_Store
{
    public partial class cart : Form
    {
        readonly string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        readonly int customerID;
        int cartID = 0;

        public cart(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            LoadCart();
        }
        private void LoadCart()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

              
                SqlCommand getCart = new SqlCommand(
                    "SELECT TOP 1 CartID FROM Cart WHERE CustomerID=@CustomerID ORDER BY CreatedDate DESC",
                    con);
                getCart.Parameters.AddWithValue("@CustomerID", customerID);

                object result = getCart.ExecuteScalar();

                if (result == null)
                {
                    dgvCart.DataSource = null;
                    return;
                }

                cartID = Convert.ToInt32(result);

                
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        ci.CartItemID,
                        p.ProductName,
                        p.Price,
                        p.DiscountPercent,
                        ci.Quantity,
                        (p.Price * ci.Quantity) AS SubTotal,
                        ((p.Price * ci.Quantity) * p.DiscountPercent / 100) AS DiscountAmount,
                        ((p.Price * ci.Quantity) -
                        ((p.Price * ci.Quantity) * p.DiscountPercent / 100)) AS Total
                    FROM CartItems ci
                    INNER JOIN Products p ON ci.ProductID = p.ProductID
                    WHERE ci.CartID=@CartID", con);

                da.SelectCommand.Parameters.AddWithValue("@CartID", cartID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCart.DataSource = dt;

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

            lblsubtotal.Text = subtotal.ToString("0.00");
            lblDiscount.Text = discount.ToString("0.00");
            lblGrandTotal.Text = grandTotal.ToString("0.00");
        }

        private void BtnHome3_Click(object sender, EventArgs e)
        {
            CustomerDashbord customerDashbord = new CustomerDashbord(this.customerID);
            this.Hide();
            customerDashbord.ShowDialog();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select item first.");
                return;
            }

            int cartItemID = Convert.ToInt32(
                dgvCart.SelectedRows[0].Cells["CartItemID"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM CartItems WHERE CartItemID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", cartItemID);
                cmd.ExecuteNonQuery();
            }

            LoadCart();
        }

        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            if (cartID == 0)
                return;

            if (MessageBox.Show("Clear full cart?",
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM CartItems WHERE CartID=@CartID", con);
                    cmd.Parameters.AddWithValue("@CartID", cartID);
                    cmd.ExecuteNonQuery();
                }

                LoadCart();
            }
        }

        private void BtnCountine_Click(object sender, EventArgs e)
        {
            Makeuorder makeuorder = new Makeuorder(this.customerID);
            this.Hide();
            makeuorder.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Show();
            Finalcheckout finalcheckout = new Finalcheckout(this.customerID); 
            this.Hide();
            finalcheckout.ShowDialog();
        }
    }
}
