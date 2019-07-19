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
    public partial class EnterDonar1 : Form
    {
        public EnterDonar1()
        {
            InitializeComponent();
        }

        private void EnterDonar1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterDonar2 z = new EnterDonar2();
            this.Hide();
            z.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DonarLogin zm = new DonarLogin();
            this.Hide();
            zm.Show();
        }
    }
}
