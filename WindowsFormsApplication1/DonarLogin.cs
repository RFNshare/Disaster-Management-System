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
    public partial class DonarLogin : Form
    {
        public DonarLogin()
        {
            InitializeComponent();
        }

        private void DonarRegButton_Click(object sender, EventArgs e)
        {
            DonarRegForm vx = new DonarRegForm();
            vx.Show();
            this.Hide();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          //  EnterDonar1

                EnterDonar1 vx = new EnterDonar1();
            vx.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Firstpage asa = new Firstpage();
            asa.Show();
            this.Hide();
        }
    }
}
