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
    public partial class AdminDashbord : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public AdminDashbord()
        {
            InitializeComponent();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            AdminManegeorder adminManegeorder = new AdminManegeorder();
            this.Hide();
            adminManegeorder.ShowDialog();
        }

        private void btnregisteradmin_Click(object sender, EventArgs e)
        {
            AdminRegistation adminRegistation= new AdminRegistation();
            this.Hide();
            adminRegistation.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            this.Hide();
            lOGIN.ShowDialog();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            Product_Management product_Management = new Product_Management();
            this.Hide();
            product_Management.ShowDialog();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            Admincustomermanagement admincustomermanagement = new Admincustomermanagement();
            this.Hide();
            admincustomermanagement.ShowDialog();
        }

        private void AdminDashbord_Load(object sender, EventArgs e)
        {
            LoadAdminDashboard();
        }
        private void LoadAdminDashboard()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Metric");
                    dt.Columns.Add("Value");

                    
                    SqlCommand cmdSales = new SqlCommand("SELECT ISNULL(SUM(GrandTotal),0) FROM Orders", conn);
                    object totalSales = cmdSales.ExecuteScalar();
                    dt.Rows.Add("Total Sales (Rs.)", Convert.ToDecimal(totalSales).ToString("N2"));

                   
                    SqlCommand cmdStock = new SqlCommand("SELECT ISNULL(SUM(StockQuantity),0) FROM Products", conn);
                    object totalStock = cmdStock.ExecuteScalar();
                    dt.Rows.Add("Total Products in Stock", totalStock.ToString());

                    
                    SqlCommand cmdActiveOrders = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE StatusID IN (1,2,3)", conn);
                    object activeOrders = cmdActiveOrders.ExecuteScalar();
                    dt.Rows.Add("Active Orders", activeOrders.ToString());

                    
                    dgvadmindashbord.DataSource = dt;
                    dgvadmindashbord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvadmindashbord.ReadOnly = true;
                    dgvadmindashbord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvadmindashbord.AllowUserToAddRows = false;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin dashboard: " + ex.Message);
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.ShowDialog();
        }

    private void btnrefresh3_Click(object sender, EventArgs e)
        {
            LoadAdminDashboard();
        }

        private void btnReview1_Click_1(object sender, EventArgs e)
        {
            AdminCustomerReviews adminCustomerReviews = new AdminCustomerReviews();
            this.Hide();
            adminCustomerReviews.ShowDialog();
        }
    }
}
