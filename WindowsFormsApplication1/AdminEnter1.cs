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
    public partial class AdminEnter1 : Form
    {
        public AdminEnter1()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            AdminPanelLogin bd = new AdminPanelLogin();
            this.Hide();
            bd.Show();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            AdminEnter22 bdc = new AdminEnter22();
            this.Hide();
            bdc.Show();
        }
    }
}
