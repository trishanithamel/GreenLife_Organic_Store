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
    public partial class CustomerRegistation : Form
    {
        public CustomerRegistation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregisteruser_Click(object sender, EventArgs e)
        {
          

            string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

           
            if (string.IsNullOrWhiteSpace(txtfullname.Text) ||
                string.IsNullOrWhiteSpace(txtcontactnumber.Text) ||
                string.IsNullOrWhiteSpace(txtaddress.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                string checkQuery = "SELECT COUNT(*) FROM customers WHERE username=@username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@username", txtusername.Text);

                con.Open();
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists. Choose another.");
                    con.Close();
                    return;
                }

                
                string insertQuery = @"
        INSERT INTO customers
        (fullname, contactnumber, address, email, username, password)
        VALUES
        (@fullname, @contactnumber, @address, @email, @username, @password)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@fullname", txtfullname.Text);
                cmd.Parameters.AddWithValue("@contactnumber", txtcontactnumber.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registered successfully!");

                LOGIN loginForm = new LOGIN();
                this.Hide();
                loginForm.Show();


                txtfullname.Clear();
                txtcontactnumber.Clear();
                txtaddress.Clear();
                txtemail.Clear();
                txtusername.Clear();
                txtpassword.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback2_Click(object sender, EventArgs e)
        {
            LOGIN loginForm = new LOGIN();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void CustomerRegistation_Load(object sender, EventArgs e)
        {

        }
    }
}
