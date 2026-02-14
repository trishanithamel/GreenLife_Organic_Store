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
    public partial class AdminCustomerReviews : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public AdminCustomerReviews()
        {
            InitializeComponent();
        }

        private void AdminCustomerReviews_Load(object sender, EventArgs e)
        {
            LoadAllReviews();
        }

        private void LoadAllReviews()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT * FROM CustomerReviews";
                    
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReviews.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashbord adminDashbord = new AdminDashbord();
            this.Hide();
            adminDashbord.ShowDialog();
            this.Close();
        }
    }
}
