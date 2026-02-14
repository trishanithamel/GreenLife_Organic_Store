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
    public partial class AdminManegeorder : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public AdminManegeorder()
        {
            InitializeComponent();
        }

        private void AdminManegeorder_Load(object sender, EventArgs e)
        {
            LoadStatus();
            LoadOrders();
        }
        private void LoadStatus()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT StatusID, StatusName FROM OrderStatus";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbStatus.DataSource = dt;
                cmbStatus.DisplayMember = "StatusName";
                cmbStatus.ValueMember = "StatusID";
                cmbStatus.SelectedIndex = -1;
            }
        }

        
        private void LoadOrders()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                                SELECT 
                                o.OrderID,
                                c.fullname AS Customer,
                                o.OrderDate,
                                o.SubTotal,
                                o.Discount,
                                o.GrandTotal,
                                s.StatusName
                                FROM Orders o
                    JOIN Customers c ON o.CustomerID = c.customerID
                    JOIN OrderStatus s ON o.StatusID = s.StatusID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrders.DataSource = dt;
            }
        }

        
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtorderid1.Text = dgvOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                cmbStatus.Text = dgvOrders.Rows[e.RowIndex].Cells["StatusName"].Value.ToString();
            }
        }

        private void btnupdate4_Click(object sender, EventArgs e)
        {
            if (txtorderid1.Text == "" || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an order and status.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Orders SET StatusID = @StatusID WHERE OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@OrderID", txtorderid1.Text);
                cmd.Parameters.AddWithValue("@StatusID", cmbStatus.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Order status updated successfully!");
                LoadOrders();
            }
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnhome23_Click(object sender, EventArgs e)
        {
            AdminDashbord adminDashbord = new AdminDashbord();
            this.Hide();
            adminDashbord.ShowDialog();
        }
    }
}
