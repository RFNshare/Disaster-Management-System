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
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            InitializeComponent();
        }

        private void DonarInterface_Click(object sender, EventArgs e)
        {
            DonarLogin vxa = new DonarLogin();
            vxa.Show();
            this.Hide();
        }

        private void EmployeeLogin_click(object sender, EventArgs e)
        {
            EmployeeLogin asa = new EmployeeLogin();
            asa.Show();
            this.Hide();
        }

        private void RecieverLogin_click(object sender, EventArgs e)
        {
            RecieverLogin asam = new RecieverLogin();
            asam.Show();
            this.Hide();
        }
    }
}
