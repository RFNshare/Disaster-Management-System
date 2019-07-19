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
    public partial class RecieverLogin : Form
    {
        public RecieverLogin()
        {
            InitializeComponent();
        }

        private void RecieverReg_click(object sender, EventArgs e)
        {
            //RecieverLogin
                 RecieverRegForm basam = new RecieverRegForm();
            basam.Show();
            this.Hide();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Firstpage asa = new Firstpage();
            asa.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            EnterReciever1 a1 = new EnterReciever1();
            this.Hide();
            a1.Show();
        }
    }
}
