using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastPassport.Forms
{
    public partial class ApplicantDashboardForm : Form
    {
        //final
        public ApplicantDashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("To apply for an adult press Yes else for a child passport press No", "Passport Application", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Redirect to adult passport portal page
                AdultPassportPortalForm adultPassportPortalForm = new AdultPassportPortalForm();
                adultPassportPortalForm.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                // Redirect to child passport portal page
                ChildPassportPortalForm childPassportPortalForm = new ChildPassportPortalForm();
                childPassportPortalForm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RenewPassport RenewPassport = new RenewPassport();
            RenewPassport.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplyforLostPassport ApplyforLostPassport = new ApplyforLostPassport();
            ApplyforLostPassport.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewApplicationStatus ViewApplicationStatus = new ViewApplicationStatus();
            ViewApplicationStatus.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Closed += (s, args) => this.Close();
            loginPage.Show();
        }
    }
}
