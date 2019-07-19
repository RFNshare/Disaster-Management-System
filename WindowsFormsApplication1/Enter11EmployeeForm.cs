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
    public partial class Enter11EmployeeForm : Form
    {
        public Enter11EmployeeForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void searchProjectdataBtn_Click(object sender, EventArgs e)
        {
            string text = this.Searchbox1.Text;
            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();
            List<EnrollingProjectData> accList = accRepo.searchProjectdata(text);
            this.ProjectListGridView1.DataSource = accList;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime dt = new DateTime();
            string s = DateTime.Now.ToString();
            UpcomingEvent bd = new UpcomingEvent();
            bd.Projectname = this.textBox3.Text; 
            bd.ProjectID = this.textBox5.Text;
          
            bd.Projectarea = this.textBox2.Text;
          
           bd.ProposedDate = Convert.ToDateTime(this.textBox1.Text);
        


              //bList.Add(bd);

            AeMployeeRepisotary depkRepo = new AeMployeeRepisotary();
            if (depkRepo.Insert(bd))
            {

                MessageBox.Show("Can  Insert ", "Insert Sucess");

                this.textBox3.Text = "";
                this.textBox2.Text = "";
                this.textBox5.Text = "";
                this.textBox1.Text = "";

                AeMployeeRepisotary accRepo = new AeMployeeRepisotary();

                List<UpcomingEvent> bList = accRepo.GetAllUpcomingList();
                this.UpcomingProjectGridView2.DataSource = bList;
               
               
            }
            else
            {
                MessageBox.Show("Can Not Insert ", "Insert Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            string s = DateTime.Now.ToString();
            UpcomingEvent xaxxc = new UpcomingEvent();
            xaxxc.Projectname = this.textBox3.Text;
            xaxxc.ProjectID = this.textBox5.Text;

            xaxxc.Projectarea = this.textBox2.Text;

            xaxxc.ProposedDate = Convert.ToDateTime(this.textBox1.Text);



            //bList.Add(bd);

            AeMployeeRepisotary depkRepof = new AeMployeeRepisotary();
            if (depkRepof.Updatex(xaxxc))
            {

                MessageBox.Show("Update Success", "Update");

                AeMployeeRepisotary ZxRee = new AeMployeeRepisotary();

                List<UpcomingEvent> bList = ZxRee.GetAllUpcomingList();
                this.UpcomingProjectGridView2.DataSource = bList;


            }
            else
            {
                MessageBox.Show("Can Not Update", "Update Error");
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();

            UpcomingEvent tasf = new UpcomingEvent();
            tasf.Projectname = this.textBox3.Text;
            tasf.ProjectID = this.textBox5.Text;

            tasf.Projectarea = this.textBox2.Text;
            String ProjectIdtext= this.textBox5.Text;

           // tasf.ProposedDate = Convert.ToDateTime(this.textBox1.Text);



            //bList.Add(bd);

            AeMployeeRepisotary depkRepof = new AeMployeeRepisotary();
            if (depkRepof.Delete( ProjectIdtext))
            {

                MessageBox.Show("dElete Success", "Update");
                AeMployeeRepisotary accRepo = new AeMployeeRepisotary();

                List<UpcomingEvent> bList = accRepo.GetAllUpcomingList();
                this.UpcomingProjectGridView2.DataSource = bList;

            }
            else
            {
                MessageBox.Show("Can Not dElete", "dElete Error");
            }
        }

        private void searchDistributeddataBtn_Click(object sender, EventArgs e)
        {
            string text = this.UpcomingDonationSearchTextbox.Text;
            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();
            List<UpcomingEvent> accList = accRepo.searchUpcomingEvent(text);
            this.UpcomingProjectGridView2.DataSource = accList;
        }

        private void loadEmpBtn_Click(object sender, EventArgs e)
        {

            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();

            List<EnrollingProjectData> bList = accRepo.GetallEnrollingProjectdata();
            this.ProjectListGridView1.DataSource = bList;

        }

        private void LoadDistributedButton_Click(object sender, EventArgs e)
        {
            //  GetAllUpcomingList
            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();

            List<UpcomingEvent> bList = accRepo.GetAllUpcomingList();
             this.UpcomingProjectGridView2.DataSource = bList;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin r = new EmployeeLogin();
            this.Hide();
            r.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            String uid = null;
            String pass = null;
            Enter00Employee00000 h = new Enter00Employee00000(uid, pass);
            h.Show();
            this.Hide();
        }

        private void ProposedDate_Click(object sender, EventArgs e)
        {

        }

        private void DonationButton_Click(object sender, EventArgs e)
        {
          //  Enter00Employee00000 r = new Enter00Employee00000(this);
          //  this.Hide();
         //   r.Show();
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            Enter22EmployeeForm ra = new Enter22EmployeeForm();
            this.Hide();
            ra.Show();
        }
    }
}
