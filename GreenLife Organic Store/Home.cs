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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnGetStart_Click(object sender, EventArgs e)
        {
            LOGIN loginForm = new LOGIN();
            this.Hide();         
            loginForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
