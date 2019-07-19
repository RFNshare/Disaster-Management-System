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
    public partial class Enter22EmployeeForm : Form
    {
        public Enter22EmployeeForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Enter11EmployeeForm bcde = new Enter11EmployeeForm();
            this.Hide();
            bcde.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

           EmployeeLogin bcdew = new EmployeeLogin();
            this.Hide();
            bcdew.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AeMployeeRepisotary hexaRepo = new AeMployeeRepisotary();
            List<RequestedDonation> reqList = hexaRepo.GetALLRequestedDonation();
            this.RequiredDonationGridView2.DataSource = reqList;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = this.textBox5.Text;
            AeMployeeRepisotary accRepo = new AeMployeeRepisotary();
            List<RequestedDonation> accList = accRepo.SearchALLRequestedDonation(text);
            this.RequiredDonationGridView2.DataSource = accList;
        }

        private void RequiredDonationGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertBookBtn_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = this.textBox6.Text;
            AeMployeeRepisotary hexaRepoat = new AeMployeeRepisotary();
            List<DonationByDonar> reqListe = hexaRepoat.SearchALLDonarDonation(text);
            this.dataGridView1.DataSource = reqListe;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AeMployeeRepisotary hexaRepoa = new AeMployeeRepisotary();
            List<DonationByDonar> reqList = hexaRepoa.GetALLDonarGivenDonation();
            this.dataGridView1.DataSource = reqList;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
