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
    public partial class ORDER_HISTORY : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        
        private int customerID;
        private bool isAdmin;

        public ORDER_HISTORY(int customerID, bool isAdmin)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.isAdmin = isAdmin;
        }

        private void ORDER_HISTORY_Load(object sender, EventArgs e)
        {
            dtpfrom1.Value = DateTime.Now.AddMonths(-1);
            dtpTo1.Value = DateTime.Now;
            LoadOrderHistory();
        }
        private void LoadOrderHistory(DateTime? fromDate = null, DateTime? toDate = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            o.OrderID,
                            o.OrderDate,
                            o.SubTotal,
                            o.Discount,
                            o.GrandTotal,
                            s.StatusName AS Status
                        FROM Orders o
                        INNER JOIN OrderStatus s ON o.StatusID = s.StatusID";

                   
                    if (!this.isAdmin)
                    {
                         query += " WHERE o.CustomerID = @CustomerID";
                    }
                    else
                    {
                        query += " WHERE 1=1"; 
                    }

                    if (fromDate.HasValue)
                        query += " AND o.OrderDate >= @FromDate";
                    if (toDate.HasValue)
                        query += " AND o.OrderDate <= @ToDate";

                    query += " ORDER BY o.OrderDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    if (!this.isAdmin)
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", this.customerID);
                    }

                    if (fromDate.HasValue)
                        cmd.Parameters.AddWithValue("@FromDate", fromDate.Value.Date);
                    if (toDate.HasValue)
                        cmd.Parameters.AddWithValue("@ToDate", toDate.Value.Date.AddDays(1).AddSeconds(-1));

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOrderHistory.DataSource = dt;
                    dgvOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOrderHistory.ReadOnly = true;
                    dgvOrderHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message);
            }
        }

        private void btnrefresh2_Click(object sender, EventArgs e)
        {
            dtpfrom1.Value = DateTime.Now.AddMonths(-1);
            dtpTo1.Value = DateTime.Now;
            LoadOrderHistory();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            LoadOrderHistory(dtpfrom1.Value, dtpTo1.Value);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvOrderHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to view details.");
                return;
            }

            int orderId = Convert.ToInt32(dgvOrderHistory.SelectedRows[0].Cells["OrderID"].Value);

           
            OrderDetailsForm detailsForm = new OrderDetailsForm(orderId, this.customerID, this.isAdmin); 
            detailsForm.ShowDialog();
        }

        private void btnhome37_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.isAdmin)
            {
                AdminDashbord adminDashbord = new AdminDashbord();
                adminDashbord.ShowDialog();
            }
            else
            {
                CustomerDashbord customerDashbord = new CustomerDashbord(this.customerID);
                customerDashbord.ShowDialog();
            }
        }
    }
}

