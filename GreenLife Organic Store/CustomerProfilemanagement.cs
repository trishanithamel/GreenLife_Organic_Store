using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLife_Organic_Store
{
    public partial class CustomerProfilemanagement : Form
    {
        int customerID; 
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;
                                    Initial Catalog=GreenLifeOrganicStore;
                                    Integrated Security=True;
                                    Connect Timeout=30;Encrypt=False;";
        public CustomerProfilemanagement(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;

            
            txtFullName1.Enabled = false;
            txtContactNumbe1.Enabled = false;
            txtAddress1.Enabled = false;
            txtEmail1.Enabled = false;
            txtUsername1.Enabled = false;
            txtPassword1.Enabled = false;
        }

        private void CustomerProfilemanagement_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = "SELECT * FROM customers WHERE customerID = @CustomerID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtFullName1.Text = reader["fullname"].ToString();
                        txtContactNumbe1.Text = reader["contactnumber"].ToString();
                        txtAddress1.Text = reader["address"].ToString();
                        txtEmail1.Text = reader["email"].ToString();
                        txtUsername1.Text = reader["username"].ToString();
                        txtPassword1.Text = reader["password"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
        }

    
       
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFullName1.Text))
            {
                MessageBox.Show("Full name cannot be empty.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail1.Text))
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtEmail1.Text, emailPattern))
                {
                    MessageBox.Show("Invalid email format.");
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtContactNumbe1.Text))
            {
                string contactPattern = @"^[0-9\s+-]+$";
                if (!Regex.IsMatch(txtContactNumbe1.Text, contactPattern))
                {
                    MessageBox.Show("Invalid contact number.");
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtPassword1.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return false;
            }

            return true;
        }

        private void btnupdate2_Click(object sender, EventArgs e)
        {
            txtFullName1.Enabled = true;
            txtContactNumbe1.Enabled = true;
            txtAddress1.Enabled = true;
            txtEmail1.Enabled = true;
            txtUsername1.Enabled = true;
            txtPassword1.Enabled = true;
        
    }

        private void btnsave1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string updateQuery = @"
                        UPDATE customers
                        SET fullname = @FullName,
                            contactnumber = @Contact,
                            address = @Address,
                            email = @Email,
                            username = @Username,
                            password = @Password
                        WHERE customerID = @CustomerID";

                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName1.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContactNumbe1.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress1.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail1.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername1.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword1.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Profile updated successfully!");
                    else
                        MessageBox.Show("No changes were made.");

                    
                    txtFullName1.Enabled = false;
                    txtContactNumbe1.Enabled = false;
                    txtAddress1.Enabled = false;
                    txtEmail1.Enabled = false;
                    txtUsername1.Enabled = false;
                    txtPassword1.Enabled = false;

                    LoadCustomerData(); 
                }
                catch (SqlException sqlEx) when (sqlEx.Number == 2627) 
                {
                    MessageBox.Show("Username already exists. Please choose another.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving profile: " + ex.Message);
                }
            }
        }

        private void btnhome4_Click(object sender, EventArgs e)
        {
            CustomerDashbord customerDashbord = new CustomerDashbord(this.customerID);
            this.Hide();
            customerDashbord.ShowDialog();
        }
    }
}
