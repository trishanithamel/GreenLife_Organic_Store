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
    public partial class SALES_REPORT : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public SALES_REPORT()
        {
            InitializeComponent();
        }

        private void SALES_REPORT_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-1); 
            dtpTo.Value = DateTime.Now;

            LoadSalesReport();
        }

        private void btnbtnGenerate_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }
        private void LoadSalesReport()
        {
            try
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
                            o.GrandTotal
                        FROM Orders o
                        JOIN Customers c ON o.CustomerID = c.customerID
                        WHERE o.OrderDate BETWEEN @FromDate AND @ToDate
                        ORDER BY o.OrderDate DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date.AddDays(1).AddSeconds(-1)); // include entire day

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSales.DataSource = dt;

                   
                    decimal total = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["GrandTotal"] != DBNull.Value)
                        {
                            total += Convert.ToDecimal(row["GrandTotal"]);
                        }
                    }
                    txtTotalSales.Text = total.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales report: " + ex.Message);
            }
        }

        private void btnhome35_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.ShowDialog();
        }
    }
}
