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
    public partial class EnterReciever1 : Form
    {
        public EnterReciever1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterReciever2 a21 = new EnterReciever2();
            this.Hide();
            a21.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            RecieverLogin a1d = new RecieverLogin();
            this.Hide();
            a1d.Show();
        }
    }
}
