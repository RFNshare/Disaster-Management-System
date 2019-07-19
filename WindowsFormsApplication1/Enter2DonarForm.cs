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
    public partial class Enter2DonarForm : Form
    {
        public Enter2DonarForm()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            EnterDonar2 szmx = new EnterDonar2();
            this.Hide();
            szmx.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

            DonarLogin szmxx = new DonarLogin();
            this.Hide();
            szmxx.Show();
        }
    }
}
