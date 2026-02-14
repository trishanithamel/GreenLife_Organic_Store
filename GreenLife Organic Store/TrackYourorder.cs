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
    public partial class TrackYourorder : Form
    {
        int customerID;

        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";



        public TrackYourorder(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void TrackYourorder_Load(object sender, EventArgs e)
        {
            if (customerID <= 0)
            {
                MessageBox.Show("Invalid Customer ID!");
                return;
            }

            LoadOrders();
        }

        
        private void LoadOrders()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"
                        SELECT o.OrderID, 
                               o.OrderDate, 
                               os.StatusName, 
                               o.GrandTotal
                        FROM Orders o
                        INNER JOIN OrderStatus os ON o.StatusID = os.StatusID
                        WHERE o.CustomerID = @CustomerID
                        ORDER BY o.OrderID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@CustomerID", customerID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOrders.DataSource = dt;
                    dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvOrders.MultiSelect = false;
                    dgvOrders.RowHeadersVisible = false;

                    if (dt.Rows.Count > 0)
                    {
                       
                        dgvOrders.ClearSelection();
                        dgvOrders.Rows[0].Selected = true;
                        ShowOrderDetailsFromRow(dgvOrders.Rows[0]);
                    }
                    else
                    {
                        ClearLabels();
                        MessageBox.Show("No orders found for this customer.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }

       
        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            ShowOrderDetailsFromRow(dgvOrders.Rows[e.RowIndex]);
        }

       
        private void ShowOrderDetailsFromRow(DataGridViewRow row)
        {
            lblSelectedOrderID.Text = row.Cells["OrderID"].Value.ToString();
            lblSelectedOrderDate.Text = Convert.ToDateTime(row.Cells["OrderDate"].Value).ToString("yyyy-MM-dd HH:mm");
            lblSelectedOrderStatus.Text = row.Cells["StatusName"].Value.ToString();
            lblSelectedOrderTotal.Text = Convert.ToDecimal(row.Cells["GrandTotal"].Value).ToString("0.00");
        }

        
        private void ClearLabels()
        {
            lblSelectedOrderID.Text = "";
            lblSelectedOrderDate.Text = "";
            lblSelectedOrderStatus.Text = "";
            lblSelectedOrderTotal.Text = "";
        }

        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnhome4_Click(object sender, EventArgs e)
        {
            CustomerDashbord customerDashbord = new CustomerDashbord(this.customerID);
            this.Hide();
            customerDashbord.ShowDialog();
        }
    }
}
