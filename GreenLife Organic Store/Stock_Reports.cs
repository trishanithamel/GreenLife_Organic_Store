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
    public partial class Stock_Reports : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public Stock_Reports()
        {
            InitializeComponent();
        }

        private void Stock_Reports_Load(object sender, EventArgs e)
        {
            LoadStock();
        }
        private void LoadStock()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            ProductID,
                            ProductName,
                            StockQuantity
                        FROM Products";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStock.DataSource = dt;

                    dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    int lowStockCount = 0;

                    foreach (DataGridViewRow row in dgvStock.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int qty = Convert.ToInt32(row.Cells["StockQuantity"].Value);

                        
                        if (qty <= 5)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            lowStockCount++;
                        }
                    }

                  
                    if (lowStockCount > 0)
                    {
                        MessageBox.Show(
                            "⚠ Warning! " + lowStockCount +
                            " product(s) are low in stock!",
                            "Low Stock Alert",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock: " + ex.Message);
            }
        }

        private void btnhome36_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.ShowDialog();
        }
    }
}
