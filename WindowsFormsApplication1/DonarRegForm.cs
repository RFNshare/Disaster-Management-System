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
    public partial class DonarRegForm : Form
    {
        public DonarRegForm()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            DonarLogin asa = new DonarLogin();
            asa.Show();
            this.Hide();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            
                Donarpeople dp = new Donarpeople();
            dp.DonarId = this.DonarRegtextBox1.Text;
            dp.Donarpassword = this.donarPasswordtextBox3.Text;
            dp.DonarName = this.donarNametextBox2.Text;
            dp.DonarPhoneno = this.DonarphonenotextBox5.Text;
            dp.Organization =this.DonarProjectTextBox4.Text;

            ADonarRepository bookRepo = new ADonarRepository();
            if (bookRepo.Insert(dp))
            {
                MessageBox.Show("Can Insert", "ffffr");
            }
                //      List<Book> bList = bookRepo.GetAllBooks();
                //      this.bookGridView.DataSource = bList;

                  else
                 {
                  MessageBox.Show("Can Not Insert Book", "Insert Error");
                  }

            }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Donarpeople dp = new Donarpeople();
            dp.DonarId = this.DonarRegtextBox1.Text;
            dp.Donarpassword = this.donarPasswordtextBox3.Text;
            dp.DonarName = this.donarNametextBox2.Text;
            dp.DonarPhoneno = this.DonarProjectTextBox4.Text;
            dp.Organization = this.DonarphonenotextBox5.Text;

            ADonarRepository cmcRepo = new ADonarRepository();
            if (cmcRepo.Update(dp))
            {
                MessageBox.Show("Can update ", "SUCCESS");
            }
            //      List<Book> bList = bookRepo.GetAllBooks();
            //      this.bookGridView.DataSource = bList;

            else
            {
                MessageBox.Show("Can Not update", "Insert Error");
            }
        }
    }
}
