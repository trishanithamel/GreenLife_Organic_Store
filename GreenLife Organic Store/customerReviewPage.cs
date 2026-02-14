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
    public partial class customerReviewPage : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        private int _customerID;

        public customerReviewPage(int customerID)
        {
            InitializeComponent();
            _customerID = customerID;
        }
       

        private void customerReviewPage_Load_1(object sender, EventArgs e)
        {
            cmbRating.Items.Add("1");
            cmbRating.Items.Add("2");
            cmbRating.Items.Add("3");
            cmbRating.Items.Add("4");
            cmbRating.Items.Add("5");

            LoadReviews();
        }
        
       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtproductname1.Text == "" ||
             cmbRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO CustomerReviews
                                (CustomerID, ProductName, Rating, ReviewText)
                                VALUES (@CustomerID, @ProductName, @Rating, @ReviewText)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", _customerID);
                cmd.Parameters.AddWithValue("@ProductName", txtproductname1.Text);
                cmd.Parameters.AddWithValue("@Rating", cmbRating.Text);
                cmd.Parameters.AddWithValue("@ReviewText", txtReview.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Review Submitted Successfully!");

                LoadReviews();
                ClearFields();
            }
        }
        private void LoadReviews()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        ProductName,
                        Rating,
                        ReviewText,
                        ReviewDate
                    FROM CustomerReviews
                    WHERE CustomerID = @CustomerID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", _customerID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReviews.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtproductname1.Clear();
            cmbRating.SelectedIndex = -1;
            txtReview.Clear();
        }

        private void btnhome6_Click(object sender, EventArgs e)
        {
            CustomerDashbord customerDashbord = new CustomerDashbord(this._customerID);
            this.Hide();
            customerDashbord.Show();
        }
    }
}
