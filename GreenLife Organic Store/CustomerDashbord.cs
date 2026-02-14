using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenLife_Organic_Store
{
    public partial class CustomerDashbord : Form
    {
        public int customerID;

        public CustomerDashbord(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void btnPlaceOrders_Click(object sender, EventArgs e)
        {
            Makeuorder makeuorder= new Makeuorder(this.customerID);
            this.Hide();
            makeuorder.ShowDialog();
        }

        private void btnlogout2_Click(object sender, EventArgs e)
        {
            LOGIN lOGIN = new LOGIN();
            this.Hide();
            lOGIN.ShowDialog();
        }

        private void btntrack_Click(object sender, EventArgs e)
        {
            


            TrackYourorder track = new TrackYourorder(this.customerID);
            this.Hide();
            track.Show();
        }

        private void btnProfileManagement_Click(object sender, EventArgs e)
        {
           


            CustomerProfilemanagement customerProfilemanagement = new CustomerProfilemanagement(this.customerID);
            this.Hide();
            customerProfilemanagement.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            customerReviewPage customerReviewPage = new customerReviewPage(this.customerID);
            this.Hide();
            customerReviewPage.Show();
        }

        private void CustomerDashbord_Load(object sender, EventArgs e)
        {

        }
    }
}
