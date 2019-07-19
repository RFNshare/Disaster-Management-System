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
    public partial class ChangeEmploeePassword : Form
    {
        public ChangeEmploeePassword(String Uidx,String passx)


        {


            InitializeComponent();
            this.label2.Text = Uidx;
        }

        private void DonateSuccessButton_Click(object sender, EventArgs e)
        {


            Employee pas11st = new Employee();
            pas11st.EmployeeId = this.UserIDTextBox.Text;
            pas11st.EmployeePassword = this.PasswordTextOLD.Text;


            Employee pas22nd = new Employee();
            pas22nd.EmployeeId = this.UserIDTextBox.Text;
            pas22nd.EmployeePassword = this.NewPasswordTEXTBOx.Text;



            AeMployeeRepisotary empRepod11 = new AeMployeeRepisotary();
            if (empRepod11.UserLoginVerification(pas11st))
            {
                empRepod11.Updater(pas22nd);


                MessageBox.Show("Changed Success", "Update");
            }

            else
            {
                MessageBox.Show("your ID or OLd Password did not Matched", "Failed");
            }


        }

        private void ContacttextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
         //  Enter00Employee00000 aspc = new Enter00Employee00000();
          //  this.Hide();
         //   aspc.Show();
        }

        private void donationIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        // String val ;


       }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String uid = null;
            String pass = null;
            Enter00Employee00000 h = new Enter00Employee00000(uid, pass);
            h.Show();
            this.Hide();
        }
        // }
    }
}
