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
    public partial class Admincustomermanagement : Form
    {
        string connectionString = @"Data Source=DESKTOP-NPUV7AB\SQLEXPRESS04;Initial Catalog=GreenLifeOrganicStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        SqlDataAdapter da;
        DataTable dt;

        public Admincustomermanagement()
        {
            InitializeComponent();
        }
        private void LoadAllCustomers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM customers";
                da = new SqlDataAdapter(query, con);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                dt = new DataTable();
                da.Fill(dt);

                dgvSearchUser.DataSource = dt;

                dgvSearchUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSearchUser.AllowUserToAddRows = false;
                dgvSearchUser.ReadOnly = true; // Initially read only
            }
        }

        private void Admincustomermanagement_Load(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchUser.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query;

                if (int.TryParse(searchValue, out int id))
                {
                    // Show searched ID first, then others
                    query = @"
                SELECT * FROM customers
                ORDER BY 
                CASE 
                    WHEN customerID = @id THEN 0
                    ELSE 1
                END, customerID";

                    da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@id", id);
                }
                else
                {
                    // If searching by name
                    query = @"
                SELECT * FROM customers
                ORDER BY 
                CASE 
                    WHEN fullname LIKE @search 
                         OR username LIKE @search THEN 0
                    ELSE 1
                END, customerID";

                    da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                }

                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                dt = new DataTable();
                da.Fill(dt);

                dgvSearchUser.DataSource = dt;
                dgvSearchUser.ReadOnly = true;
            }
        }

        private void dgvSearchUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            if (dgvSearchUser.Rows.Count == 0)
            {
                MessageBox.Show("No data available to update.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvSearchUser.ReadOnly = false;

            // Protect customerID column
            if (dgvSearchUser.Columns.Contains("customerID"))
            {
                dgvSearchUser.Columns["customerID"].ReadOnly = true;
            }

            MessageBox.Show("Edit the data, then click SAVE to apply changes.",
                "Edit Mode Enabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvSearchUser.EndEdit();

                // Create a NEW connection and adapter
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Use full table SELECT for proper update commands
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customers", con))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        // Important: Use the same dt that is bound to DataGridView
                        adapter.Update(dt);
                    }
                }

                MessageBox.Show("Customer data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvSearchUser.ReadOnly = true;

                // Refresh grid after saving
                LoadAllCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnhome4_Click(object sender, EventArgs e)
        {
            AdminDashbord adminDashbord = new AdminDashbord();
            this.Hide();
            adminDashbord.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }