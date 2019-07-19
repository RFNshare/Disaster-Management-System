using DataRepositoryLayer;
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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Firstpage asa = new Firstpage();
            asa.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Employee user = new Employee();
            user.EmployeeId = this.EmpLogintextBox1.Text;
            user.EmployeePassword = this.EmpLoginPassbox.Text;

            string uid = this.EmpLogintextBox1.Text;
            string pass = this.EmpLogintextBox1.Text;
            //  Home h = new Home(uid, pass);
            //  h.Show();
            //  this.Hide();

            AeMployeeRepisotary empRepo = new AeMployeeRepisotary();
            if (empRepo.UserLoginVerification(user))
            {
                Enter00Employee00000 h = new Enter00Employee00000(uid, pass);
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password", "Login Failed");
            }
        }

        private void EmpLogintextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//}
