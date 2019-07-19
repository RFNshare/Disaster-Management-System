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
    public partial class EnterReciever2 : Form
    {
        public EnterReciever2()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            EnterReciever1 a1 = new EnterReciever1();
            this.Hide();
            a1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecieverLogin a1d = new RecieverLogin();
            this.Hide();
            a1d.Show();
        }
    }
}
