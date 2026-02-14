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
    public partial class AdminRegistation : Form
    {
        public AdminRegistation()
        {
            InitializeComponent();
        }

        private void lblAdminRegistration_Click(object sender, EventArgs e)
        {

        }

        private void txtadminpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadminRegister_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
             

            if (string.IsNullOrWhiteSpace(txtadminfullname.Text) ||
                string.IsNullOrWhiteSpace(txtadminusername.Text) ||
                string.IsNullOrWhiteSpace(txtadminpassword.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string checkQuery = "SELECT COUNT(*) FROM Admin WHERE username=@username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@username", txtadminusername.Text);

                con.Open();
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists. Choose another.");
                    con.Close();
                    return;
                }


                string insertQuery =
                    @"INSERT INTO Admin (fullname,username, password) 
                       VALUES(@fullname,@username, @password)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@fullname", txtadminfullname.Text);
                cmd.Parameters.AddWithValue("@username", txtadminusername.Text);
                cmd.Parameters.AddWithValue("@password", txtadminpassword.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registered successfully!");
                AdminDashbord adminDashbord = new AdminDashbord();
                this.Hide();
                adminDashbord.ShowDialog();


                txtadminfullname.Clear();
                txtadminusername.Clear();
                txtadminpassword.Clear();
            }
    }

        private void txtadminusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashbord adminDashbord = new AdminDashbord();
            this.Hide();
            adminDashbord.ShowDialog();
            this.Close();
        }

        private void AdminRegistation_Load(object sender, EventArgs e)
        {

        }
    }
}
