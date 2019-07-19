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
    public partial class EnterDonar2 : Form
    {
        public EnterDonar2()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DonarLogin zm = new DonarLogin();
            this.Hide();
            zm.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
           EnterDonar1 zmx = new EnterDonar1();
            this.Hide();
            zmx.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
              Enter2DonarForm zmxz = new  Enter2DonarForm();
              this.Hide();
             zmxz.Show();
        }
    }
}
