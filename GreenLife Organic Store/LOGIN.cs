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
using static System.Collections.Specialized.BitVector32;

namespace GreenLife_Organic_Store
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            if (string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

               
                string adminQuery = @"
                 SELECT COUNT(*) 
                  FROM Admin 
                 WHERE Username=@username AND password=@password";

                SqlCommand adminCmd = new SqlCommand(adminQuery, con);
                adminCmd.Parameters.AddWithValue("@username", txtusername.Text);
                adminCmd.Parameters.AddWithValue("@password", txtpassword.Text);

                int adminResult = (int)adminCmd.ExecuteScalar();

                if (adminResult > 0)
                {
                    MessageBox.Show("Admin login successful!");

                    AdminDashbord adminDashboard = new AdminDashbord();
                    this.Hide();
                    adminDashboard.ShowDialog();
                    return;
                }

               
                string customerQuery = @"
    SELECT CustomerID 
    FROM Customers 
    WHERE username=@username AND password=@password";

                SqlCommand customerCmd = new SqlCommand(customerQuery, con);
                customerCmd.Parameters.AddWithValue("@username", txtusername.Text);
                customerCmd.Parameters.AddWithValue("@password", txtpassword.Text);

                object result = customerCmd.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("Customer login successful!");

                   
                    string getCustomerIDQuery = "SELECT CustomerID FROM Customers WHERE Username=@username AND Password=@password";
                    SqlCommand idCmd = new SqlCommand(getCustomerIDQuery, con);
                    idCmd.Parameters.AddWithValue("@username", txtusername.Text);
                    idCmd.Parameters.AddWithValue("@password", txtpassword.Text);

                    int customerID = Convert.ToInt32(idCmd.ExecuteScalar()); 

                    CustomerDashbord customerDashbord = new CustomerDashbord(customerID);
                    this.Hide();
                    customerDashbord.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    txtpassword.Clear();
                    txtpassword.Focus();
                }
            }
        }

        private void lnkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegistation customerRegistation = new CustomerRegistation();
            customerRegistation.Show();   

            this.Hide();

        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
