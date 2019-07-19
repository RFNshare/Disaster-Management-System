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

    
    public partial class Enter00Employee00000 : Form
    {
        public string var;

        public Enter00Employee00000(String uid,String pass)

           /// String a = uid;
        {


            //  public Enter00Employee0000 { InitializeComponent(); }
            InitializeComponent();
            //This ios the technique
            //This ios the technique
            this.VariableHolderValueLabel.Text = uid; //This ios the technique
            //This ios the technique
            //This ios the technique
        //    this..Text = pass;


         
            





        }

    private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DonationItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Enter00Employee00000_Load(object sender, EventArgs e)
        {

        }
       // String ax = uid;

        private void LoadDistributedButton_Click(object sender, EventArgs e)
        {
            AeMployeeRepisotary bookRepo = new AeMployeeRepisotary ();


            //  GetAllDonation
            //  string text = this.ProjectListGridView1.Text;
            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();
            List<DonationByNgo> accList = accRepo.GetAllDonation();
            this.AlreadyDistributedDonationGrid.DataSource = accList;


            //List<UpcomingEvent> bList = bookRepo.();
            //  this.bookGridView.DataSource = bList;
        }

        private void DonateNowButton_CLICK(object sender, EventArgs e)
        {
           
         
            string s = DateTime.Now.ToString();
            DonationByNgo bd = new DonationByNgo();
            bd.DonationId = this.RecieverIDtextBox5.Text;
          
              bd.DonationTitle =  Convert.ToString(this.DonationTitleCombobox.SelectedItem);
            bd.RecieverId = this.donationIDtextBox.Text;
            bd.GivenTime = Convert.ToString(s);

            bd.DonationItem = Convert.ToString(this.DonationItemComboBox.SelectedItem);
            bd.RecieverPhone = this.ContacttextBox2.Text;
        
           bd.GiveBYID = Convert.ToString(VariableHolderValueLabel.Text);




        

            AeMployeeRepisotary bookRepo = new AeMployeeRepisotary();
            if (bookRepo.Insert(bd))
            {
           
                MessageBox.Show("Sucessfully Donated", "Insert Sucess");
                this.RecieverIDtextBox5.Text = "";
                this.ContacttextBox2.Text = "";
                this.donationIDtextBox.Text = "";
              //  this.RecieverIDtextBox5.Text = "";


            }
            else
            {
                MessageBox.Show("Donation Missing", "Insert Error");
            }
        }

        private void searchProjectdataBtn_Click(object sender, EventArgs e)
        {

            string text = this.REcieverIdidTextbox.Text;
            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();
            List<RecieverPeople> accList = accRepo.searchRecieverPeople(text);
            this.MemberListGridView1.DataSource = accList;
            // searchRecieverPeople(string text)
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void REcieverIdidTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadEmpBtn_Click(object sender, EventArgs e)
        {

          //  string text = this.ProjectListGridView1.Text;
            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();
            List<RecieverPeople> accList = accRepo.GetallRecieverPeople();
            this.MemberListGridView1.DataSource = accList;
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();

            RecieverPeople tasf = new RecieverPeople();
         //   tasf.Proj = this.textBox3.Text;
         //   tasf.ProjectID = this.textBox5.Text;

             String RecieverIdtext = this.textBox1.Text;
        //    String ProjectIdtext = this.textBox5.Text;

            // tasf.ProposedDate = Convert.ToDateTime(this.textBox1.Text);



            //bList.Add(bd);

            AeMployeeRepisotary depkRepof = new AeMployeeRepisotary();
            if (depkRepof.DeleteReciever(RecieverIdtext))
            {

                MessageBox.Show("dElete Success", "dElete");
                AeMployeeRepisotary accRepo = new AeMployeeRepisotary();

                List<RecieverPeople> bList = accRepo.GetallRecieverPeople();
                this.MemberListGridView1.DataSource = bList;

            }
            else
            {
                MessageBox.Show("Can Not dElete", "dElete Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enter11EmployeeForm r = new Enter11EmployeeForm();
            this.Hide();
            r.Show();
            
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin r = new EmployeeLogin();
            this.Hide();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = this.DistributedSearchTextbox.Text;
            AeMployeeRepisotary obj = new AeMployeeRepisotary();
            List<DonationByNgo> donobj = obj.SearchAllDonation(text);
            this.AlreadyDistributedDonationGrid.DataSource = donobj;

        }

        private void DistributedSearchTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        //here sir recommender

        private void MemberListGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //   MemberListGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() = donationIDtextBox.Text;

                 label12.Text = MemberListGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                // donationIDtextBox.Text = Convert.ToString(MemberListGridView1.Rows[e.RowIndex].Cells[0].Value);
                  label14.Text = Convert.ToString(MemberListGridView1.Rows[e.RowIndex].Cells[0].Value);
                //  MemberListGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                donationIDtextBox.Text = label14.Text;
                label14.Hide();

                ContacttextBox2.Text = label12.Text;
                label12.Hide();
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PasswordChange_Click(object sender, EventArgs e)
        {
            Employee user = new Employee();
         //   user.EmployeeId = this.label12.Text;
         //   user.EmployeePassword = this.textBox2.Text;

            string uidx = this.VariableHolderValueLabel.Text;
            string passx = this.VariableHolderValueLabel.Text;

            ChangeEmploeePassword hcx = new ChangeEmploeePassword(uidx, passx);
           hcx.Show();
            this.Hide();
        }

        private void AdminPanelRedirectButton_Click(object sender, EventArgs e)
        {
            AdminPanelLogin abz = new AdminPanelLogin();
            this.Hide();
            abz.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
