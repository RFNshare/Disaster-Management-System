using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminEnter22 : Form
    {
        public AdminEnter22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminEnter1 bz = new AdminEnter1();
            this.Hide();
            bz.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminPanelLogin bd = new AdminPanelLogin();
            this.Hide();
            bd.Show();
        }

        private void AlreadyDistributedDonationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
