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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnSALESREPORT_Click(object sender, EventArgs e)
        {
            SALES_REPORT sALES_REPORT = new SALES_REPORT();
            this.Hide();
            sALES_REPORT.ShowDialog();
        }

        private void btnhome34_Click(object sender, EventArgs e)
        {
            AdminDashbord adminDashbord = new AdminDashbord();
            this.Hide();
            adminDashbord.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock_Reports stock_Reports = new Stock_Reports();
            this.Hide();
            stock_Reports.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            ORDER_HISTORY oRDER_HISTORY = new ORDER_HISTORY(0, true);
            this.Hide();
            oRDER_HISTORY.ShowDialog();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
