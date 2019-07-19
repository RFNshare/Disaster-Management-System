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
    public partial class AdminPanelLogin : Form
    {
        public AdminPanelLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            AdminEnter1 abz = new AdminEnter1();
            this.Hide();
            abz.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            String uid = null;
            String pass = null;
            Enter00Employee00000  abzm = new Enter00Employee00000(uid,pass);
            this.Hide();
            abzm.Show();
        }
    }
}
