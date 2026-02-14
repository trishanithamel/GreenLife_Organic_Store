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
    public partial class OrderDetailsForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        private int orderId;
        private int customerID;
        private bool isAdmin;

        public OrderDetailsForm(int orderId, int customerID, bool isAdmin)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.customerID = customerID;
            this.isAdmin = isAdmin;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            lblOrderID.Text = "Order ID: " + orderId;
            LoadOrderItems();
        }
        private void LoadOrderItems()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.ProductName,
                            oi.Quantity,
                            oi.Price,
                            oi.DiscountPercent,
                            oi.Total
                        FROM OrderItems oi
                        INNER JOIN Products p ON oi.ProductID = p.ProductID
                        WHERE oi.OrderID = @OrderID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvOrderItems.DataSource = dt;
                    dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOrderItems.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order items: " + ex.Message);
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "OrderHistory.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                    {
                        
                        for (int i = 0; i < dgvOrderItems.Columns.Count; i++)
                        {
                            sw.Write(dgvOrderItems.Columns[i].HeaderText);
                            if (i < dgvOrderItems.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                      
                        foreach (DataGridViewRow row in dgvOrderItems.Rows)
                        {
                            for (int i = 0; i < dgvOrderItems.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < dgvOrderItems.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Order history exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting data: " + ex.Message);
                }
            }
        }

        private void btnhome38_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnClose1_Click(object sender, EventArgs e)
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
